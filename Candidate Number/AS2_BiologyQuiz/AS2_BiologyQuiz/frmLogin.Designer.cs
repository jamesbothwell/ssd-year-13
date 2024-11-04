
namespace AS2_BiologyQuiz
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llbForgotPassword = new System.Windows.Forms.LinkLabel();
            this.llbRegister = new System.Windows.Forms.LinkLabel();
            this.lblNotRegYet = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblCompany = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.menuStripLogin = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.menuStripLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(455, 61);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(112, 47);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(335, 174);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(338, 229);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // tbxUsername
            // 
            this.tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxUsername.Location = new System.Drawing.Point(401, 174);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(212, 16);
            this.tbxUsername.TabIndex = 3;
            this.tbxUsername.Click += new System.EventHandler(this.tbxUsername_Click);
            this.tbxUsername.TextChanged += new System.EventHandler(this.tbxUsername_TextChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Location = new System.Drawing.Point(401, 228);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '•';
            this.tbxPassword.Size = new System.Drawing.Size(212, 16);
            this.tbxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(455, 326);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 38);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // llbForgotPassword
            // 
            this.llbForgotPassword.AutoSize = true;
            this.llbForgotPassword.LinkColor = System.Drawing.Color.DarkOliveGreen;
            this.llbForgotPassword.Location = new System.Drawing.Point(455, 266);
            this.llbForgotPassword.Name = "llbForgotPassword";
            this.llbForgotPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.llbForgotPassword.Size = new System.Drawing.Size(100, 15);
            this.llbForgotPassword.TabIndex = 6;
            this.llbForgotPassword.TabStop = true;
            this.llbForgotPassword.Text = "Forgot Password?";
            this.llbForgotPassword.VisitedLinkColor = System.Drawing.Color.PaleGreen;
            this.llbForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbForgotPassword_LinkClicked);
            // 
            // llbRegister
            // 
            this.llbRegister.AutoSize = true;
            this.llbRegister.LinkColor = System.Drawing.Color.DarkOliveGreen;
            this.llbRegister.Location = new System.Drawing.Point(464, 407);
            this.llbRegister.Name = "llbRegister";
            this.llbRegister.Size = new System.Drawing.Size(89, 15);
            this.llbRegister.TabIndex = 7;
            this.llbRegister.TabStop = true;
            this.llbRegister.Text = "Create Account";
            this.llbRegister.VisitedLinkColor = System.Drawing.Color.PaleGreen;
            this.llbRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblregister_LinkClicked);
            // 
            // lblNotRegYet
            // 
            this.lblNotRegYet.AutoSize = true;
            this.lblNotRegYet.Location = new System.Drawing.Point(455, 376);
            this.lblNotRegYet.Name = "lblNotRegYet";
            this.lblNotRegYet.Size = new System.Drawing.Size(109, 15);
            this.lblNotRegYet.TabIndex = 8;
            this.lblNotRegYet.Text = "Not Registered Yet?";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlLogin.Controls.Add(this.lblCompany);
            this.pnlLogin.Controls.Add(this.pbxLogo);
            this.pnlLogin.Location = new System.Drawing.Point(-8, -10);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(236, 464);
            this.pnlLogin.TabIndex = 9;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompany.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCompany.Location = new System.Drawing.Point(51, 221);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(143, 64);
            this.lblCompany.TabIndex = 11;
            this.lblCompany.Text = " Evergreen \r\nStudios";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(51, 71);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(149, 133);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 10;
            this.pbxLogo.TabStop = false;
            // 
            // menuStripLogin
            // 
            this.menuStripLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStripLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripLogin.Location = new System.Drawing.Point(0, 0);
            this.menuStripLogin.Name = "menuStripLogin";
            this.menuStripLogin.Size = new System.Drawing.Size(800, 24);
            this.menuStripLogin.TabIndex = 29;
            this.menuStripLogin.Text = "menuStrip1";
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
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripLogin);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.lblNotRegYet);
            this.Controls.Add(this.llbRegister);
            this.Controls.Add(this.llbForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.menuStripLogin.ResumeLayout(false);
            this.menuStripLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llbForgotPassword;
        private System.Windows.Forms.LinkLabel llbRegister;
        private System.Windows.Forms.Label lblNotRegYet;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.MenuStrip menuStripLogin;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}