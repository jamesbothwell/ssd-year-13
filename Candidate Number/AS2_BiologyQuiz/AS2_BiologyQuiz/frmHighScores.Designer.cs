
namespace AS2_BiologyQuiz
{
    partial class frmHighScores
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
            this.pbxPlayer = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblHS = new System.Windows.Forms.Label();
            this.lblHighScores = new System.Windows.Forms.Label();
            this.lvwHighScores = new System.Windows.Forms.ListView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblTOF = new System.Windows.Forms.Label();
            this.lblOsmosis = new System.Windows.Forms.Label();
            this.lblEuVsPro = new System.Windows.Forms.Label();
            this.lblCells = new System.Windows.Forms.Label();
            this.lblMitosis = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQ1Score = new System.Windows.Forms.Label();
            this.lblQ3Score = new System.Windows.Forms.Label();
            this.lblQ2Score = new System.Windows.Forms.Label();
            this.lblQ4Score = new System.Windows.Forms.Label();
            this.lblQ5Score = new System.Windows.Forms.Label();
            this.lblTotScore = new System.Windows.Forms.Label();
            this.lblQ1Total = new System.Windows.Forms.Label();
            this.lblQ2Total = new System.Windows.Forms.Label();
            this.lblQ3Total = new System.Windows.Forms.Label();
            this.lblQ4Total = new System.Windows.Forms.Label();
            this.lblQ5Total = new System.Windows.Forms.Label();
            this.lblWhatGrade = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblGradeFeedback = new System.Windows.Forms.Label();
            this.menuStripHighScores = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFeedbackQ5 = new System.Windows.Forms.Label();
            this.lblFeedbackQ3 = new System.Windows.Forms.Label();
            this.lblFeedbackQ4 = new System.Windows.Forms.Label();
            this.lblFeedbackQ2 = new System.Windows.Forms.Label();
            this.lblFeedbackQ1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.menuStripHighScores.SuspendLayout();
            this.SuspendLayout();
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
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlMenu.Controls.Add(this.pbxPlayer);
            this.pnlMenu.Controls.Add(this.lblPlayer);
            this.pnlMenu.Controls.Add(this.lblHS);
            this.pnlMenu.Location = new System.Drawing.Point(0, 23);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(817, 71);
            this.pnlMenu.TabIndex = 12;
            // 
            // lblHS
            // 
            this.lblHS.AutoSize = true;
            this.lblHS.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHS.Location = new System.Drawing.Point(298, 9);
            this.lblHS.Name = "lblHS";
            this.lblHS.Size = new System.Drawing.Size(216, 47);
            this.lblHS.TabIndex = 0;
            this.lblHS.Text = "High Scores";
            // 
            // lblHighScores
            // 
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighScores.Location = new System.Drawing.Point(570, 105);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(100, 21);
            this.lblHighScores.TabIndex = 11;
            this.lblHighScores.Text = "High Scores";
            // 
            // lvwHighScores
            // 
            this.lvwHighScores.HideSelection = false;
            this.lvwHighScores.Location = new System.Drawing.Point(463, 129);
            this.lvwHighScores.Name = "lvwHighScores";
            this.lvwHighScores.Size = new System.Drawing.Size(308, 240);
            this.lvwHighScores.TabIndex = 10;
            this.lvwHighScores.UseCompatibleStateImageBehavior = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenu.Location = new System.Drawing.Point(713, 384);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 54);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Return To Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFeedback.Location = new System.Drawing.Point(169, 105);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(82, 21);
            this.lblFeedback.TabIndex = 13;
            this.lblFeedback.Text = "Feedback";
            // 
            // lblTOF
            // 
            this.lblTOF.AutoSize = true;
            this.lblTOF.Location = new System.Drawing.Point(31, 130);
            this.lblTOF.Name = "lblTOF";
            this.lblTOF.Size = new System.Drawing.Size(106, 15);
            this.lblTOF.TabIndex = 14;
            this.lblTOF.Text = "Q1. True Or False - ";
            // 
            // lblOsmosis
            // 
            this.lblOsmosis.AutoSize = true;
            this.lblOsmosis.Location = new System.Drawing.Point(31, 177);
            this.lblOsmosis.Name = "lblOsmosis";
            this.lblOsmosis.Size = new System.Drawing.Size(84, 15);
            this.lblOsmosis.TabIndex = 15;
            this.lblOsmosis.Text = "Q2. Osmosis - ";
            // 
            // lblEuVsPro
            // 
            this.lblEuVsPro.AutoSize = true;
            this.lblEuVsPro.Location = new System.Drawing.Point(31, 226);
            this.lblEuVsPro.Name = "lblEuVsPro";
            this.lblEuVsPro.Size = new System.Drawing.Size(172, 15);
            this.lblEuVsPro.TabIndex = 16;
            this.lblEuVsPro.Text = "Q3. Eukaryotic Vs Prokaryotic - ";
            // 
            // lblCells
            // 
            this.lblCells.AutoSize = true;
            this.lblCells.Location = new System.Drawing.Point(31, 272);
            this.lblCells.Name = "lblCells";
            this.lblCells.Size = new System.Drawing.Size(64, 15);
            this.lblCells.TabIndex = 17;
            this.lblCells.Text = "Q4. Cells - ";
            // 
            // lblMitosis
            // 
            this.lblMitosis.AutoSize = true;
            this.lblMitosis.Location = new System.Drawing.Point(31, 320);
            this.lblMitosis.Name = "lblMitosis";
            this.lblMitosis.Size = new System.Drawing.Size(77, 15);
            this.lblMitosis.TabIndex = 18;
            this.lblMitosis.Text = "Q5. Mitosis - ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(270, 363);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(25, 30);
            this.lblScore.TabIndex = 19;
            this.lblScore.Text = "1";
            // 
            // lblQ1Score
            // 
            this.lblQ1Score.AutoSize = true;
            this.lblQ1Score.Location = new System.Drawing.Point(146, 130);
            this.lblQ1Score.Name = "lblQ1Score";
            this.lblQ1Score.Size = new System.Drawing.Size(13, 15);
            this.lblQ1Score.TabIndex = 20;
            this.lblQ1Score.Text = "1";
            this.lblQ1Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQ3Score
            // 
            this.lblQ3Score.AutoSize = true;
            this.lblQ3Score.Location = new System.Drawing.Point(209, 226);
            this.lblQ3Score.Name = "lblQ3Score";
            this.lblQ3Score.Size = new System.Drawing.Size(13, 15);
            this.lblQ3Score.TabIndex = 21;
            this.lblQ3Score.Text = "1";
            // 
            // lblQ2Score
            // 
            this.lblQ2Score.AutoSize = true;
            this.lblQ2Score.Location = new System.Drawing.Point(121, 177);
            this.lblQ2Score.Name = "lblQ2Score";
            this.lblQ2Score.Size = new System.Drawing.Size(13, 15);
            this.lblQ2Score.TabIndex = 22;
            this.lblQ2Score.Text = "1";
            // 
            // lblQ4Score
            // 
            this.lblQ4Score.AutoSize = true;
            this.lblQ4Score.Location = new System.Drawing.Point(101, 272);
            this.lblQ4Score.Name = "lblQ4Score";
            this.lblQ4Score.Size = new System.Drawing.Size(13, 15);
            this.lblQ4Score.TabIndex = 23;
            this.lblQ4Score.Text = "1";
            // 
            // lblQ5Score
            // 
            this.lblQ5Score.AutoSize = true;
            this.lblQ5Score.Location = new System.Drawing.Point(114, 320);
            this.lblQ5Score.Name = "lblQ5Score";
            this.lblQ5Score.Size = new System.Drawing.Size(13, 15);
            this.lblQ5Score.TabIndex = 24;
            this.lblQ5Score.Text = "1";
            // 
            // lblTotScore
            // 
            this.lblTotScore.AutoSize = true;
            this.lblTotScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotScore.Location = new System.Drawing.Point(138, 363);
            this.lblTotScore.Name = "lblTotScore";
            this.lblTotScore.Size = new System.Drawing.Size(127, 30);
            this.lblTotScore.TabIndex = 25;
            this.lblTotScore.Text = "Total Score:";
            // 
            // lblQ1Total
            // 
            this.lblQ1Total.AutoSize = true;
            this.lblQ1Total.Location = new System.Drawing.Point(162, 130);
            this.lblQ1Total.Name = "lblQ1Total";
            this.lblQ1Total.Size = new System.Drawing.Size(27, 15);
            this.lblQ1Total.TabIndex = 26;
            this.lblQ1Total.Text = "/ 10";
            // 
            // lblQ2Total
            // 
            this.lblQ2Total.AutoSize = true;
            this.lblQ2Total.Location = new System.Drawing.Point(138, 177);
            this.lblQ2Total.Name = "lblQ2Total";
            this.lblQ2Total.Size = new System.Drawing.Size(21, 15);
            this.lblQ2Total.TabIndex = 27;
            this.lblQ2Total.Text = "/ 3";
            // 
            // lblQ3Total
            // 
            this.lblQ3Total.AutoSize = true;
            this.lblQ3Total.Location = new System.Drawing.Point(221, 226);
            this.lblQ3Total.Name = "lblQ3Total";
            this.lblQ3Total.Size = new System.Drawing.Size(21, 15);
            this.lblQ3Total.TabIndex = 28;
            this.lblQ3Total.Text = "/ 8";
            // 
            // lblQ4Total
            // 
            this.lblQ4Total.AutoSize = true;
            this.lblQ4Total.Location = new System.Drawing.Point(120, 272);
            this.lblQ4Total.Name = "lblQ4Total";
            this.lblQ4Total.Size = new System.Drawing.Size(21, 15);
            this.lblQ4Total.TabIndex = 29;
            this.lblQ4Total.Text = "/ 3";
            // 
            // lblQ5Total
            // 
            this.lblQ5Total.AutoSize = true;
            this.lblQ5Total.Location = new System.Drawing.Point(129, 320);
            this.lblQ5Total.Name = "lblQ5Total";
            this.lblQ5Total.Size = new System.Drawing.Size(21, 15);
            this.lblQ5Total.TabIndex = 30;
            this.lblQ5Total.Text = "/ 3";
            // 
            // lblWhatGrade
            // 
            this.lblWhatGrade.AutoSize = true;
            this.lblWhatGrade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWhatGrade.Location = new System.Drawing.Point(165, 393);
            this.lblWhatGrade.Name = "lblWhatGrade";
            this.lblWhatGrade.Size = new System.Drawing.Size(71, 25);
            this.lblWhatGrade.TabIndex = 32;
            this.lblWhatGrade.Text = "Grade:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrade.Location = new System.Drawing.Point(242, 393);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(25, 25);
            this.lblGrade.TabIndex = 31;
            this.lblGrade.Text = "A";
            // 
            // lblGradeFeedback
            // 
            this.lblGradeFeedback.AutoSize = true;
            this.lblGradeFeedback.Location = new System.Drawing.Point(58, 423);
            this.lblGradeFeedback.Name = "lblGradeFeedback";
            this.lblGradeFeedback.Size = new System.Drawing.Size(57, 15);
            this.lblGradeFeedback.TabIndex = 33;
            this.lblGradeFeedback.Text = "Feedback";
            // 
            // menuStripHighScores
            // 
            this.menuStripHighScores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStripHighScores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripHighScores.Location = new System.Drawing.Point(0, 0);
            this.menuStripHighScores.Name = "menuStripHighScores";
            this.menuStripHighScores.Size = new System.Drawing.Size(800, 24);
            this.menuStripHighScores.TabIndex = 34;
            this.menuStripHighScores.Text = "menuStrip1";
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
            // lblFeedbackQ5
            // 
            this.lblFeedbackQ5.AutoSize = true;
            this.lblFeedbackQ5.Location = new System.Drawing.Point(58, 340);
            this.lblFeedbackQ5.Name = "lblFeedbackQ5";
            this.lblFeedbackQ5.Size = new System.Drawing.Size(57, 15);
            this.lblFeedbackQ5.TabIndex = 35;
            this.lblFeedbackQ5.Text = "Feedback";
            // 
            // lblFeedbackQ3
            // 
            this.lblFeedbackQ3.AutoSize = true;
            this.lblFeedbackQ3.Location = new System.Drawing.Point(57, 252);
            this.lblFeedbackQ3.Name = "lblFeedbackQ3";
            this.lblFeedbackQ3.Size = new System.Drawing.Size(57, 15);
            this.lblFeedbackQ3.TabIndex = 36;
            this.lblFeedbackQ3.Text = "Feedback";
            // 
            // lblFeedbackQ4
            // 
            this.lblFeedbackQ4.AutoSize = true;
            this.lblFeedbackQ4.Location = new System.Drawing.Point(59, 296);
            this.lblFeedbackQ4.Name = "lblFeedbackQ4";
            this.lblFeedbackQ4.Size = new System.Drawing.Size(57, 15);
            this.lblFeedbackQ4.TabIndex = 37;
            this.lblFeedbackQ4.Text = "Feedback";
            // 
            // lblFeedbackQ2
            // 
            this.lblFeedbackQ2.AutoSize = true;
            this.lblFeedbackQ2.Location = new System.Drawing.Point(57, 202);
            this.lblFeedbackQ2.Name = "lblFeedbackQ2";
            this.lblFeedbackQ2.Size = new System.Drawing.Size(57, 15);
            this.lblFeedbackQ2.TabIndex = 38;
            this.lblFeedbackQ2.Text = "Feedback";
            // 
            // lblFeedbackQ1
            // 
            this.lblFeedbackQ1.AutoSize = true;
            this.lblFeedbackQ1.Location = new System.Drawing.Point(58, 156);
            this.lblFeedbackQ1.Name = "lblFeedbackQ1";
            this.lblFeedbackQ1.Size = new System.Drawing.Size(57, 15);
            this.lblFeedbackQ1.TabIndex = 39;
            this.lblFeedbackQ1.Text = "Feedback";
            // 
            // frmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFeedbackQ1);
            this.Controls.Add(this.lblFeedbackQ2);
            this.Controls.Add(this.lblFeedbackQ4);
            this.Controls.Add(this.lblFeedbackQ3);
            this.Controls.Add(this.lblFeedbackQ5);
            this.Controls.Add(this.menuStripHighScores);
            this.Controls.Add(this.lblGradeFeedback);
            this.Controls.Add(this.lblWhatGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblQ5Total);
            this.Controls.Add(this.lblQ4Total);
            this.Controls.Add(this.lblQ3Total);
            this.Controls.Add(this.lblQ2Total);
            this.Controls.Add(this.lblQ1Total);
            this.Controls.Add(this.lblTotScore);
            this.Controls.Add(this.lblQ5Score);
            this.Controls.Add(this.lblQ4Score);
            this.Controls.Add(this.lblQ2Score);
            this.Controls.Add(this.lblQ3Score);
            this.Controls.Add(this.lblQ1Score);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblMitosis);
            this.Controls.Add(this.lblCells);
            this.Controls.Add(this.lblEuVsPro);
            this.Controls.Add(this.lblOsmosis);
            this.Controls.Add(this.lblTOF);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblHighScores);
            this.Controls.Add(this.lvwHighScores);
            this.Controls.Add(this.btnMenu);
            this.Name = "frmHighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHighScores";
            this.Load += new System.EventHandler(this.frmHighScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.menuStripHighScores.ResumeLayout(false);
            this.menuStripHighScores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblHS;
        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.ListView lvwHighScores;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblTOF;
        private System.Windows.Forms.Label lblOsmosis;
        private System.Windows.Forms.Label lblEuVsPro;
        private System.Windows.Forms.Label lblCells;
        private System.Windows.Forms.Label lblMitosis;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQ1Score;
        private System.Windows.Forms.Label lblQ3Score;
        private System.Windows.Forms.Label lblQ2Score;
        private System.Windows.Forms.Label lblQ4Score;
        private System.Windows.Forms.Label lblQ5Score;
        private System.Windows.Forms.Label lblTotScore;
        private System.Windows.Forms.Label lblQ1Total;
        private System.Windows.Forms.Label lblQ2Total;
        private System.Windows.Forms.Label lblQ3Total;
        private System.Windows.Forms.Label lblQ4Total;
        private System.Windows.Forms.Label lblQ5Total;
        private System.Windows.Forms.Label lblWhatGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblGradeFeedback;
        private System.Windows.Forms.MenuStrip menuStripHighScores;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblFeedbackQ5;
        private System.Windows.Forms.Label lblFeedbackQ3;
        private System.Windows.Forms.Label lblFeedbackQ4;
        private System.Windows.Forms.Label lblFeedbackQ2;
        private System.Windows.Forms.Label lblFeedbackQ1;
    }
}