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
    public partial class frmQuestion5 : Form
    {
        Player player;
        List<Question> mitosis1 = new List<Question>();
        List<Question> mitosis2 = new List<Question>();
        List<Question> mitosis3 = new List<Question>();
        List<Player> players = new List<Player>();
        public frmQuestion5()
        {
            InitializeComponent();
        }

        private void btnFinishQuiz_Click(object sender, EventArgs e)
        {
            //add user to highscores table or update highscores
            players = ReadFromFile(players);
            
            bool updated = false;
            if (player.Score > player.HighestScore)
            {
                player.HighestScore = player.Score;
            }
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    if (players[i].Username == player.Username)
                    {
                        players[i] = player;
                        updated = true;
                    }
                }
                if (updated == false)
                {
                    players.Add(player);
                }
            }


            //change to frmHighScores
            WriteToFile(players);
            this.Close();
            Form frmHighScores = new frmHighScores(player);
            frmHighScores.Show();
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
        private void frmQuestion5_Load(object sender, EventArgs e)
        {
            //disable question 2 and 3
            pnlQ2.Enabled = false;
            pnlQ3.Enabled = false;
            btnFinishQuiz.Enabled = false;
            lblScore.Text = player.Score.ToString();

            if (File.Exists("PlayerObjects.bin"))
            {
                ReadFromFile(players);
            }

            try
            {
                string line;
                //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                string filepath = @"mitosis.txt";
                
                int counter = 0;

                using (StreamReader sr = new StreamReader(filepath))
                {
                    // Read lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] itemString = line.Split(',');
                        Question Question = new Question();

                        if (counter >= 0 && counter < 5)
                        {
                            //create answers for q1
                            Question.QuestionText1 = itemString[0];
                            Question.CorrectAnswer1 = itemString[1];
                            mitosis1.Add(Question);

                        }
                        else if (counter >= 5 && counter < 10)
                        {
                            //create answers for q2
                            Question.QuestionText1 = itemString[0];
                            Question.CorrectAnswer1 = itemString[1];
                            mitosis2.Add(Question);
                        }
                        else if (counter >= 10)
                        {
                            //create answers for q3
                            Question.QuestionText1 = itemString[0];
                            Question.CorrectAnswer1 = itemString[1];
                            mitosis3.Add(Question);
                        }
                        counter++;

                    }
                }

                Question NewQuestion = new Question();

                pbxMitosis.ImageLocation = "images/prophase.jpg";

                RandomizeQuestions(mitosis1);
                RandomizeQuestions(mitosis2);
                RandomizeQuestions(mitosis3);

                lblQ1.Text = mitosis1[0].QuestionText1;
                lblQ2.Text = mitosis2[0].QuestionText1;
                lblQ3.Text = mitosis3[0].QuestionText1;
            }
            catch (Exception z)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(z.Message);
            }
        }
        public static void RandomizeQuestions<T>(IList<T> list)
        {
            Random r = new Random();

            //For each question in the list swap with a random one in the list
            for (int i = 0; i < list.Count - 1; i++)
            {
                int j = r.Next(i, list.Count);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
        public frmQuestion5(Player playerobj)
        {
            InitializeComponent();
            player = playerobj;

            lblPlayer.Text = string.Format(player.Username);

            //assign username and avatar at top

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

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            //check answer and change pbxMitosis if correct to next stage in mitosis
            if (cbxQ1.SelectedIndex.ToString() == mitosis1[0].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q5Score += 1;
                MessageBox.Show("Correct!");
                pnlQ1.Enabled = false;
                pnlQ2.Enabled = true;
                //check stages of mitosis
                if (pbxMitosis.ImageLocation.ToString() == "images/prophase.jpg")
                {
                    pbxMitosis.ImageLocation = "images/metaphase.jpg";
                    pbxMitosis.Refresh();
                }
                else if (pbxMitosis.ImageLocation.ToString() == "images/metaphase.jpg")
                {
                    pbxMitosis.ImageLocation = "images/anaphase.jpg";
                }
                else if (pbxMitosis.ImageLocation.ToString() == "images/anaphase.jpg")
                {
                    pbxMitosis.ImageLocation = "images/telophase.jpg";
                }
            }
            else
            {
                MessageBox.Show("Incorrect!");
                pnlQ1.Enabled = false;
                pnlQ2.Enabled = true;
            }
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            //check answer and change pbxMitosis if correct to next stage in mitosis
            if (tbxQ2.Text.ToLower() == mitosis2[0].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q5Score += 1;
                MessageBox.Show("Correct!");
                pnlQ2.Enabled = false;
                pnlQ3.Enabled = true;
                //check stages of mitosis
                if (pbxMitosis.ImageLocation.ToString() == "images/prophase.jpg")
                {
                    pbxMitosis.ImageLocation = "images/metaphase.jpg";
                    pbxMitosis.Refresh();
                }
                else if (pbxMitosis.ImageLocation.ToString() == "images/metaphase.jpg")
                {
                    pbxMitosis.ImageLocation = "images/anaphase.jpg";
                }
                else if (pbxMitosis.ImageLocation.ToString() == "images/anaphase.jpg")
                {
                    pbxMitosis.ImageLocation = "images/telophase.jpg";
                }
            }
            else
            {
                MessageBox.Show("Incorrect!");
                pnlQ2.Enabled = false;
                pnlQ3.Enabled = true;
            }
        }

        private void btnSubmit3_Click(object sender, EventArgs e)
        {
            //check answer and change pbxMitosis if correct to next stage in mitosis
            if (cbxQ3.SelectedIndex.ToString() == mitosis3[0].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q5Score += 1;
                MessageBox.Show("Correct!");
                pnlQ3.Enabled = false;
                btnFinishQuiz.Enabled = true;
                //check stages of mitosis
                if (pbxMitosis.ImageLocation.ToString() == "images/prophase.jpg")
                {
                    pbxMitosis.ImageLocation = "images/metaphase.jpg";
                    
                }
                else if (pbxMitosis.ImageLocation.ToString() == "images/metaphase.jpg")
                {
                    pbxMitosis.ImageLocation = "images/anaphase.jpg";
                }
                else if (pbxMitosis.ImageLocation.ToString() == "images/anaphase.jpg")
                {
                    pbxMitosis.ImageLocation = "images/telophase.jpg";
                }
            }
            else
            {
                MessageBox.Show("Incorrect!");
                pnlQ3.Enabled = false;
                btnFinishQuiz.Enabled = true;
            }
            MessageBox.Show("Quiz Completed!");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open help
            Program.helpNumber = 7;
            Form frmHelp = new frmHelp(player);
            frmHelp.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display info about software
            MessageBox.Show("Property of Evergreen Studios 2022");
        }
    }
}
