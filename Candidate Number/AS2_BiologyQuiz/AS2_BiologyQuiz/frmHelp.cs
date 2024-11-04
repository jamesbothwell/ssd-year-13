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
    public partial class frmHelp : Form
    {
        Player player;
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            //change the help to help for login
            if (Program.helpNumber == 0)
            {
                try
                {
                    string line;
                    //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                    string filepath = @"helpLogin.txt";
                    List<string> help = new List<string>();
                    

                    int counter = 0;

                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        // Read lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] itemString = line.Split(',');
                            help.Add(itemString[0].ToString());
                            help.Add(itemString[1].ToString());
                            help.Add(itemString[2].ToString());
                            help.Add(itemString[3].ToString());
                            help.Add(itemString[4].ToString());
                            help.Add(itemString[5].ToString());
                        }
                        
                    }
                    lblHelp1.Text = help[0].ToString();
                    lblHelp2.Text = help[1].ToString();
                    lblHelp3.Text = help[2].ToString();
                    lblHelp4.Text = help[3].ToString();
                    lblHelp5.Text = help[4].ToString();
                    lblHelp6.Text = help[5].ToString();
                    lblForm.Text = "Login";
                }
                catch (Exception z)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(z.Message);

                }
                
                
            }
            //change the help to help for register
            if (Program.helpNumber == 1)
            {
                try
                {
                    string line;
                    //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                    string filepath = @"helpRegister.txt";
                    List<string> help = new List<string>();


                    int counter = 0;

                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        // Read lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] itemString = line.Split(',');
                            help.Add(itemString[0].ToString());
                            help.Add(itemString[1].ToString());
                            help.Add(itemString[2].ToString());
                            help.Add(itemString[3].ToString());
                            help.Add(itemString[4].ToString());
                            help.Add(itemString[5].ToString());
                        }

                    }
                    lblHelp1.Text = help[0].ToString();
                    lblHelp2.Text = help[1].ToString();
                    lblHelp3.Text = help[2].ToString();
                    lblHelp4.Text = help[3].ToString();
                    lblHelp5.Text = help[4].ToString();
                    lblHelp6.Text = help[5].ToString();
                    lblForm.Text = "Register";
                }
                catch (Exception z)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(z.Message);

                }


            }
            //change the help to help for menu
            if (Program.helpNumber == 2)
            {
                try
                {
                    string line;
                    //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                    string filepath = @"helpMenu.txt";
                    List<string> help = new List<string>();


                    int counter = 0;

                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        // Read lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] itemString = line.Split(',');
                            help.Add(itemString[0].ToString());
                            help.Add(itemString[1].ToString());
                            help.Add(itemString[2].ToString());
                            help.Add(itemString[3].ToString());
                            help.Add(itemString[4].ToString());
                            help.Add(itemString[5].ToString());
                        }

                    }
                    lblHelp1.Text = help[0].ToString();
                    lblHelp2.Text = help[1].ToString();
                    lblHelp3.Text = help[2].ToString();
                    lblHelp4.Text = help[3].ToString();
                    lblHelp5.Text = help[4].ToString();
                    lblHelp6.Text = help[5].ToString();
                    lblForm.Text = "Menu";
                }
                catch (Exception z)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(z.Message);

                }


            }
            //change the help to help for q1
            if (Program.helpNumber == 3)
            {
                try
                {
                    string line;
                    //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                    string filepath = @"helpQuestion1.txt";
                    List<string> help = new List<string>();


                    int counter = 0;

                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        // Read lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] itemString = line.Split(',');
                            help.Add(itemString[0].ToString());
                            help.Add(itemString[1].ToString());
                            help.Add(itemString[2].ToString());
                            help.Add(itemString[3].ToString());
                            help.Add(itemString[4].ToString());
                            help.Add(itemString[5].ToString());
                        }

                    }
                    lblHelp1.Text = help[0].ToString();
                    lblHelp2.Text = help[1].ToString();
                    lblHelp3.Text = help[2].ToString();
                    lblHelp4.Text = help[3].ToString();
                    lblHelp5.Text = help[4].ToString();
                    lblHelp6.Text = help[5].ToString();
                    lblForm.Text = "Question 1";
                }
                catch (Exception z)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(z.Message);

                }


            }
            //change the help to help for q2
            if (Program.helpNumber == 4)
            {
                try
                {
                    string line;
                    //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                    string filepath = @"helpQuestion2.txt";
                    List<string> help = new List<string>();


                    int counter = 0;

                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        // Read lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] itemString = line.Split(',');
                            help.Add(itemString[0].ToString());
                            help.Add(itemString[1].ToString());
                            help.Add(itemString[2].ToString());
                            help.Add(itemString[3].ToString());
                            help.Add(itemString[4].ToString());
                            help.Add(itemString[5].ToString());
                        }

                    }
                    lblHelp1.Text = help[0].ToString();
                    lblHelp2.Text = help[1].ToString();
                    lblHelp3.Text = help[2].ToString();
                    lblHelp4.Text = help[3].ToString();
                    lblHelp5.Text = help[4].ToString();
                    lblHelp6.Text = help[5].ToString();
                    lblForm.Text = "Question 2";
                }
                catch (Exception z)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(z.Message);

                }


            }
            //change the help to help for q3
            if (Program.helpNumber == 5)
            {
                try
                {
                    string line;
                    //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                    string filepath = @"helpQuestion3.txt";
                    List<string> help = new List<string>();


                    int counter = 0;

                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        // Read lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] itemString = line.Split(',');
                            help.Add(itemString[0].ToString());
                            help.Add(itemString[1].ToString());
                            help.Add(itemString[2].ToString());
                            help.Add(itemString[3].ToString());
                            help.Add(itemString[4].ToString());
                            help.Add(itemString[5].ToString());
                        }

                    }
                    lblHelp1.Text = help[0].ToString();
                    lblHelp2.Text = help[1].ToString();
                    lblHelp3.Text = help[2].ToString();
                    lblHelp4.Text = help[3].ToString();
                    lblHelp5.Text = help[4].ToString();
                    lblHelp6.Text = help[5].ToString();
                    lblForm.Text = "Question 3";
                }
                catch (Exception z)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(z.Message);

                }


            }
            //change the help to help for q4
            if (Program.helpNumber == 6)
            {
                try
                {
                    string line;
                    //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                    string filepath = @"helpQuestion4.txt";
                    List<string> help = new List<string>();


                    int counter = 0;

                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        // Read lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] itemString = line.Split(',');
                            help.Add(itemString[0].ToString());
                            help.Add(itemString[1].ToString());
                            help.Add(itemString[2].ToString());
                            help.Add(itemString[3].ToString());
                            help.Add(itemString[4].ToString());
                            help.Add(itemString[5].ToString());
                        }

                    }
                    lblHelp1.Text = help[0].ToString();
                    lblHelp2.Text = help[1].ToString();
                    lblHelp3.Text = help[2].ToString();
                    lblHelp4.Text = help[3].ToString();
                    lblHelp5.Text = help[4].ToString();
                    lblHelp6.Text = help[5].ToString();
                    lblForm.Text = "Question 4";
                }
                catch (Exception z)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(z.Message);

                }


            }
            //change the help to help for q5
            if (Program.helpNumber == 7)
            {
                try
                {
                    string line;
                    //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                    string filepath = @"helpQuestion5.txt";
                    List<string> help = new List<string>();


                    int counter = 0;

                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        // Read lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] itemString = line.Split(',');
                            help.Add(itemString[0].ToString());
                            help.Add(itemString[1].ToString());
                            help.Add(itemString[2].ToString());
                            help.Add(itemString[3].ToString());
                            help.Add(itemString[4].ToString());
                            help.Add(itemString[5].ToString());
                        }

                    }
                    lblHelp1.Text = help[0].ToString();
                    lblHelp2.Text = help[1].ToString();
                    lblHelp3.Text = help[2].ToString();
                    lblHelp4.Text = help[3].ToString();
                    lblHelp5.Text = help[4].ToString();
                    lblHelp6.Text = help[5].ToString();
                    lblForm.Text = "Question 5";
                }
                catch (Exception z)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(z.Message);

                }


            }
            //change the help to help for high scores
            if (Program.helpNumber == 8)
            {
                try
                {
                    string line;
                    //Path to file with questions is stored in folder in project ReadingQuestionsAnswersToScreen\bin\Debug
                    string filepath = @"helpHighScores.txt";
                    List<string> help = new List<string>();


                    int counter = 0;

                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        // Read lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] itemString = line.Split(',');
                            help.Add(itemString[0].ToString());
                            help.Add(itemString[1].ToString());
                            help.Add(itemString[2].ToString());
                            help.Add(itemString[3].ToString());
                            help.Add(itemString[4].ToString());
                            help.Add(itemString[5].ToString());
                        }

                    }
                    lblHelp1.Text = help[0].ToString();
                    lblHelp2.Text = help[1].ToString();
                    lblHelp3.Text = help[2].ToString();
                    lblHelp4.Text = help[3].ToString();
                    lblHelp5.Text = help[4].ToString();
                    lblHelp6.Text = help[5].ToString();
                    lblForm.Text = "High Scores";
                }
                catch (Exception z)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(z.Message);

                }


            }
        }
        public frmHelp(Player playerobj)
        {
            InitializeComponent();
            player = playerobj;
            

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //close help
            this.Close();
            //start timer for question 1
            if (Program.helpNumber == 3)
            {
                Program.timerStop = 1;
            }
        }
    }
}
