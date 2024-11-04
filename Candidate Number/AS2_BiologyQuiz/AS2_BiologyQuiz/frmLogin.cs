using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2_BiologyQuiz
{
    public partial class frmLogin : Form
    {
        List<Player> players = new List<Player>();
        Player PlayerObj = new Player();

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(Player newRegistration)
        {
            InitializeComponent();
            this.PlayerObj = newRegistration;
            tbxUsername.Text = PlayerObj.Username;
            tbxPassword.Text = PlayerObj.Password;

           

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //read in the list of players if the playobjects file exists
            if (File.Exists("PlayerObjects.bin"))
            {
                ReadFromFile(players);
            }

        }

        private void lblregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open the register screen
            this.Close();
            Form frmRegister = new frmRegister();
            frmRegister.Show();
        }

        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //displays hint if user has forgotten password
            int count = 0;

            for (int i = 0; i < players.Count; i++)
            {

                //checks if the player has enetered a valid username
                if (players[i].Username.ToLower() == tbxUsername.Text.ToLower())
                {
                    count++;
                    MessageBox.Show(players[i].Hint);
                }
            }
            if (count == 0)
            {
                //error message if username doesn't exist
                MessageBox.Show("Pleaae enter a valid username");
            }
        }

        

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUsername_Click(object sender, EventArgs e)
        {
            
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < players.Count; i++)
            {

                //checks if the user has entered valid login details
                if (players[i].Username.ToLower() == tbxUsername.Text.ToLower() && players[i].Password == tbxPassword.Text)
                {
                    PlayerObj.Username = players[i].Username;
                    PlayerObj.Password = players[i].Password;
                    PlayerObj.Avatar = players[i].Avatar;
                    PlayerObj.Score = players[i].Score;

                    count++;

                    //bring user to menu
                    MessageBox.Show("Login successful");
                    this.Close();
                    Form frmMenu = new frmMenu(PlayerObj);
                    frmMenu.Show();

                }
            }
            if (count == 0)
            {
                //error message if account cannot be found
                MessageBox.Show("Username or Password is incorrect");
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open help page
            Program.helpNumber = 0;
            Form frmHelp = new frmHelp();
            frmHelp.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display info about software
            MessageBox.Show("Property of Evergreen Studios 2022");
        }
    }
}

