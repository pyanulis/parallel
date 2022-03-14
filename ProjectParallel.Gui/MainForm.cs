using Microsoft.VisualStudio.Threading;

namespace ProjectParallel.Gui
{
    public partial class MainForm : Form
    {
        private AsyncCache<int, int> m_asyncCacheInt;

        public MainForm()
        {
            InitializeComponent();
            m_asyncCacheInt = new AsyncCache<int, int>(ProduceAsync);
        }

        private async Task<int> ProduceAsync(int key)
        {
            return await Task.Run(() => 
            {
                Thread.Sleep(3000);
                return key * 2;
            });
        }

        private AsyncLazy<int> LazyIntAsync = new AsyncLazy<int>(async () =>
        {
            return await Task.Run<int>(() =>
            {
                Task.Delay(3000).Wait();
                return Thread.CurrentThread.ManagedThreadId;
            });
        });

        private async void btnCache_Click(object sender, EventArgs e)
        {
            int key = (int)nudCacheKey.Value;
            int value = await m_asyncCacheInt.GetValueAsync(key);
            rtbCache.AppendText($"{key}: {value} {Environment.NewLine}");
        }
    }
}