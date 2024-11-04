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
    public partial class frmQuestion3 : Form
    {
        Player player;
        int imagesCorrect;
        List<string> proAnsList = new List<string>();
        List<string> euAnsList = new List<string>();
        int count = 0;
        string selected;
        
        public frmQuestion3()
        {
            InitializeComponent();

        }

        private void pbxDesc1_MouseDown(object sender, MouseEventArgs e)
        {
            //drag drop method that prevents picture box being dropped into blank space
            selected = pbxDesc1.ImageLocation.ToString();
            int temp = count;
            pbxDesc1.DoDragDrop(pbxDesc1.Image, DragDropEffects.Copy);
            if (temp != count)
            {
                pbxDesc1.Hide();
            }
            
        }

        private void pbxDesc2_MouseDown(object sender, MouseEventArgs e)
        {
            //drag drop method that prevents picture box being dropped into blank space
            selected = pbxDesc2.ImageLocation.ToString();
            int temp = count;
            pbxDesc2.DoDragDrop(pbxDesc2.Image, DragDropEffects.Copy);
            if (temp != count)
            {
                pbxDesc2.Hide();
            }
            
        }



        private void pbxEuAns1_DragDrop(object sender, DragEventArgs e)
        {
            //add to and change to frmQuestion4 if last picture box to be drag/dropped
            pbxEuAns1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pbxEuAns1.AllowDrop = false;
            if (euAnsList.Contains(selected))
            {
                player.Score += 1;
                player.Q3Score += 1;
            }
            count += 1;
            if (count == 8)
            {
                CalculateScore();
            }

        }

        private void pbxEuAns1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxEuAns2_DragDrop(object sender, DragEventArgs e)
        {
            //add to and change to frmQuestion4 if last picture box to be drag/dropped
            pbxEuAns2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pbxEuAns2.AllowDrop = false;
            if (euAnsList.Contains(selected))
            {
                player.Score += 1;
                player.Q3Score += 1;
            }
            count += 1;
            if (count == 8)
            {
                CalculateScore();
            }
        }

        private void pbxEuAns2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxEuAns3_DragDrop(object sender, DragEventArgs e)
        {
            //add to and change to frmQuestion4 if last picture box to be drag/dropped
            pbxEuAns3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pbxEuAns3.AllowDrop = false;
            if (euAnsList.Contains(selected))
            {
                player.Score += 1;
                player.Q3Score += 1;
            }
            count += 1;
            if (count == 8)
            {
                CalculateScore();
            }
        }

        private void pbxEuAns3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxEuAns4_DragDrop(object sender, DragEventArgs e)
        {
            //add to and change to frmQuestion4 if last picture box to be drag/dropped
            pbxEuAns4.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pbxEuAns4.AllowDrop = false;
            if (euAnsList.Contains(selected))
            {
                player.Score += 1;
                player.Q3Score += 1;
            }
            count += 1;
            if (count == 8)
            {
                CalculateScore();
            }

        }

        private void pbxEuAns4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxProAns1_DragDrop(object sender, DragEventArgs e)
        {
            //add to and change to frmQuestion4 if last picture box to be drag/dropped
            pbxProAns1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pbxProAns1.AllowDrop = false;
            if (proAnsList.Contains(selected))
            {
                player.Score += 1;
                player.Q3Score += 1;
            }
            count += 1;
            if (count == 8)
            {
                CalculateScore();
            }
        }

        private void pbxProAns1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxProAns2_DragDrop(object sender, DragEventArgs e)
        {
            //add to and change to frmQuestion4 if last picture box to be drag/dropped
            pbxProAns2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pbxProAns2.AllowDrop = false;
            if (proAnsList.Contains(selected))
            {
                player.Score += 1;
                player.Q3Score += 1;
            }
            count += 1;
            if (count == 8)
            {
                CalculateScore();
            }
        }

        private void pbxProAns2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxProAns3_DragDrop(object sender, DragEventArgs e)
        {
            //add to and change to frmQuestion4 if last picture box to be drag/dropped
            pbxProAns3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pbxProAns3.AllowDrop = false;
            if (proAnsList.Contains(selected))
            {
                player.Score += 1;
                player.Q3Score += 1;
            }
            count += 1;
            if (count == 8)
            {
                CalculateScore();
            }
        }

        private void pbxProAns3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxProAns4_DragDrop(object sender, DragEventArgs e)
        {
            //add to and change to frmQuestion4 if last picture box to be drag/dropped
            pbxProAns4.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pbxProAns4.AllowDrop = false;
            if (proAnsList.Contains(selected))
            {
                player.Score += 1;
                player.Q3Score += 1;
            }
            count += 1;
            if (count == 8)
            {
                CalculateScore();
            }
        }

        private void pbxProAns4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxDesc3_MouseDown(object sender, MouseEventArgs e)
        {
            //drag drop method that prevents picture box being dropped into blank space
            selected = pbxDesc3.ImageLocation.ToString();
            int temp = count;
            pbxDesc3.DoDragDrop(pbxDesc3.Image, DragDropEffects.Copy);
            if (temp != count)
            {
                pbxDesc3.Hide();
            }

        }

        private void pbxDesc4_MouseDown(object sender, MouseEventArgs e)
        {
            //drag drop method that prevents picture box being dropped into blank space
            selected = pbxDesc4.ImageLocation.ToString();
            int temp = count;
            pbxDesc4.DoDragDrop(pbxDesc4.Image, DragDropEffects.Copy);
            if (temp != count)
            {
                pbxDesc4.Hide();
            }

        }

        private void pbxDesc5_MouseDown(object sender, MouseEventArgs e)
        {
            //drag drop method that prevents picture box being dropped into blank space
            selected = pbxDesc5.ImageLocation.ToString();
            int temp = count;
            pbxDesc5.DoDragDrop(pbxDesc5.Image, DragDropEffects.Copy);
            if (temp != count)
            {
                pbxDesc5.Hide();
            }

        }

        private void pbxDesc6_MouseDown(object sender, MouseEventArgs e)
        {
            //drag drop method that prevents picture box being dropped into blank space
            selected = pbxDesc6.ImageLocation.ToString();
            int temp = count;
            pbxDesc6.DoDragDrop(pbxDesc6.Image, DragDropEffects.Copy);
            if (temp != count)
            {
                pbxDesc6.Hide();
            }

        }

        private void pbxDesc7_MouseDown(object sender, MouseEventArgs e)
        {
            //drag drop method that prevents picture box being dropped into blank space
            selected = pbxDesc7.ImageLocation.ToString();
            int temp = count;
            pbxDesc7.DoDragDrop(pbxDesc7.Image, DragDropEffects.Copy);
            if (temp != count)
            {
                pbxDesc7.Hide();
            }

        }

        private void pbxDesc8_MouseDown(object sender, MouseEventArgs e)
        {
            //drag drop method that prevents picture box being dropped into blank space
            selected = pbxDesc8.ImageLocation.ToString();
            int temp = count;
            pbxDesc8.DoDragDrop(pbxDesc8.Image, DragDropEffects.Copy);
            if (temp != count)
            {
                pbxDesc8.Hide();
            }

        }

        private void FrmQuestion3_Load(object sender, EventArgs e)
        {
            lblScore.Text = player.Score.ToString();
            try
            {
                string line;
                //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                string filepath = @"prokaryoticvseukaryotic.txt";
                List<string> prokaryotic = new List<string>();
                List<string> eukaryotic = new List<string>();
                
                int counter = 0;

                using (StreamReader sr = new StreamReader(filepath))
                {
                    // Read lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] itemString = line.Split(',');

                        if (counter == 0)
                        {
                            //create prokaryotic list
                            prokaryotic.Add(itemString[0].ToString());
                            prokaryotic.Add(itemString[1].ToString());
                            prokaryotic.Add(itemString[2].ToString());
                            prokaryotic.Add(itemString[3].ToString());
                            prokaryotic.Add(itemString[4].ToString());
                            prokaryotic.Add(itemString[5].ToString());
                        }
                        else
                        {
                            //create eukaryotic list
                            eukaryotic.Add(itemString[0].ToString());
                            eukaryotic.Add(itemString[1].ToString());
                            eukaryotic.Add(itemString[2].ToString());
                            eukaryotic.Add(itemString[3].ToString());
                            eukaryotic.Add(itemString[4].ToString());
                            eukaryotic.Add(itemString[5].ToString());
                            eukaryotic.Add(itemString[6].ToString());
                            eukaryotic.Add(itemString[7].ToString());
                        }
                        counter++;

                    }
                }

                Question NewQuestion = new Question();
                NewQuestion.Prokaryotic = prokaryotic;
                NewQuestion.Eukaryotic = eukaryotic;

                //randomise prokaryotic and eukaryotic lists

                RandomizeQuestions(NewQuestion.Prokaryotic);
                RandomizeQuestions(NewQuestion.Eukaryotic);

                List<string> finalList = new List<string>();

                //create combined list 4 prokaryotic descriptions and 4 eukaryotic descriptions

                finalList.Add(NewQuestion.Prokaryotic[0]);
                finalList.Add(NewQuestion.Prokaryotic[1]);
                finalList.Add(NewQuestion.Prokaryotic[2]);
                finalList.Add(NewQuestion.Prokaryotic[3]);
                finalList.Add(NewQuestion.Eukaryotic[0]);
                finalList.Add(NewQuestion.Eukaryotic[1]);
                finalList.Add(NewQuestion.Eukaryotic[2]);
                finalList.Add(NewQuestion.Eukaryotic[3]);

                proAnsList.Add(NewQuestion.Prokaryotic[0]);
                proAnsList.Add(NewQuestion.Prokaryotic[1]);
                proAnsList.Add(NewQuestion.Prokaryotic[2]);
                proAnsList.Add(NewQuestion.Prokaryotic[3]);
                euAnsList.Add(NewQuestion.Eukaryotic[0]);
                euAnsList.Add(NewQuestion.Eukaryotic[1]);
                euAnsList.Add(NewQuestion.Eukaryotic[2]);
                euAnsList.Add(NewQuestion.Eukaryotic[3]);

                RandomizeQuestions(finalList);

                //Setup Q3 with images from the combined list
                pbxDesc1.ImageLocation = finalList[0].ToString();
                pbxDesc2.ImageLocation = finalList[1].ToString();
                pbxDesc3.ImageLocation = finalList[2].ToString();
                pbxDesc4.ImageLocation = finalList[3].ToString();
                pbxDesc5.ImageLocation = finalList[4].ToString();
                pbxDesc6.ImageLocation = finalList[5].ToString();
                pbxDesc7.ImageLocation = finalList[6].ToString();
                pbxDesc8.ImageLocation = finalList[7].ToString();
            }
            catch (Exception z)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(z.Message);

            }
        }
        private void CalculateScore()
        {
            
            //change form method made to reduce code repetition
            MessageBox.Show("Question completed!");
            this.Close();
            Form frmQuestion4 = new frmQuestion4(player);
            frmQuestion4.Show();


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
        public frmQuestion3(Player playerobj)
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

            //allow drag drop for all pictureboxes

            pbxDesc1.AllowDrop = true;
            pbxDesc2.AllowDrop = true;
            pbxDesc3.AllowDrop = true;
            pbxDesc4.AllowDrop = true;
            pbxDesc5.AllowDrop = true;
            pbxDesc6.AllowDrop = true;
            pbxDesc7.AllowDrop = true;
            pbxDesc8.AllowDrop = true;

            pbxEuAns1.AllowDrop = true;
            pbxEuAns2.AllowDrop = true;
            pbxEuAns3.AllowDrop = true;
            pbxEuAns4.AllowDrop = true;

            pbxProAns1.AllowDrop = true;
            pbxProAns2.AllowDrop = true;
            pbxProAns3.AllowDrop = true;
            pbxProAns4.AllowDrop = true;

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open help
            Program.helpNumber = 5;
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