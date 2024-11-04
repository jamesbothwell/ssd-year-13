using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AS2_BiologyQuiz
{
    public partial class FrmQuestion2 : Form
    {
        Player player;
        List<Question> listItems = new List<Question>();
        int i = 0;
        
        public FrmQuestion2()
        {
            InitializeComponent();
        }

        private void frmQuestion2_Load(object sender, EventArgs e)
        {
            lblScore.Text = player.Score.ToString();
            try
            {

                string line;
                //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                string filepath = @"osmosis.txt";

                

                

                using (StreamReader sr = new StreamReader(filepath))
                {
                    // Read lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] itemString = line.Split(',');

                        Question NewQuestion = new Question();
                        List<List<string>> superlist = new List<List<string>>();
                        List<string> list = new List<string>();
                        List<string> list2 = new List<string>();
                        List<string> list3 = new List<string>();
                        List<string> list4 = new List<string>();
                        NewQuestion.WaterPotential = itemString[0];                      

                        //seperate different cell labels by the use of multiple lists

                        list.Add(itemString[1].ToString());
                        list.Add(itemString[2].ToString());
                        list2.Add(itemString[3].ToString());
                        list2.Add(itemString[4].ToString());
                        list3.Add(itemString[5].ToString());
                        list3.Add(itemString[6].ToString());
                        list4.Add(itemString[7].ToString());
                        list4.Add(itemString[8].ToString());

                        NewQuestion.SpAns = itemString[1];
                        NewQuestion.PpAns = itemString[2];

                        superlist.Add(list);
                        superlist.Add(list2);
                        superlist.Add(list3);
                        superlist.Add(list4);

                        //combine the lists and randomise

                        RandomizeQuestions(superlist);

                        //add combined list to question list

                        NewQuestion.Sp1 = superlist[0][0];
                        NewQuestion.Pp1 = superlist[0][1];
                        NewQuestion.Sp2 = superlist[1][0];
                        NewQuestion.Pp2 = superlist[1][1];
                        NewQuestion.Sp3 = superlist[2][0];
                        NewQuestion.Pp3 = superlist[2][1];
                        NewQuestion.Sp4 = superlist[3][0];
                        NewQuestion.Pp4 = superlist[3][1];


                        //add question list to listItems
                        listItems.Add(NewQuestion);
                    }
                }
                //randomise listItmes
                RandomizeQuestions(listItems);


                //assign values to solute and pressure potential labels
                
                lblWaterPotential.Text = listItems[i].WaterPotential;

                lblSpCell1.Text = listItems[i].Sp1;
                lblSpCell2.Text = listItems[i].Sp2;
                lblSpCell3.Text = listItems[i].Sp3;
                lblSpCell4.Text = listItems[i].Sp4;

                lblPpCell1.Text = listItems[i].Pp1;
                lblPpCell2.Text = listItems[i].Pp2;
                lblPpCell3.Text = listItems[i].Pp3;
                lblPpCell4.Text = listItems[i].Pp4;

                int noOfTimes = i + 1;
                lblCount.Text = noOfTimes.ToString();

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

        

        public FrmQuestion2(Player playerobj)
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

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int x = pbxBucket.Location.X;
            int y = pbxBucket.Location.Y;

            //key commands to move pbxBucket

            switch (keyData)
            {
                case Keys.Left: // left arrow key
                    x -= 10;
                    break;
                case Keys.Right: // right arrow key
                    x += 10;
                    break;
                case Keys.Down: // left arrow key
                    y += 10;
                    break;
                case Keys.Up: // right arrow key
                    y -= 10;
                    break;

            }

            pbxBucket.Location = new Point(x, y);

            //check if pbxCell1 is correct answer

                if (pbxBucket.Bounds.IntersectsWith(pbxCell1.Bounds))
                {
                    if (lblSpCell1.Text == listItems[i].SpAns && lblPpCell1.Text == listItems[i].PpAns)
                    {
                        MessageBox.Show("Correct - 1 point added to score");
                        pbxBucket.Location = new Point(361, 205);
                        player.Score += 1;
                        player.Q2Score += 1;
                        i++;
                }
                //incorrect answer
                else
                {
                        MessageBox.Show("Incorrect");
                        pbxBucket.Location = new Point(361, 205);
                    i++;
                }
                    

                }
            //check if pbxCell2 is correct answer
            else if (pbxBucket.Bounds.IntersectsWith(pbxCell2.Bounds))
                {
                    if (lblSpCell2.Text == listItems[i].SpAns && lblPpCell2.Text == listItems[i].PpAns)
                    {
                        MessageBox.Show("Correct - 1 point added to score");
                        pbxBucket.Location = new Point(361, 205);
                        player.Score += 1;
                        player.Q2Score += 1;
                    i++;
                }
                //incorrect answer
                else
                {
                        MessageBox.Show("Incorrect");
                        pbxBucket.Location = new Point(361, 205);
                    i++;
                }
                    
                }
            //check if pbxCell2 is correct answer
            else if (pbxBucket.Bounds.IntersectsWith(pbxCell3.Bounds))
                {
                    if (lblSpCell3.Text == listItems[i].SpAns && lblPpCell3.Text == listItems[i].PpAns)
                    {
                        MessageBox.Show("Correct - 1 point added to score");
                        pbxBucket.Location = new Point(361, 205);
                        player.Score += 1;
                        player.Q2Score += 1;
                    i++;
                    }
                    //incorrect answer
                    else
                    {
                        MessageBox.Show("Incorrect");
                        pbxBucket.Location = new Point(361, 205);
                    i++;
                    }
                    
                }
            //check if pbxCell4 is correct answer
            else if (pbxBucket.Bounds.IntersectsWith(pbxCell4.Bounds))
                {
                    if (lblSpCell4.Text == listItems[i].SpAns && lblPpCell4.Text == listItems[i].PpAns)
                    {
                        MessageBox.Show("Correct - 1 point added to score");
                        pbxBucket.Location = new Point(361, 205);
                        player.Score += 1;
                        player.Q2Score += 1;
                    i++;
                }
                    //incorrect answer
                    else
                    {
                        MessageBox.Show("Incorrect");
                        pbxBucket.Location = new Point(361, 205);
                    i++;
                }
                    
                }
            //check if pbxBucket is out of bounds
            else if (pbxBucket.Bounds.IntersectsWith(pbxBoundary1.Bounds))
            {
                
                    MessageBox.Show("Out of bounds");
                    pbxBucket.Location = new Point(361, 205);
                    

            }
            //check if pbxBucket is out of bounds
            else if (pbxBucket.Bounds.IntersectsWith(pbxBoundary2.Bounds))
            {

                MessageBox.Show("Out of bounds");
                pbxBucket.Location = new Point(361, 205);


            }

                //assign new values to solute and pressure potential labels when round is complete

            lblWaterPotential.Text = listItems[i].WaterPotential;

                lblSpCell1.Text = listItems[i].Sp1;
                lblSpCell2.Text = listItems[i].Sp2;
                lblSpCell3.Text = listItems[i].Sp3;
                lblSpCell4.Text = listItems[i].Sp4;

                lblPpCell1.Text = listItems[i].Pp1;
                lblPpCell2.Text = listItems[i].Pp2;
                lblPpCell3.Text = listItems[i].Pp3;
                lblPpCell4.Text = listItems[i].Pp4;

            int noOfTimes = i + 1;
            if (noOfTimes == 4)
            {
                //change to frmQuestion3 after 3 rounds
                MessageBox.Show("Question completed!");
                this.Close();
                Form frmQuestion3 = new frmQuestion3(player);
                frmQuestion3.Show();
            }
            lblCount.Text = noOfTimes.ToString();

            




            return base.ProcessCmdKey(ref msg, keyData);


        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open help
            Program.helpNumber = 4;
            Form frmHelp = new frmHelp(player);
            frmHelp.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display help about software
            MessageBox.Show("Property of Evergreen Studios 2022");
        }
    }
}
