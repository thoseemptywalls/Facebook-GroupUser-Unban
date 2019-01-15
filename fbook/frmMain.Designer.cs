namespace fbook
{
    partial class frmMain
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
            MaterialSkin.Controls.MaterialLabel materialLabel4;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnGetUserID = new MaterialSkin.Controls.MaterialRaisedButton();
            this.IdUserInput = new MaterialSkin.Controls.MaterialLabel();
            this.UserLink = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.Divisor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.userIDtoUnban = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel4
            // 
            materialLabel4.Depth = 0;
            materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialLabel4.Location = new System.Drawing.Point(330, 31);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new System.Drawing.Size(18, 22);
            materialLabel4.TabIndex = 7;
            materialLabel4.Text = "+";
            materialLabel4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialRaisedButton1);
            this.groupBox1.Controls.Add(this.BtnGetUserID);
            this.groupBox1.Controls.Add(this.IdUserInput);
            this.groupBox1.Controls.Add(this.UserLink);
            this.groupBox1.Location = new System.Drawing.Point(23, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(247, -4);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(175, 22);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Get User ID / Group ID";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(390, 39);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 22);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "=    ID:";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(589, 34);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(45, 27);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Copy";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // BtnGetUserID
            // 
            this.BtnGetUserID.Depth = 0;
            this.BtnGetUserID.Location = new System.Drawing.Point(145, 83);
            this.BtnGetUserID.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGetUserID.Name = "BtnGetUserID";
            this.BtnGetUserID.Primary = true;
            this.BtnGetUserID.Size = new System.Drawing.Size(396, 27);
            this.BtnGetUserID.TabIndex = 2;
            this.BtnGetUserID.Text = "GO";
            this.BtnGetUserID.UseVisualStyleBackColor = true;
            this.BtnGetUserID.Click += new System.EventHandler(this.BtnGetUserID_Click);
            // 
            // IdUserInput
            // 
            this.IdUserInput.Depth = 0;
            this.IdUserInput.Font = new System.Drawing.Font("Roboto", 11F);
            this.IdUserInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IdUserInput.Location = new System.Drawing.Point(442, 39);
            this.IdUserInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.IdUserInput.Name = "IdUserInput";
            this.IdUserInput.Size = new System.Drawing.Size(141, 22);
            this.IdUserInput.TabIndex = 3;
            this.IdUserInput.Text = "0000000000000000";
            this.IdUserInput.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UserLink
            // 
            this.UserLink.Depth = 0;
            this.UserLink.Hint = "";
            this.UserLink.Location = new System.Drawing.Point(67, 42);
            this.UserLink.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserLink.Name = "UserLink";
            this.UserLink.PasswordChar = '\0';
            this.UserLink.SelectedText = "";
            this.UserLink.SelectionLength = 0;
            this.UserLink.SelectionStart = 0;
            this.UserLink.Size = new System.Drawing.Size(317, 23);
            this.UserLink.TabIndex = 0;
            this.UserLink.Text = "https://www.facebook.com/ThoseEmptyWalls";
            this.UserLink.UseSystemPasswordChar = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(-1, 75);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(716, 45);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Aguardando usuário";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aTimer
            // 
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // Divisor
            // 
            this.Divisor.Depth = 0;
            this.Divisor.Enabled = false;
            this.Divisor.Location = new System.Drawing.Point(-5, 131);
            this.Divisor.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divisor.Name = "Divisor";
            this.Divisor.Primary = true;
            this.Divisor.Size = new System.Drawing.Size(721, 26);
            this.Divisor.TabIndex = 6;
            this.Divisor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(materialLabel4);
            this.groupBox2.Controls.Add(this.materialRaisedButton2);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.userIDtoUnban);
            this.groupBox2.Controls.Add(this.groupID);
            this.groupBox2.Location = new System.Drawing.Point(23, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 142);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(406, 59);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(106, 22);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "UserID";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(164, 59);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(106, 22);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Group ID";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(145, 101);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(396, 27);
            this.materialRaisedButton2.TabIndex = 7;
            this.materialRaisedButton2.Text = "UNBAN";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(244, -3);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(186, 22);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Unban User From Group";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userIDtoUnban
            // 
            this.userIDtoUnban.Depth = 0;
            this.userIDtoUnban.Hint = "";
            this.userIDtoUnban.Location = new System.Drawing.Point(381, 33);
            this.userIDtoUnban.MouseState = MaterialSkin.MouseState.HOVER;
            this.userIDtoUnban.Name = "userIDtoUnban";
            this.userIDtoUnban.PasswordChar = '\0';
            this.userIDtoUnban.SelectedText = "";
            this.userIDtoUnban.SelectionLength = 0;
            this.userIDtoUnban.SelectionStart = 0;
            this.userIDtoUnban.Size = new System.Drawing.Size(146, 23);
            this.userIDtoUnban.TabIndex = 9;
            this.userIDtoUnban.UseSystemPasswordChar = false;
            this.userIDtoUnban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userIDtoUnban_KeyPress);
            // 
            // groupID
            // 
            this.groupID.Depth = 0;
            this.groupID.Hint = "";
            this.groupID.Location = new System.Drawing.Point(145, 33);
            this.groupID.MouseState = MaterialSkin.MouseState.HOVER;
            this.groupID.Name = "groupID";
            this.groupID.PasswordChar = '\0';
            this.groupID.SelectedText = "";
            this.groupID.SelectionLength = 0;
            this.groupID.SelectionStart = 0;
            this.groupID.Size = new System.Drawing.Size(146, 23);
            this.groupID.TabIndex = 7;
            this.groupID.UseSystemPasswordChar = false;
            this.groupID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.groupID_KeyPress);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Divisor);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBM";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabel;
        public MaterialSkin.Controls.MaterialSingleLineTextField UserLink;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer aTimer;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGetUserID;
        private MaterialSkin.Controls.MaterialLabel IdUserInput;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton Divisor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialSingleLineTextField groupID;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        public MaterialSkin.Controls.MaterialSingleLineTextField userIDtoUnban;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}