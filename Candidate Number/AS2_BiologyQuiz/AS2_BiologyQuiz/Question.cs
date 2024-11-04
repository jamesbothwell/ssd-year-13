using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2_BiologyQuiz
{
    class Question
    {
        //create all fields

        private string QuestionText;
        private string CorrectAnswer;
        private string incorrectAnswer1;
        private string incorrectAnswer2;

        private string waterPotential;
        private string sp1;
        private string pp1;
        private string sp2;
        private string pp2;
        private string sp3;
        private string pp3;
        private string sp4;
        private string pp4;
        private string spAns;
        private string ppAns;

        private string component1;
        private string component2;
        private string component3;
        private string component4;
        private string component5;
        private string component6;
        private string component7;
        private string component8;

        private List<string> prokaryotic;
        private List<string> eukaryotic;
        private List<string> finalList;

        private List<string> mitosis1;
        private List<string> mitosis2;
        private List<string> mitosis3;

        public Question()
        {

        }
        public Question(string questionText, string correctAnswer, string incorrectAnswer1, string incorrectAnswer2, string incorrectAnswer3)
        {
            //constructor for question 1 and question 5
            QuestionText1 = questionText;
            CorrectAnswer1 = correctAnswer;
            this.IncorrectAnswer1 = incorrectAnswer1;
            this.IncorrectAnswer2 = incorrectAnswer2;
            this.IncorrectAnswer3 = incorrectAnswer3;
        }

        public Question(string waterPotential, string sp1, string pp1, string sp2, string pp2, string sp3, string pp3, string sp4, string pp4, string spAns, string ppAns)
        {
            //constructor for question 2
            WaterPotential = waterPotential;
            this.Sp1 = sp1;
            this.Pp1 = pp1;
            this.Sp2 = sp2;
            this.Pp2 = pp2;
            this.Sp3 = sp3;
            this.Pp3 = pp3;
            this.Sp4 = sp4;
            this.Pp4 = pp4;
            this.SpAns = spAns;
            this.PpAns = ppAns;
        }
        public Question(List<string> euList, List<string> proList, List<String> finallist)
        {
            //constructor for question 3
            this.eukaryotic = euList;
            this.prokaryotic = proList;
            this.FinalList = finallist;
        }
        
        //create all properties

        public string QuestionText1 { get => QuestionText; set => QuestionText = value; }
        public string CorrectAnswer1 { get => CorrectAnswer; set => CorrectAnswer = value; }
        public string IncorrectAnswer1 { get => incorrectAnswer1; set => incorrectAnswer1 = value; }
        public string IncorrectAnswer2 { get => incorrectAnswer2; set => incorrectAnswer2 = value; }
        public string IncorrectAnswer3 { get => incorrectAnswer2; set => incorrectAnswer2 = value; }
        public string WaterPotential { get => waterPotential; set => waterPotential = value; }
        public string Sp1 { get => sp1; set => sp1 = value; }
        public string Pp1 { get => pp1; set => pp1 = value; }
        public string Sp2 { get => sp2; set => sp2 = value; }
        public string Pp2 { get => pp2; set => pp2 = value; }
        public string Sp3 { get => sp3; set => sp3 = value; }
        public string Pp3 { get => pp3; set => pp3 = value; }
        public string Sp4 { get => sp4; set => sp4 = value; }
        public string Pp4 { get => pp4; set => pp4 = value; }
        public string Component1 { get => component1; set => component1 = value; }
        public string Component2 { get => component2; set => component2 = value; }
        public string Component3 { get => component3; set => component3 = value; }
        public string Component4 { get => component4; set => component4 = value; }
        public string Component5 { get => component5; set => component5 = value; }
        public string Component6 { get => component6; set => component6 = value; }
        public List<string> Prokaryotic { get => prokaryotic; set => prokaryotic = value; }
        public List<string> Eukaryotic { get => eukaryotic; set => eukaryotic = value; }
        public List<string> FinalList { get => finalList; set => finalList = value; }
        public List<string> Mitosis1 { get => mitosis1; set => mitosis1 = value; }
        public List<string> Mitosis2 { get => mitosis2; set => mitosis2 = value; }
        public List<string> Mitosis3 { get => mitosis3; set => mitosis3 = value; }
        public string SpAns { get => spAns; set => spAns = value; }
        public string PpAns { get => ppAns; set => ppAns = value; }
    }
}
