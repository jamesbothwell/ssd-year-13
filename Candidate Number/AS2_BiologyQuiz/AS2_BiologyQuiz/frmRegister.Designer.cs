
namespace AS2_BiologyQuiz
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.LinkLabel();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblAlreadyReg = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxConPassword = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.tbxHint = new System.Windows.Forms.TextBox();
            this.lblChosenAvatar = new System.Windows.Forms.Label();
            this.pbxAvatar1 = new System.Windows.Forms.PictureBox();
            this.pbxCurrentAvatar = new System.Windows.Forms.PictureBox();
            this.pbxAvatar5 = new System.Windows.Forms.PictureBox();
            this.pbxAvatar6 = new System.Windows.Forms.PictureBox();
            this.pbxAvatar3 = new System.Windows.Forms.PictureBox();
            this.pbxAvatar4 = new System.Windows.Forms.PictureBox();
            this.pbxAvatar2 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlReg = new System.Windows.Forms.Panel();
            this.menuStripRegister = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar2)).BeginInit();
            this.pnlReg.SuspendLayout();
            this.menuStripRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(279, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create Account";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(120, 126);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(120, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblConPassword
            // 
            this.lblConPassword.AutoSize = true;
            this.lblConPassword.Location = new System.Drawing.Point(120, 219);
            this.lblConPassword.Name = "lblConPassword";
            this.lblConPassword.Size = new System.Drawing.Size(104, 15);
            this.lblConPassword.TabIndex = 3;
            this.lblConPassword.Text = "Confirm Password";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.LinkColor = System.Drawing.Color.DarkOliveGreen;
            this.lblLogin.Location = new System.Drawing.Point(377, 383);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 15);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.TabStop = true;
            this.lblLogin.Text = "Login Here";
            this.lblLogin.VisitedLinkColor = System.Drawing.Color.PaleGreen;
            this.lblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Location = new System.Drawing.Point(548, 262);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(84, 15);
            this.lblAvatar.TabIndex = 5;
            this.lblAvatar.Text = "Choose Avatar";
            // 
            // lblAlreadyReg
            // 
            this.lblAlreadyReg.AutoSize = true;
            this.lblAlreadyReg.Location = new System.Drawing.Point(356, 344);
            this.lblAlreadyReg.Name = "lblAlreadyReg";
            this.lblAlreadyReg.Size = new System.Drawing.Size(110, 15);
            this.lblAlreadyReg.TabIndex = 6;
            this.lblAlreadyReg.Text = "Already Registered?";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(294, 123);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 23);
            this.tbxUsername.TabIndex = 7;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(294, 166);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '•';
            this.tbxPassword.Size = new System.Drawing.Size(100, 23);
            this.tbxPassword.TabIndex = 8;
            // 
            // tbxConPassword
            // 
            this.tbxConPassword.Location = new System.Drawing.Point(294, 211);
            this.tbxConPassword.Name = "tbxConPassword";
            this.tbxConPassword.PasswordChar = '•';
            this.tbxConPassword.Size = new System.Drawing.Size(100, 23);
            this.tbxConPassword.TabIndex = 9;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(120, 267);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(30, 15);
            this.lblHint.TabIndex = 10;
            this.lblHint.Text = "Hint";
            // 
            // tbxHint
            // 
            this.tbxHint.Location = new System.Drawing.Point(294, 259);
            this.tbxHint.Name = "tbxHint";
            this.tbxHint.Size = new System.Drawing.Size(100, 23);
            this.tbxHint.TabIndex = 11;
            // 
            // lblChosenAvatar
            // 
            this.lblChosenAvatar.AutoSize = true;
            this.lblChosenAvatar.Location = new System.Drawing.Point(548, 320);
            this.lblChosenAvatar.Name = "lblChosenAvatar";
            this.lblChosenAvatar.Size = new System.Drawing.Size(87, 15);
            this.lblChosenAvatar.TabIndex = 12;
            this.lblChosenAvatar.Text = "Chosen Avatar:";
            // 
            // pbxAvatar1
            // 
            this.pbxAvatar1.Image = ((System.Drawing.Image)(resources.GetObject("pbxAvatar1.Image")));
            this.pbxAvatar1.Location = new System.Drawing.Point(487, 123);
            this.pbxAvatar1.Name = "pbxAvatar1";
            this.pbxAvatar1.Size = new System.Drawing.Size(45, 45);
            this.pbxAvatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar1.TabIndex = 13;
            this.pbxAvatar1.TabStop = false;
            this.pbxAvatar1.Click += new System.EventHandler(this.pbxAvatar1_Click);
            // 
            // pbxCurrentAvatar
            // 
            this.pbxCurrentAvatar.Location = new System.Drawing.Point(565, 353);
            this.pbxCurrentAvatar.Name = "pbxCurrentAvatar";
            this.pbxCurrentAvatar.Size = new System.Drawing.Size(45, 45);
            this.pbxCurrentAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCurrentAvatar.TabIndex = 14;
            this.pbxCurrentAvatar.TabStop = false;
            // 
            // pbxAvatar5
            // 
            this.pbxAvatar5.Image = ((System.Drawing.Image)(resources.GetObject("pbxAvatar5.Image")));
            this.pbxAvatar5.Location = new System.Drawing.Point(565, 189);
            this.pbxAvatar5.Name = "pbxAvatar5";
            this.pbxAvatar5.Size = new System.Drawing.Size(45, 45);
            this.pbxAvatar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar5.TabIndex = 15;
            this.pbxAvatar5.TabStop = false;
            this.pbxAvatar5.Click += new System.EventHandler(this.pbxAvatar5_Click);
            // 
            // pbxAvatar6
            // 
            this.pbxAvatar6.Image = ((System.Drawing.Image)(resources.GetObject("pbxAvatar6.Image")));
            this.pbxAvatar6.Location = new System.Drawing.Point(642, 189);
            this.pbxAvatar6.Name = "pbxAvatar6";
            this.pbxAvatar6.Size = new System.Drawing.Size(45, 45);
            this.pbxAvatar6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar6.TabIndex = 16;
            this.pbxAvatar6.TabStop = false;
            this.pbxAvatar6.Click += new System.EventHandler(this.pbxAvatar6_Click);
            // 
            // pbxAvatar3
            // 
            this.pbxAvatar3.Image = ((System.Drawing.Image)(resources.GetObject("pbxAvatar3.Image")));
            this.pbxAvatar3.Location = new System.Drawing.Point(642, 123);
            this.pbxAvatar3.Name = "pbxAvatar3";
            this.pbxAvatar3.Size = new System.Drawing.Size(45, 45);
            this.pbxAvatar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar3.TabIndex = 17;
            this.pbxAvatar3.TabStop = false;
            this.pbxAvatar3.Click += new System.EventHandler(this.pbxAvatar3_Click);
            // 
            // pbxAvatar4
            // 
            this.pbxAvatar4.Image = ((System.Drawing.Image)(resources.GetObject("pbxAvatar4.Image")));
            this.pbxAvatar4.Location = new System.Drawing.Point(487, 189);
            this.pbxAvatar4.Name = "pbxAvatar4";
            this.pbxAvatar4.Size = new System.Drawing.Size(45, 45);
            this.pbxAvatar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar4.TabIndex = 18;
            this.pbxAvatar4.TabStop = false;
            this.pbxAvatar4.Click += new System.EventHandler(this.pbxAvatar4_Click);
            // 
            // pbxAvatar2
            // 
            this.pbxAvatar2.Image = ((System.Drawing.Image)(resources.GetObject("pbxAvatar2.Image")));
            this.pbxAvatar2.Location = new System.Drawing.Point(565, 123);
            this.pbxAvatar2.Name = "pbxAvatar2";
            this.pbxAvatar2.Size = new System.Drawing.Size(45, 45);
            this.pbxAvatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar2.TabIndex = 19;
            this.pbxAvatar2.TabStop = false;
            this.pbxAvatar2.Click += new System.EventHandler(this.pbxAvatar2_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(686, 375);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlReg
            // 
            this.pnlReg.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlReg.Controls.Add(this.lblTitle);
            this.pnlReg.Location = new System.Drawing.Point(0, 9);
            this.pnlReg.Name = "pnlReg";
            this.pnlReg.Size = new System.Drawing.Size(800, 80);
            this.pnlReg.TabIndex = 21;
            // 
            // menuStripRegister
            // 
            this.menuStripRegister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStripRegister.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripRegister.Location = new System.Drawing.Point(0, 0);
            this.menuStripRegister.Name = "menuStripRegister";
            this.menuStripRegister.Size = new System.Drawing.Size(800, 24);
            this.menuStripRegister.TabIndex = 22;
            this.menuStripRegister.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.quitToolStripMenuItem.Text = "About";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pbxAvatar2);
            this.Controls.Add(this.pbxAvatar4);
            this.Controls.Add(this.pbxAvatar3);
            this.Controls.Add(this.pbxAvatar6);
            this.Controls.Add(this.pbxAvatar5);
            this.Controls.Add(this.pbxCurrentAvatar);
            this.Controls.Add(this.pbxAvatar1);
            this.Controls.Add(this.lblChosenAvatar);
            this.Controls.Add(this.tbxHint);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.tbxConPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblAlreadyReg);
            this.Controls.Add(this.lblAvatar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblConPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.menuStripRegister);
            this.Controls.Add(this.pnlReg);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar2)).EndInit();
            this.pnlReg.ResumeLayout(false);
            this.pnlReg.PerformLayout();
            this.menuStripRegister.ResumeLayout(false);
            this.menuStripRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConPassword;
        private System.Windows.Forms.LinkLabel lblLogin;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblAlreadyReg;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxConPassword;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.TextBox tbxHint;
        private System.Windows.Forms.Label lblChosenAvatar;
        private System.Windows.Forms.PictureBox pbxAvatar1;
        private System.Windows.Forms.PictureBox pbxCurrentAvatar;
        private System.Windows.Forms.PictureBox pbxAvatar5;
        private System.Windows.Forms.PictureBox pbxAvatar6;
        private System.Windows.Forms.PictureBox pbxAvatar3;
        private System.Windows.Forms.PictureBox pbxAvatar4;
        private System.Windows.Forms.PictureBox pbxAvatar2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlReg;
        private System.Windows.Forms.MenuStrip menuStripRegister;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}