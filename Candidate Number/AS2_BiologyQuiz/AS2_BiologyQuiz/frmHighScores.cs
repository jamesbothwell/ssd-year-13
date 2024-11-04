using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2_BiologyQuiz
{
    public partial class frmHighScores : Form
    {
        Player player;
        List<Player> players = new List<Player>();

        public frmHighScores()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //bring user back to frmMenu
            WriteToFile(players);
            this.Close();
            Form frmMenu = new frmMenu(player);
            frmMenu.Show();
            
        }
        public frmHighScores(Player playerobj)
        {
            InitializeComponent();
            player = playerobj;

            //assign username and avatar at top

            lblPlayer.Text = string.Format(player.Username);

            if (player.Avatar == "images/avatar1.png")
                pbxPlayer.ImageLocation = "images/avatar1.png";
            else if (player.Avatar == "images/avatar2.png")
                pbxPlayer.ImageLocation = "images/avatar2.png";
            else if (player.Avatar == "images/avatar3.png")
                pbxPlayer.ImageLocation = "images/avatar3.png";
            else if (player.Avatar == "images/avatar4.png")
                pbxPlayer.ImageLocation = "images/avatar4.png";
            else if (player.Avatar == "images/avatar5.png")
                pbxPlayer.ImageLocation = "images/avatar5.png";
            else if (player.Avatar == "images/avatar6.png")
                pbxPlayer.ImageLocation = "images/avatar6.png";
        }

        private void frmHighScores_Load(object sender, EventArgs e)
        {
            //display individual question scores and final score
            lblScore.Text = player.Score.ToString();
            lblQ1Score.Text = player.Q1Score.ToString();
            lblQ2Score.Text = player.Q2Score.ToString();
            lblQ3Score.Text = player.Q3Score.ToString();
            lblQ4Score.Text = player.Q4Score.ToString();
            lblQ5Score.Text = player.Q5Score.ToString();

            //read from playerObjects file if it exists

            if (File.Exists("PlayerObjects.bin"))
            {
                ReadFromFile(players);
            }

            //assign grades dependant on score and give relevant feedback
            if (Convert.ToInt32(lblScore.Text) >= 25)
            {
                lblGrade.Text = "A*";
                lblGradeFeedback.Text = "Excellent work! You have clearly revised the subject well";
            }
            if (Convert.ToInt32(lblScore.Text) < 25)
            {
                lblGrade.Text = "A";
                lblGradeFeedback.Text = "Great work! You have shown good revision for the subject";
            }
            if (Convert.ToInt32(lblScore.Text) < 20)
            {
                lblGrade.Text = "B";
                lblGradeFeedback.Text = "Good work! A bit more revision will get you the A";
            }
            if (Convert.ToInt32(lblScore.Text) < 15)
            {
                lblGrade.Text = "C";
                lblGradeFeedback.Text = "Good attempt, more revision needed however";
            }
            if (Convert.ToInt32(lblScore.Text) < 12)
            {
                lblGrade.Text = "D";
                lblGradeFeedback.Text = "Revision seriously needed";
            }

            //Q1 Feedback
            if (Convert.ToInt32(lblQ1Score.Text) >= 8)
            {
                
                lblFeedbackQ1.Text = "Excellent work! You have a high level of understanding of the course";
            }
            if (Convert.ToInt32(lblQ1Score.Text) < 8)
            {

                lblFeedbackQ1.Text = "Good work! You have a fair understanding of the whole course";
            }
            if (Convert.ToInt32(lblQ1Score.Text) < 5)
            {

                lblFeedbackQ1.Text = "Revision seriously needed - the whole course needs more focus";
            }

            //Q2 Feedback
            if (Convert.ToInt32(lblQ2Score.Text) >= 3)
            {

                lblFeedbackQ2.Text = "Excellent work! You have a high level of understanding of osmosis";
            }
            if (Convert.ToInt32(lblQ2Score.Text) < 3)
            {

                lblFeedbackQ2.Text = "Good work! You have a fair understanding of how osmosis works";
            }
            if (Convert.ToInt32(lblQ2Score.Text) < 2)
            {

                lblFeedbackQ2.Text = "Revision seriously needed - you need to focus more on osmosis";
            }

            //Q3 Feedback
            if (Convert.ToInt32(lblQ3Score.Text) >= 6)
            {

                lblFeedbackQ3.Text = "Excellent work! You have a high level of understanding of cell types";
            }
            if (Convert.ToInt32(lblQ3Score.Text) < 6)
            {

                lblFeedbackQ3.Text = "Good work! You have a fair understanding of cell types";
            }
            if (Convert.ToInt32(lblQ3Score.Text) < 4)
            {

                lblFeedbackQ3.Text = "Revision seriously needed - cell types needs more focus";
            }

            //Q4 Feedback
            if (Convert.ToInt32(lblQ4Score.Text) >= 3)
            {

                lblFeedbackQ4.Text = "Excellent work! You have a high level of understanding of cell structure";
            }
            if (Convert.ToInt32(lblQ4Score.Text) < 3)
            {

                lblFeedbackQ4.Text = "Good work! You have a fair understanding of the cell structure";
            }
            if (Convert.ToInt32(lblQ4Score.Text) < 2)
            {

                lblFeedbackQ4.Text = "Revision seriously needed - cell structure needs more focus";
            }

            //Q5 Feedback
            if (Convert.ToInt32(lblQ5Score.Text) >= 3)
            {

                lblFeedbackQ5.Text = "Excellent work! You have a high level of understanding of mitosis";
            }
            if (Convert.ToInt32(lblQ5Score.Text) < 3)
            {

                lblFeedbackQ5.Text = "Good work! You have a fair understanding of mitosis";
            }
            if (Convert.ToInt32(lblQ5Score.Text) < 2)
            {

                lblFeedbackQ5.Text = "Revision seriously needed - mitosis needs more focus";
            }

            PopulateHighScoresTable(lvwHighScores);
        }
        public void PopulateHighScoresTable(ListView myListView)
        {
            //populate the high scores table with all player's details
            players = ReadFromFile(players);
            players = players.OrderByDescending(p => p.HighestScore).Take(10).ToList();

            myListView.Columns.Add("Username", 100);
            myListView.Columns.Add("Score", 100);
            myListView.View = View.Details;

            foreach (Player listplayer in players)
            {
                ListViewItem item = new ListViewItem();

                //Place a check mark next to the item
                item.Text = listplayer.Username;
                item.SubItems.Add(listplayer.HighestScore.ToString());

                myListView.Items.Add(item);


            }
        }
        public List<Player> ReadFromFile(List<Player> playerlist)
        {
            //initialise stream and binary formatter variables
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();

            //open up PlayerObjects file using stream reader, deserialize the file into a list, close the file
            try
            {
                sr = File.OpenRead("PlayerObjects.bin");
                players = (List<Player>)bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e.Message);
            }
            return playerlist;
        }
        public static void WriteToFile(List<Player> playerlist)
        {
            //initialise stream and binary formatter variables
            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();

            //open up PlayerObjects file using stream reader, serialize the file into a list, close the file
            try
            {
                sw = File.Open("PlayerObjects.bin", FileMode.Create);
                bf.Serialize(sw, playerlist);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open help
            Program.helpNumber = 8;
            
            Form frmHelp = new frmHelp(player);
            frmHelp.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display info about software
            MessageBox.Show("Property of Evergreen Studios 2022");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
