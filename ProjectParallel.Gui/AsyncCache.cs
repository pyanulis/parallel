using Microsoft;
using Microsoft.VisualStudio.Threading;
using System.Collections.Concurrent;

namespace ProjectParallel.Gui
{
    internal class AsyncCache<TKey, TValue>
    {
        private readonly Func<TKey, Task<TValue>> m_factoryFunc;
        private readonly ConcurrentDictionary<TKey, AsyncLazy<TValue>> m_lazyCache;

        public AsyncCache(Func<TKey, Task<TValue>> factoryFunc)
        {
            Requires.NotNull(factoryFunc, nameof(factoryFunc));
            m_factoryFunc = factoryFunc;
            m_lazyCache = new ConcurrentDictionary<TKey, AsyncLazy<TValue>>();
        }

        public async Task<TValue> GetValueAsync(TKey key)
        {
            if (!typeof(TKey).IsValueType)
            {
                object o = key;
                Requires.NotNull(o, nameof(key));
            }

            return await m_lazyCache.GetOrAdd(
                key,
                (k) =>
                {
                    return new AsyncLazy<TValue>(async () =>
                    {
                        return await m_factoryFunc(k);
                    });
                }).GetValueAsync();
        }
    }
}
