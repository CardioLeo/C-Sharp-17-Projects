using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsQuiz
{
    public partial class Form1: Form
    {
        Random randomizer = new Random();
        int addNum1;
        int addNum2;
        int subNum1;
        int subNum2;
        int multNum1;
        int multNum2;
        int divNum1;
        int divNum2;

        bool addCorrect;
        bool subCorrect;
        bool multCorrect;
        bool divCorrect;

        bool answersWereSuccessful;

        int clock = 30;

        // he has all of this in one function
        // I'm going to separate it out...

        public void additionGenerator()
        {
            addNum1 = randomizer.Next(51);
            addNum2 = randomizer.Next(51);
            plusLeftLabel.Text = addNum1.ToString();
            plusRightLabel.Text = addNum2.ToString();

            sumSelector.Value = 0;
        }
        public void subtractionGenerator()
        {
            subNum1 = randomizer.Next(51);
            subNum2 = randomizer.Next(subNum1);
            minusLeftLabel.Text = subNum1.ToString();
            minusRightLabel.Text = subNum2.ToString();

            differenceSelector.Value = 0;
        }
        public void multiplicationGenerator()
        {
            multNum1 = randomizer.Next(13);
            multNum2 = randomizer.Next(13);
            timesLeftLabel .Text = multNum1.ToString();
            timesRightLabel.Text = multNum2.ToString();

            productSelector.Value = 0;
        }
        public void divisionGenerator()
        {
            divNum1 = randomizer.Next(51);
            divNum2 = randomizer.Next(divNum1);
            if (divNum1 == 0)
            {
                divNum1++;
            }
            divNum2 = randomizer.Next(divNum1);
            if (divNum2 == 0)
            {
                divNum2++;
            }
            divisionLeftLabel.Text = divNum1.ToString();
            divisionRightLabel.Text = divNum2.ToString();

            quotientSelector.Value = 0;
        }

        private void checkAddAnswer()
        {
            if (addNum1 + addNum2 == sumSelector.Value)
            {
                addCorrect = true;
            }
            else
            {
                addCorrect = false;
            }
        }

        private void checkSubAnswer()
        {
            if (subNum1 - subNum2 == differenceSelector.Value)
            {
                subCorrect = true;
            }
            else
            {
                subCorrect = false;
            }
        }

        private void checkMultAnswer()
        {
            if (multNum1 * multNum2 == productSelector.Value)
            {
                multCorrect = true;
            }
            else
            {
                multCorrect = false;
            }
        }

        private void checkDivAnswer()
        {
            if (divNum1 / divNum2 == quotientSelector.Value)
            {
                divCorrect = true;
            }
            else
            {
                divCorrect = false;
            }
        }

        private bool checkAnswers()
        {
            checkAddAnswer();
            checkSubAnswer();
            checkMultAnswer();
            checkDivAnswer();
            if (addCorrect && subCorrect && multCorrect && divCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void clockReset()
        {
            clock = 30;
        }

        public void startQuiz()
        {
            additionGenerator();
            subtractionGenerator();
            multiplicationGenerator();
            divisionGenerator();
            timer1.Start();
        }

        public void announceSuccessfulAnswers()
        {
            answersWereSuccessful = checkAnswers();
            if (answersWereSuccessful)
            {
                timer1.Stop();
                MessageBox.Show("Good Job! You figured out all the answers!", "Congratulations!");
                clockReset();
                startButton.Enabled = true;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clock > 0)
            {
                // Display the new time left
                // by updating the Time Left label
                clock = clock - 1;
                timeLabel.Text = clock + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer,
                // show a MessageBox, and fill in the answers
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                announceSuccessfulAnswers();
                if (!answersWereSuccessful)
                {
                    MessageBox.Show("You didn't finish in time.", "Sorry...");
                }
                sumSelector.Value = addNum1 + addNum2;
                differenceSelector.Value = subNum1 - subNum2;
                productSelector.Value = multNum1 * multNum2;
                quotientSelector.Value = divNum1 / divNum2;

                startButton.Enabled = true;
                clockReset();
            }
        }

        private void checkAnswersButton_Click(object sender, EventArgs e)
        {
            announceSuccessfulAnswers();
            if (!answersWereSuccessful)
            {
                MessageBox.Show("Not this time! Keep trying!", "Not yet!");
            }
        }

        private void answerEnter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            // his says answer_Enter **shrug**
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
