namespace ProjectParallel.Gui
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCache = new System.Windows.Forms.Button();
            this.nudCacheKey = new System.Windows.Forms.NumericUpDown();
            this.rtbCache = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCacheKey)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCache
            // 
            this.btnCache.Location = new System.Drawing.Point(62, 146);
            this.btnCache.Name = "btnCache";
            this.btnCache.Size = new System.Drawing.Size(151, 50);
            this.btnCache.TabIndex = 3;
            this.btnCache.Text = "Cache";
            this.btnCache.UseVisualStyleBackColor = true;
            this.btnCache.Click += new System.EventHandler(this.btnCache_Click);
            // 
            // nudCacheKey
            // 
            this.nudCacheKey.Location = new System.Drawing.Point(260, 162);
            this.nudCacheKey.Name = "nudCacheKey";
            this.nudCacheKey.Size = new System.Drawing.Size(92, 23);
            this.nudCacheKey.TabIndex = 4;
            // 
            // rtbCache
            // 
            this.rtbCache.Location = new System.Drawing.Point(371, 146);
            this.rtbCache.Name = "rtbCache";
            this.rtbCache.Size = new System.Drawing.Size(121, 47);
            this.rtbCache.TabIndex = 5;
            this.rtbCache.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbCache);
            this.Controls.Add(this.nudCacheKey);
            this.Controls.Add(this.btnCache);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCacheKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCache;
        private NumericUpDown nudCacheKey;
        private RichTextBox rtbCache;
    }
}