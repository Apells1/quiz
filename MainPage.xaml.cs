using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quiz1
{
    public partial class MainPage : ContentPage
    {
        IList<string> questions = new List<string>();
        IList<string> answers = new List<string>();
        int index = 0;
        private string userAnswer;
        private int correct = 0;
        public MainPage()
        {

            InitializeComponent();
            questions.Add("A is the first letter of the alphabet");
            questions.Add("B is the third letter of the alphabet");
            questions.Add("C is the third letter of the alphabet");
            questions.Add("D is the tenth letter of the alphabet");
            answers.Add("True");
            answers.Add("False");
            answers.Add("True");
            answers.Add("False");
            theLabel.Text = questions[index];
        }
        void answer(object sender, EventArgs e)
        {
            index += 1;
            theLabel.Text = questions[index];
            userAnswer = ((Button) sender).Text.ToString();
            if (userAnswer == answers[index])
            {
                correct += 1;
            }
           
            if (index > questions.Count)
            {
                theLabel.Text = "you got " + correct + " out of " + questions.Count + " right!";
            }
            //maybe add the loop up here for questions?
           
            
        }
    }

}