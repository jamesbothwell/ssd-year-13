using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2_BiologyQuiz
{
    [Serializable]
    public class Player
    {
        private string _Username;
        private string _Password;
        private string _Avatar;
        private string _Hint;
        private int _Score;
        private int _HighestScore;
        private int _Q1Score;
        private int _Q2Score;
        private int _Q3Score;
        private int _Q4Score;
        private int _Q5Score;


        public string Username
        {
            get { return _Username; }
            set { 
                //Validation on Username so that username is greater than 8 characters and less then 20, and is not set to null
                if (value.Length == 0) { throw new RegistrationException("You must enter a username"); }
                else if (value.Length > 20) { throw new RegistrationException("Your username must be less than 20 characters"); }
                else if (value.Length < 8) { throw new RegistrationException("Your username must be longer than 8 characters"); }
                else { _Username = value; };
            }
        }
        public string Password
        {
            get { return _Password; }
            set {
                //Validation on Password so that password is greater than 8 characters and less then 20, and is not set to null
                if (value.Length == 0) { throw new RegistrationException("You must enter a password"); }
                else if (value.Length > 20) { throw new RegistrationException("Your password must be less than 20 characters"); }
                else if (value.Length < 8) { throw new RegistrationException("Your password must be longer than 8 characters"); }
                else { _Password = value; };
            }
        }
        public string Avatar
        {
            get { return _Avatar; }
            set {
                //Validation of Avatar so that there is an image location and it is not set to null
                if (value.Length == null) { throw new RegistrationException("You must choose an avatar"); }
                else { _Avatar = value; }
                }
        }
        public string Hint
        {
            get { return _Hint; }
            set
            {
                //Validation of Hint so that a hint has been enetered and is not set to null
                if (value.Length == 0) { throw new RegistrationException("You must enter a hint"); }
                else { _Hint = value; }
            }
        }
        public int Score
        {
            get { return _Score; }
            set { _Score = value; }
        }
        public int HighestScore
        {
            get { return _HighestScore; }
            set { _HighestScore = value; }
        }
        public int Q1Score
        {
            get { return _Q1Score; }
            set { _Q1Score = value; }
        }
        public int Q2Score
        {
            get { return _Q2Score; }
            set { _Q2Score = value; }
        }
        public int Q3Score
        {
            get { return _Q3Score; }
            set { _Q3Score = value; }
        }
        public int Q4Score
        {
            get { return _Q4Score; }
            set { _Q4Score = value; }
        }
        public int Q5Score
        {
            get { return _Q5Score; }
            set { _Q5Score = value; }
        }

        public Player()
        {
        }

        public Player(string username, string password, string avatar, int score, int highestScore, int q1score, int q2score, int q3score, int q4score, int q5score)
        {
            //creation of a constructor for the player class
            _Username = username;
            _Password = password;
            _Avatar = avatar;
            _Score = score;
            _HighestScore = highestScore;
            _Q1Score = q1score;
            _Q2Score = q1score;
            _Q3Score = q1score;
            _Q4Score = q1score;
            _Q5Score = q1score;
        }

    }
}
