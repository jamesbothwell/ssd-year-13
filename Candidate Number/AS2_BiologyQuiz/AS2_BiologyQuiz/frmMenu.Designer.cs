
namespace AS2_BiologyQuiz
{
    partial class frmMenu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnTakeQuiz = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pbxPlayer = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHighScores = new System.Windows.Forms.Label();
            this.lvwHighScores = new System.Windows.Forms.ListView();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            this.menuStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMenu.Location = new System.Drawing.Point(348, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(115, 47);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Location = new System.Drawing.Point(96, 376);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnTakeQuiz
            // 
            this.btnTakeQuiz.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTakeQuiz.FlatAppearance.BorderSize = 0;
            this.btnTakeQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeQuiz.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTakeQuiz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTakeQuiz.Location = new System.Drawing.Point(317, 214);
            this.btnTakeQuiz.Name = "btnTakeQuiz";
            this.btnTakeQuiz.Size = new System.Drawing.Size(179, 60);
            this.btnTakeQuiz.TabIndex = 2;
            this.btnTakeQuiz.Text = "Take Quiz";
            this.btnTakeQuiz.UseVisualStyleBackColor = false;
            this.btnTakeQuiz.Click += new System.EventHandler(this.btnTakeQuiz_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlMenu.Controls.Add(this.pbxPlayer);
            this.pnlMenu.Controls.Add(this.lblPlayer);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Location = new System.Drawing.Point(0, 23);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(817, 71);
            this.pnlMenu.TabIndex = 6;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // pbxPlayer
            // 
            this.pbxPlayer.Location = new System.Drawing.Point(16, 12);
            this.pbxPlayer.Name = "pbxPlayer";
            this.pbxPlayer.Size = new System.Drawing.Size(45, 45);
            this.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlayer.TabIndex = 2;
            this.pbxPlayer.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer.Location = new System.Drawing.Point(68, 21);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(70, 21);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "lblPlayer";
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(800, 24);
            this.menuStripMenu.TabIndex = 23;
            this.menuStripMenu.Text = "menuStrip1";
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
            // lblHighScores
            // 
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighScores.Location = new System.Drawing.Point(605, 108);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(100, 21);
            this.lblHighScores.TabIndex = 25;
            this.lblHighScores.Text = "High Scores";
            // 
            // lvwHighScores
            // 
            this.lvwHighScores.HideSelection = false;
            this.lvwHighScores.Location = new System.Drawing.Point(545, 144);
            this.lvwHighScores.Name = "lvwHighScores";
            this.lvwHighScores.Size = new System.Drawing.Size(224, 268);
            this.lvwHighScores.TabIndex = 24;
            this.lvwHighScores.UseCompatibleStateImageBehavior = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHelp.Location = new System.Drawing.Point(96, 161);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 26;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblHighScores);
            this.Controls.Add(this.lvwHighScores);
            this.Controls.Add(this.menuStripMenu);
            this.Controls.Add(this.btnTakeQuiz);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnTakeQuiz;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox pbxPlayer;
        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.ListView lvwHighScores;
        private System.Windows.Forms.Button btnHelp;
    }
}