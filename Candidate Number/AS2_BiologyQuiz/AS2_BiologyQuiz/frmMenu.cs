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
    public partial class frmMenu : Form
    {


        private Player player;
        List<Player> players = new List<Player>();
        public frmMenu()
        {
            InitializeComponent();
        } 


        public frmMenu(Player playerobj)
        {
            InitializeComponent();

            //assign username and avatar at top

            player = playerobj;
            lblPlayer.Text = string.Format("Welcome, {0}", player.Username);

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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //logout user
            this.Close();
            Form frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            //reset scores for current player
            player.Score = 0;
            player.Q1Score = 0;
            player.Q2Score = 0;
            player.Q3Score = 0;
            player.Q4Score = 0;
            player.Q5Score = 0;

            //start question1
            this.Close();
            Form frmQuestion1 = new frmQuestion1(player);
            frmQuestion1.Show();
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
        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (File.Exists("PlayerObjects.bin"))
            {
                ReadFromFile(players);
            }

            PopulateHighScoresTable(lvwHighScores);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open help
            Program.helpNumber = 2;
            
            Form frmHelp = new frmHelp(player);
            frmHelp.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display info about software
            MessageBox.Show("Property of Evergreen Studios 2022");
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Program.helpNumber = 2;

            Form frmHelp = new frmHelp(player);
            frmHelp.Show();
        }
    }
}
