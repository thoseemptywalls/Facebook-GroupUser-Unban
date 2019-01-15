namespace fbook
{
    partial class MainLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.InternetSttsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ConnectBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.InternetStts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InternetStts)).BeginInit();
            this.SuspendLayout();
            // 
            // InternetSttsLabel
            // 
            this.InternetSttsLabel.AutoSize = true;
            this.InternetSttsLabel.Depth = 0;
            this.InternetSttsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.InternetSttsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InternetSttsLabel.Location = new System.Drawing.Point(10, 75);
            this.InternetSttsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.InternetSttsLabel.Name = "InternetSttsLabel";
            this.InternetSttsLabel.Size = new System.Drawing.Size(64, 19);
            this.InternetSttsLabel.TabIndex = 1;
            this.InternetSttsLabel.Text = "Internet:";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Depth = 0;
            this.ConnectBtn.Location = new System.Drawing.Point(97, 122);
            this.ConnectBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Primary = true;
            this.ConnectBtn.Size = new System.Drawing.Size(81, 69);
            this.ConnectBtn.TabIndex = 3;
            this.ConnectBtn.Text = "LOGIN";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // InternetStts
            // 
            this.InternetStts.BackColor = System.Drawing.Color.Transparent;
            this.InternetStts.Image = global::fbook.Properties.Resources.Ok;
            this.InternetStts.Location = new System.Drawing.Point(36, 67);
            this.InternetStts.Name = "InternetStts";
            this.InternetStts.Size = new System.Drawing.Size(100, 35);
            this.InternetStts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InternetStts.TabIndex = 2;
            this.InternetStts.TabStop = false;
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 215);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.InternetSttsLabel);
            this.Controls.Add(this.InternetStts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainLogin";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBM";
            this.Activated += new System.EventHandler(this.MainLogin_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Loading_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InternetStts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel InternetSttsLabel;
        private System.Windows.Forms.PictureBox InternetStts;
        public MaterialSkin.Controls.MaterialRaisedButton ConnectBtn;
    }
}

