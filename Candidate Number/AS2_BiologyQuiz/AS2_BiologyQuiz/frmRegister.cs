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
    public partial class frmRegister : Form
    {
        List<Player> players = new List<Player>();
        List<string> errors = new List<String>();

        public frmRegister()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open login
            this.Close();
            Form frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            //read from playerObjects file if it exists
            if (File.Exists("PlayerObjects.bin"))
            {
                players = ReadFromFile(players);
            }
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

        public static List<Player> ReadFromFile(List<Player> playerlist)
        {
            //initialise stream and binary formatter variables
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();

            //open up PlayerObjects file using stream reader, deserialize the file into a list, close the file
            try
            {
                sr = File.OpenRead("PlayerObjects.bin");
                playerlist = (List<Player>)bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e.Message);
            }
            return playerlist;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //check if user has selected an avatar
            if (pbxCurrentAvatar.ImageLocation == null)
            {
                MessageBox.Show("You must select an avatar");
            }
            else
            {
                //register new user if all fields met correctly and no errors found
                Player newRegistration = new Player();

                if (players.Count > 0)
                {
                    foreach (Player current in players)
                    {
                        if (current.Username == tbxUsername.Text)
                        {
                            errors.Add("Username already exists");
                        }
                    }
                }

                //check password and confirmed password match
                if (!(tbxPassword.Text == tbxConPassword.Text))
                {
                    errors.Add("Passwords do not match");
                }

                try
                {
                    newRegistration.Username = tbxUsername.Text;
                }
                catch (RegistrationException ex)
                {
                    errors.Add(ex.Message);
                }
                try
                {
                    newRegistration.Password = tbxPassword.Text;
                }
                catch (RegistrationException ex)
                {
                    errors.Add(ex.Message);
                }
                try
                {
                    newRegistration.Avatar = pbxCurrentAvatar.ImageLocation;
                }
                catch (RegistrationException ex)
                {
                    errors.Add(ex.Message);
                }
                try
                {
                    newRegistration.Hint = tbxHint.Text;
                }
                catch (RegistrationException ex)
                {
                    errors.Add(ex.Message);
                }
                if (errors.Count == 0)
                {
                    //change to frmLogin if all succesful
                    players.Add(newRegistration);
                    WriteToFile(players);

                    this.Hide();
                    frmLogin frmLogin = new frmLogin(newRegistration);
                    frmLogin.Show();
                }
                else
                {
                    string errorMessage = string.Join("\n", errors.ToArray());
                    MessageBox.Show(string.Format("Errors Encountered -" + "\n" + errorMessage));
                    tbxConPassword.Clear();
                    tbxPassword.Clear();
                    tbxUsername.Clear();
                    pbxCurrentAvatar.Image = null;
                    errors.Clear();


                }
            }
        }

        private void pbxAvatar1_Click(object sender, EventArgs e)
        {
            //assign selected avatar to pbxCurrentAvatar
            pbxCurrentAvatar.ImageLocation = "images/avatar1.png";
        }

        private void pbxAvatar2_Click(object sender, EventArgs e)
        {
            //assign selected avatar to pbxCurrentAvatar
            pbxCurrentAvatar.ImageLocation = "images/avatar2.png";
        }

        private void pbxAvatar3_Click(object sender, EventArgs e)
        {
            //assign selected avatar to pbxCurrentAvatar
            pbxCurrentAvatar.ImageLocation = "images/avatar3.png";
        }

        private void pbxAvatar4_Click(object sender, EventArgs e)
        {
            //assign selected avatar to pbxCurrentAvatar
            pbxCurrentAvatar.ImageLocation = "images/avatar4.png";
        }

        private void pbxAvatar5_Click(object sender, EventArgs e)
        {
            //assign selected avatar to pbxCurrentAvatar
            pbxCurrentAvatar.ImageLocation = "images/avatar5.png";
        }

        private void pbxAvatar6_Click(object sender, EventArgs e)
        {
            //assign selected avatar to pbxCurrentAvatar
            pbxCurrentAvatar.ImageLocation = "images/avatar6.png";
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open help
            Program.helpNumber = 1;
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
