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
    public partial class frmQuestion4 : Form
    {
        Player player;

        List<string> cellList = new List<string>();
        List<string> animalList = new List<string>();
        List<string> plantList = new List<string>();
        List<string> fungalList = new List<string>();

        int number = 0;
        int number2 = 0;
        int attempts = 0;
        int attempts2 = 0;
        int attempts3 = 0;
        public frmQuestion4()
        {
            InitializeComponent();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmQuestion5 = new frmQuestion5(player);
            frmQuestion5.Show();
        }

        private void frmQuestion4_Load(object sender, EventArgs e)
        {
            //disbale plant and fungal cell questions
            pnlPlant.Enabled = false;
            pnlFungal.Enabled = false;
            lblScore.Text = player.Score.ToString();

            try
            {

                string line;
                //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                string filepath = @"plantvsanimalvsfungal.txt";
                

                

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
                            //create list of all possible components
                            cellList.Add(itemString[0].ToString());
                            cellList.Add(itemString[1].ToString());
                            cellList.Add(itemString[2].ToString());
                            cellList.Add(itemString[3].ToString());
                            cellList.Add(itemString[4].ToString());
                            cellList.Add(itemString[5].ToString());
                            cellList.Add(itemString[6].ToString());
                            cellList.Add(itemString[7].ToString());
                            cellList.Add(itemString[8].ToString());
                            cellList.Add(itemString[9].ToString());
                            cellList.Add(itemString[10].ToString());
                            cellList.Add(itemString[11].ToString());
                            cellList.Add(itemString[12].ToString());


                        }
                        else if (counter == 1)
                        {
                            //create list of only animal components
                            animalList.Add(itemString[0].ToString());
                            animalList.Add(itemString[1].ToString());
                            animalList.Add(itemString[2].ToString());
                            animalList.Add(itemString[3].ToString());
                            animalList.Add(itemString[4].ToString());
                            animalList.Add(itemString[5].ToString());
                            animalList.Add(itemString[6].ToString());
                            animalList.Add(itemString[7].ToString());
                            animalList.Add(itemString[8].ToString());
                        }
                        else if (counter == 2)
                        {
                            //create list of only plant components
                            plantList.Add(itemString[0].ToString());
                            plantList.Add(itemString[1].ToString());
                            plantList.Add(itemString[2].ToString());
                            plantList.Add(itemString[3].ToString());
                            plantList.Add(itemString[4].ToString());
                            plantList.Add(itemString[5].ToString());
                            plantList.Add(itemString[6].ToString());
                            plantList.Add(itemString[7].ToString());
                            plantList.Add(itemString[8].ToString());
                            plantList.Add(itemString[9].ToString());
                        }
                        else
                        {
                            //create list of only fungal components
                            fungalList.Add(itemString[0].ToString());
                            fungalList.Add(itemString[1].ToString());
                            fungalList.Add(itemString[2].ToString());
                            fungalList.Add(itemString[3].ToString());
                            fungalList.Add(itemString[4].ToString());
                            fungalList.Add(itemString[5].ToString());
                            fungalList.Add(itemString[6].ToString());
                            fungalList.Add(itemString[7].ToString());
                            fungalList.Add(itemString[8].ToString());
                            fungalList.Add(itemString[9].ToString());
                            fungalList.Add(itemString[10].ToString());
                        }
                        counter++;

                    }
                }

                //create mix of components for animal question
                RandomizeQuestions(cellList);

                rbnAnimal1.Text = cellList[0].ToString();
                rbnAnimal2.Text = cellList[1].ToString();
                rbnAnimal3.Text = cellList[2].ToString();
                rbnAnimal4.Text = cellList[3].ToString();
                rbnAnimal5.Text = cellList[4].ToString();

                //create mix of components for plant question
                RandomizeQuestions(cellList);

                rbnPlant1.Text = cellList[0].ToString();
                rbnPlant2.Text = cellList[1].ToString();
                rbnPlant3.Text = cellList[2].ToString();
                rbnPlant4.Text = cellList[3].ToString();
                rbnPlant5.Text = cellList[4].ToString();

                //create mix of components for fungal question
                RandomizeQuestions(cellList);

                rbnFungal1.Text = cellList[0].ToString();
                rbnFungal2.Text = cellList[1].ToString();
                rbnFungal3.Text = cellList[2].ToString();
                rbnFungal4.Text = cellList[3].ToString();
                rbnFungal5.Text = cellList[4].ToString();

                




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
        public frmQuestion4(Player playerobj)
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

        private void rbnAnimal1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnCheckFungal_Click(object sender, EventArgs e)
        {
            //check fungal answer on first attempt
            if (attempts3 == 0)
            {
                //check if rbnFungal1 is selected and is in fungal list
                if (fungalList.Contains(rbnFungal1.Text.ToString()) && rbnFungal1.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlFungal.Enabled = false;
                    MessageBox.Show("Question completed!");
                    this.Close();
                    Form frmQuestion5 = new frmQuestion5(player);
                    frmQuestion5.Show();
                }
                //check if rbnFungal2 is selected and is in fungal list
                else if (fungalList.Contains(rbnFungal2.Text.ToString()) && rbnFungal2.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlFungal.Enabled = false;
                    MessageBox.Show("Question completed!");
                    this.Close();
                    Form frmQuestion5 = new frmQuestion5(player);
                    frmQuestion5.Show();
                }
                //check if rbnFungal3 is selected and is in fungal list
                else if (fungalList.Contains(rbnFungal3.Text.ToString()) && rbnFungal3.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlFungal.Enabled = false;
                    MessageBox.Show("Question completed!");
                    this.Close();
                    Form frmQuestion5 = new frmQuestion5(player);
                    frmQuestion5.Show();
                }
                //check if rbnFungal4 is selected and is in fungal list
                else if (fungalList.Contains(rbnFungal4.Text.ToString()) && rbnFungal4.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlFungal.Enabled = false;
                    MessageBox.Show("Question completed!");
                    this.Close();
                    Form frmQuestion5 = new frmQuestion5(player);
                    frmQuestion5.Show();
                }
                //check if rbnFungal5 is selected and is in fungal list
                else if (fungalList.Contains(rbnFungal5.Text.ToString()) && rbnFungal5.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlFungal.Enabled = false;
                    MessageBox.Show("Question completed!");
                    this.Close();
                    Form frmQuestion5 = new frmQuestion5(player);
                    frmQuestion5.Show();
                }
                //answer not correct
                else
                {
                    MessageBox.Show("Incorrect! You have 1 guess remaining");
                }
            }
            //check fungal answer on second attempt
            if (attempts3 == 1)
            {
                //check if rbnFungal1 is selected and is in fungal list
                if (fungalList.Contains(rbnFungal1.Text.ToString()) && rbnFungal1.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlFungal.Enabled = false;
                    MessageBox.Show("Question completed!");
                    this.Close();
                    Form frmQuestion5 = new frmQuestion5(player);
                    frmQuestion5.Show();
                }
                //check if rbnFungal2 is selected and is in fungal list
                else if (fungalList.Contains(rbnFungal2.Text.ToString()) && rbnFungal2.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlFungal.Enabled = false;
                    MessageBox.Show("Question completed!");
                    this.Close();
                    Form frmQuestion5 = new frmQuestion5(player);
                    frmQuestion5.Show();
                }
                //check if rbnFungal3 is selected and is in fungal list
                else if (fungalList.Contains(rbnFungal3.Text.ToString()) && rbnFungal3.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlFungal.Enabled = false;
                    MessageBox.Show("Question completed!");
                    this.Close();
                    Form frmQuestion5 = new frmQuestion5(player);
                    frmQuestion5.Show();
                }
                //check if rbnFungal4 is selected and is in fungal list
                else if (fungalList.Contains(rbnFungal4.Text.ToString()) && rbnFungal4.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlFungal.Enabled = false;
                    MessageBox.Show("Question completed!");
                    this.Close();
                    Form frmQuestion5 = new frmQuestion5(player);
                    frmQuestion5.Show();
                }
                //check if rbnFungal5 is selected and is in fungal list
                else if (fungalList.Contains(rbnFungal5.Text.ToString()) && rbnFungal5.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlFungal.Enabled = false;
                    MessageBox.Show("Question completed!");
                    this.Close();
                    Form frmQuestion5 = new frmQuestion5(player);
                    frmQuestion5.Show();
                }
                //answer not correct
                else
                {
                    MessageBox.Show("Incorrect! You have 0 guesses remaining");
                    pnlFungal.Enabled = false;
                    MessageBox.Show("Question completed!");
                    this.Close();
                    Form frmQuestion5 = new frmQuestion5(player);
                    frmQuestion5.Show();
                }
            }
            //increase attempts by 1
            attempts3++;
        }

        private void pnlAnimal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAnimal_Click(object sender, EventArgs e)
        {

        }

        private void rbnAnimal2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnAnimal3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnAnimal4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnAnimal5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckAnimal_Click_1(object sender, EventArgs e)
        {
            //check animal answer on first attempt
            if (attempts == 0)
            {
                //check if rbnAnimal1 is selected and is in animal list
                if (animalList.Contains(rbnAnimal1.Text.ToString()) && rbnAnimal1.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlAnimal.Enabled = false;
                    pnlPlant.Enabled = true;
                }
                //check if rbnAnimal2 is selected and is in animal list
                else if (animalList.Contains(rbnAnimal2.Text.ToString()) && rbnAnimal2.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlAnimal.Enabled = false;
                    pnlPlant.Enabled = true;
                }
                //check if rbnAnimal3 is selected and is in animal list
                else if (animalList.Contains(rbnAnimal3.Text.ToString()) && rbnAnimal3.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlAnimal.Enabled = false;
                    pnlPlant.Enabled = true;
                }
                //check if rbnAnimal4 is selected and is in animal list
                else if (animalList.Contains(rbnAnimal4.Text.ToString()) && rbnAnimal4.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlAnimal.Enabled = false;
                    pnlPlant.Enabled = true;
                }
                //check if rbnAnimal5 is selected and is in animal list
                else if (animalList.Contains(rbnAnimal5.Text.ToString()) && rbnAnimal5.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlAnimal.Enabled = false;
                    pnlPlant.Enabled = true;
                }
                //answer not correct
                else
                {
                    MessageBox.Show("Incorrect! You have 1 guess remaining");
                }
            }
            //check animal answer on second attempt
            if (attempts == 1)
            {
                //check if rbnAnimal1 is selected and is in animal list
                if (animalList.Contains(rbnAnimal1.Text.ToString()) && rbnAnimal1.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlAnimal.Enabled = false;
                    pnlPlant.Enabled = true;
                }
                //check if rbnAnimal2 is selected and is in animal list
                else if (animalList.Contains(rbnAnimal2.Text.ToString()) && rbnAnimal2.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlAnimal.Enabled = false;
                    pnlPlant.Enabled = true;
                }
                //check if rbnAnimal3 is selected and is in animal list
                else if (animalList.Contains(rbnAnimal3.Text.ToString()) && rbnAnimal3.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlAnimal.Enabled = false;
                    pnlPlant.Enabled = true;
                }
                //check if rbnAnimal4 is selected and is in animal list
                else if (animalList.Contains(rbnAnimal4.Text.ToString()) && rbnAnimal4.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlAnimal.Enabled = false;
                    pnlPlant.Enabled = true;
                }
                //check if rbnAnimal5 is selected and is in animal list
                else if (animalList.Contains(rbnAnimal5.Text.ToString()) && rbnAnimal5.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlAnimal.Enabled = false;
                    pnlPlant.Enabled = true;
                }
                //answer not correct
                else
                {
                    MessageBox.Show("Incorrect! You have 0 guesses remaining");
                    pnlAnimal.Enabled = false;
                    pnlPlant.Enabled = true;
                }
            }
            //increase attempts by 1
            attempts++;
        }

        private void btnCheckPlant_Click_1(object sender, EventArgs e)
        {
            //check plant answer on first attempt
            if (attempts2 == 0)
            {
                //check if rbnPlant1 is selected and is in plant list
                if (plantList.Contains(rbnPlant1.Text.ToString()) && rbnPlant1.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlPlant.Enabled = false;
                    pnlFungal.Enabled = true;
                }
                //check if rbnPlant2 is selected and is in plant list
                else if (plantList.Contains(rbnPlant2.Text.ToString()) && rbnPlant2.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlPlant.Enabled = false;
                    pnlFungal.Enabled = true;
                }
                //check if rbnPlant3 is selected and is in plant list
                else if (plantList.Contains(rbnPlant3.Text.ToString()) && rbnPlant3.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlPlant.Enabled = false;
                    pnlFungal.Enabled = true;
                }
                //check if rbnPlant4 is selected and is in plant list
                else if (plantList.Contains(rbnPlant4.Text.ToString()) && rbnPlant4.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlPlant.Enabled = false;
                    pnlFungal.Enabled = true;
                }
                //check if rbnPlant5 is selected and is in plant list
                else if (plantList.Contains(rbnPlant5.Text.ToString()) && rbnPlant5.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlPlant.Enabled = false;
                    pnlFungal.Enabled = true;
                }
                //answer not correct
                else
                {
                    MessageBox.Show("Incorrect! You have 1 guess remaining");
                }
            }
            //check plant answer on second attempt
            if (attempts2 == 1)
            {
                //check if rbnPlant1 is selected and is in plant list
                if (plantList.Contains(rbnPlant1.Text.ToString()) && rbnPlant1.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlPlant.Enabled = false;
                    pnlFungal.Enabled = true;
                }
                //check if rbnPlant2 is selected and is in plant list
                else if (plantList.Contains(rbnPlant2.Text.ToString()) && rbnPlant2.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlPlant.Enabled = false;
                    pnlFungal.Enabled = true;
                }
                //check if rbnPlant3 is selected and is in plant list
                else if (plantList.Contains(rbnPlant3.Text.ToString()) && rbnPlant3.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlPlant.Enabled = false;
                    pnlFungal.Enabled = true;
                }
                //check if rbnPlant4 is selected and is in plant list
                else if (plantList.Contains(rbnPlant4.Text.ToString()) && rbnPlant4.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlPlant.Enabled = false;
                    pnlFungal.Enabled = true;
                }
                //check if rbnPlant5 is selected and is in plant list
                else if (plantList.Contains(rbnPlant5.Text.ToString()) && rbnPlant5.Checked == true)
                {
                    player.Score += 1;
                    player.Q4Score += 1;
                    number2 += 1;
                    MessageBox.Show("Correct!");
                    pnlPlant.Enabled = false;
                    pnlFungal.Enabled = true;
                }
                //answer not correct
                else
                {
                    MessageBox.Show("Incorrect! You have 0 guesses remaining");
                    pnlPlant.Enabled = false;
                    pnlFungal.Enabled = true;
                }
            }
            //increase attempts by 1
            attempts2++;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //open help
            Program.helpNumber = 6;
            Form frmHelp = new frmHelp(player);
            frmHelp.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //display info about software
            MessageBox.Show("Property of Evergreen Studios 2022");
        }
    }
}
