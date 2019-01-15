namespace fbook
{
    partial class WithoutInternetConnection
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
            this.NCdesc = new MaterialSkin.Controls.MaterialLabel();
            this.erCode = new System.Windows.Forms.Label();
            this.closeBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.NCaction = new System.Windows.Forms.Label();
            this.erImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.erImg)).BeginInit();
            this.SuspendLayout();
            // 
            // NCdesc
            // 
            this.NCdesc.AutoSize = true;
            this.NCdesc.BackColor = System.Drawing.Color.Transparent;
            this.NCdesc.Depth = 0;
            this.NCdesc.Font = new System.Drawing.Font("Roboto", 11F);
            this.NCdesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NCdesc.Location = new System.Drawing.Point(29, 233);
            this.NCdesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.NCdesc.Name = "NCdesc";
            this.NCdesc.Size = new System.Drawing.Size(455, 38);
            this.NCdesc.TabIndex = 1;
            this.NCdesc.Text = "We have detected that this device is not connected to the Internet. \r\nPlease chec" +
    "k your connection before trying again.";
            this.NCdesc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // erCode
            // 
            this.erCode.AutoSize = true;
            this.erCode.BackColor = System.Drawing.Color.Transparent;
            this.erCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erCode.ForeColor = System.Drawing.Color.White;
            this.erCode.Location = new System.Drawing.Point(453, 38);
            this.erCode.Name = "erCode";
            this.erCode.Size = new System.Drawing.Size(50, 13);
            this.erCode.TabIndex = 2;
            this.erCode.Text = "#00001";
            // 
            // closeBtn
            // 
            this.closeBtn.Depth = 0;
            this.closeBtn.Location = new System.Drawing.Point(33, 296);
            this.closeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Primary = true;
            this.closeBtn.Size = new System.Drawing.Size(444, 36);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "OK";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // NCaction
            // 
            this.NCaction.AutoSize = true;
            this.NCaction.BackColor = System.Drawing.Color.Transparent;
            this.NCaction.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCaction.ForeColor = System.Drawing.Color.DimGray;
            this.NCaction.Location = new System.Drawing.Point(131, 89);
            this.NCaction.Name = "NCaction";
            this.NCaction.Size = new System.Drawing.Size(247, 25);
            this.NCaction.TabIndex = 5;
            this.NCaction.Text = "No internet connection.  ;-(";
            // 
            // erImg
            // 
            this.erImg.BackColor = System.Drawing.Color.Transparent;
            this.erImg.Image = global::fbook.Properties.Resources.NoConnectionimg;
            this.erImg.Location = new System.Drawing.Point(181, 100);
            this.erImg.Name = "erImg";
            this.erImg.Size = new System.Drawing.Size(150, 140);
            this.erImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erImg.TabIndex = 3;
            this.erImg.TabStop = false;
            // 
            // WithoutInternetConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 355);
            this.Controls.Add(this.NCaction);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.erCode);
            this.Controls.Add(this.NCdesc);
            this.Controls.Add(this.erImg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WithoutInternetConnection";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The application will close.";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WithoutInternetConnection_FormClosed);
            this.Load += new System.EventHandler(this.WithoutInternetConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel NCdesc;
        private System.Windows.Forms.Label erCode;
        private System.Windows.Forms.PictureBox erImg;
        private MaterialSkin.Controls.MaterialRaisedButton closeBtn;
        private System.Windows.Forms.Label NCaction;
    }
}