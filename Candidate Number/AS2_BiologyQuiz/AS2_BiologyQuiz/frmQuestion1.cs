using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2_BiologyQuiz
{
    public partial class frmQuestion1 : Form
    {
        Player player;
        List<Question> listItems = new List<Question>();
        int questionsAnswered;
        int tickNum = 0;
        public frmQuestion1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ5False.Text == listItems[4].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ5True.Enabled = false;
            btnQ5False.Enabled = false;
            btnQ5True.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ5True.Text == listItems[4].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ5True.Enabled = false;
            btnQ5False.Enabled = false;
            btnQ5False.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            
        }

        private void frmQuestion1_Load(object sender, EventArgs e)
        {
            //start timer and progress bar
            lblScore.Text = player.Score.ToString();
            btnResumeTimer.Hide();
            timerQuestion1.Start();
            progressBarQ1.Maximum = 60;
            progressBarQ1.Style = ProgressBarStyle.Blocks;
            progressBarQ1.MarqueeAnimationSpeed = 50;

            try
            {

                string line;
                //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                string filepath = @"trueorfalse.txt";
                using (StreamReader sr = new StreamReader(filepath))
                {
                    // Read lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] itemString = line.Split(',');
                        
                        Question NewQuestion = new Question();
                        NewQuestion.QuestionText1 = itemString[0];
                        NewQuestion.CorrectAnswer1 = itemString[1];

                        //Answer all Questions and Answers to a list
                        listItems.Add(NewQuestion);                   
                    }
                }
                //randomise question order
                RandomizeQuestions(listItems);

                //populate questions 1-10
                askQuestions();

                
                
                
                
                

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
        public frmQuestion1(Player playerobj)
        {
            //assign username and avatar at top
            InitializeComponent();
            player = playerobj;

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

            if (questionsAnswered == 10)
            {
                MessageBox.Show("All Questions Completed - Please Continue To Next Question");
                
            }
        }
        private void askQuestions()
        {
            if (questionsAnswered == 10)
            {
                MessageBox.Show("All Questions Completed - Please Continue To Next Question");
                
            }


            //assign a question to the question labels
            lblQ1.Text = listItems[0].QuestionText1;
            lblQ2.Text = listItems[1].QuestionText1;
            lblQ3.Text = listItems[2].QuestionText1;
            lblQ4.Text = listItems[3].QuestionText1;
            lblQ5.Text = listItems[4].QuestionText1;
            lblQ6.Text = listItems[5].QuestionText1;
            lblQ7.Text = listItems[6].QuestionText1;
            lblQ8.Text = listItems[7].QuestionText1;
            lblQ9.Text = listItems[8].QuestionText1;
            lblQ10.Text = listItems[9].QuestionText1;

        }

        private void btnQ1True_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ1True.Text == listItems[0].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ1True.Enabled = false;
            btnQ1False.Enabled = false;
            btnQ1False.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ1False_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ1False.Text == listItems[0].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ1True.Enabled = false;
            btnQ1False.Enabled = false;
            btnQ1True.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ2True_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ2True.Text == listItems[1].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ2True.Enabled = false;
            btnQ2False.Enabled = false;
            btnQ2False.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ3True_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ3True.Text == listItems[2].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ3True.Enabled = false;
            btnQ3False.Enabled = false;
            btnQ3False.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ4True_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ4True.Text == listItems[3].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ4True.Enabled = false;
            btnQ4False.Enabled = false;
            btnQ4False.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ6True_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ6True.Text == listItems[5].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ6True.Enabled = false;
            btnQ6False.Enabled = false;
            btnQ6False.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ7True_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ7True.Text == listItems[6].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ7True.Enabled = false;
            btnQ7False.Enabled = false;
            btnQ7False.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ8True_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ8True.Text == listItems[7].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ8True.Enabled = false;
            btnQ8False.Enabled = false;
            btnQ8False.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ9True_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ9True.Text == listItems[8].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ9True.Enabled = false;
            btnQ9False.Enabled = false;
            btnQ9False.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ10True_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ10True.Text == listItems[9].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ10True.Enabled = false;
            btnQ10False.Enabled = false;
            btnQ10False.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ2False_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ2False.Text == listItems[1].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ2True.Enabled = false;
            btnQ2False.Enabled = false;
            btnQ2True.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ3False_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ3False.Text == listItems[2].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ3True.Enabled = false;
            btnQ3False.Enabled = false;
            btnQ3True.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ4False_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ4False.Text == listItems[3].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ4True.Enabled = false;
            btnQ4False.Enabled = false;
            btnQ4True.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ6False_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ6False.Text == listItems[5].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ6True.Enabled = false;
            btnQ6False.Enabled = false;
            btnQ6True.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ7False_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ7False.Text == listItems[6].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ7True.Enabled = false;
            btnQ7False.Enabled = false;
            btnQ7True.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ8False_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ8False.Text == listItems[7].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ8True.Enabled = false;
            btnQ8False.Enabled = false;
            btnQ8True.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ9False_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ9False.Text == listItems[8].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ9True.Enabled = false;
            btnQ9False.Enabled = false;
            btnQ9True.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void btnQ10False_Click(object sender, EventArgs e)
        {
            //add to score if correct, disable both buttons for question and change colour of other button to grey
            if (btnQ10False.Text == listItems[9].CorrectAnswer1)
            {
                player.Score += 1;
                player.Q1Score += 1;
            }
            btnQ10True.Enabled = false;
            btnQ10False.Enabled = false;
            btnQ10True.BackColor = Color.Gray;
            questionsAnswered += 1;
        }

        private void timerQuestion1_Tick(object sender, EventArgs e)
        {
            //increase timer until 60 seconds
            tickNum++;
            if (progressBarQ1.Value < 60)
            {
                progressBarQ1.Value++;
                
            }
            if (tickNum >= 60)
            {
                //change to frmQuestion2
                progressBarQ1.Enabled = false;
                Program.timerStop = 2;
                timerQuestion1.Stop();
                MessageBox.Show("Question completed!");
                this.Close();
                Form frmQuestion2 = new FrmQuestion2(player);
                frmQuestion2.Show();
                
            }
            if (questionsAnswered == 10)
            {
                //change to frmQuestion2
                progressBarQ1.Enabled = false;
                timerQuestion1.Stop();
                MessageBox.Show("Question completed!");
                this.Close();
                Form frmQuestion2 = new FrmQuestion2(player);
                frmQuestion2.Show();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open help and disable timer
            Program.helpNumber = 3;
            Program.timerStop = 2;
            timerQuestion1.Stop();
            pnlQuestions.Enabled = false;
            btnResumeTimer.Show();
            Form frmHelp = new frmHelp(player);
            frmHelp.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display info about software
            MessageBox.Show("Property of Evergreen Studios 2022");
        }

        private void btnFinishQuiz_Click(object sender, EventArgs e)
        {
            //restart timer if help has been closed
            if (Program.timerStop == 1)
            {
                timerQuestion1.Start();
                btnResumeTimer.Hide();
                pnlQuestions.Enabled = true;
            }
            else if (Program.timerStop == 2)
            {
                MessageBox.Show("Please close the help menu using the 'Close Help' button first");
            }
        }
    }
}
