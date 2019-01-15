namespace fbook
{
    partial class Process
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProcessBrowser = new System.Windows.Forms.WebBrowser();
            this.bTimer = new System.Windows.Forms.Timer(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // ProcessBrowser
            // 
            this.ProcessBrowser.AllowWebBrowserDrop = false;
            this.ProcessBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessBrowser.Location = new System.Drawing.Point(0, 0);
            this.ProcessBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.ProcessBrowser.Name = "ProcessBrowser";
            this.ProcessBrowser.ScriptErrorsSuppressed = true;
            this.ProcessBrowser.Size = new System.Drawing.Size(120, 56);
            this.ProcessBrowser.TabIndex = 0;
            this.ProcessBrowser.Visible = false;
            this.ProcessBrowser.WebBrowserShortcutsEnabled = false;
            this.ProcessBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.ProcessBrowser_DocumentCompleted_1);
            // 
            // bTimer
            // 
            this.bTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(88, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Please Wait";
            // 
            // Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 56);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ProcessBrowser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Process_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer bTimer;
        public System.Windows.Forms.WebBrowser ProcessBrowser;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}