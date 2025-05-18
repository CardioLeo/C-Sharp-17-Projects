using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public void startQuiz()
        {
            addNum1 = randomizer.Next(51);
            addNum2 = randomizer.Next(51);
            plusLeftLabel.Text = addNum1.ToString();
            plusRightLabel.Text = addNum2.ToString();

            sumSelector.Value = 0;

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
                MessageBox.Show("You didn't finish in time.", "Sorry...");
                sumSelector.Value = addNum1 + addNum2;
                // differenceSelector.Value = minusNum1 - minusNum2;
                // productSelector.Value = timesNum1 * timesNum2;
                // quotientSelector.Value = divisionNum1 / divisionNum2;
                startButton.Enabled = true;
            }
        }
    }
}
