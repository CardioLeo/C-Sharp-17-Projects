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
    }
}
