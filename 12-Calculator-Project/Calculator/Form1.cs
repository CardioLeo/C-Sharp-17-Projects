using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double resultValue = 0;
        double temp1 = 0;
        double temp2 = 0;
        String operatorClicked = "";
        bool isOperatorClicked = false;
        bool containsDecimalPoint= false;
        public Form1()
        {
            InitializeComponent();
        }

        private void resetTempValues()
        {
            temp1 = 0;
            temp2 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void discoverDecimalPoint(string testString)
        {
            if (!testString.Contains("."))
            {
                containsDecimalPoint = true;
            }
            else {
                containsDecimalPoint = false;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            discoverDecimalPoint(resultBox.Text);
            if (resultBox.Text == "0")
            {
                resultBox.Clear();
            }
            if (temp1 == 0)
            {
                resultBox.Text = resultBox.Text + button.Text;
                temp1 = Double.Parse(resultBox.Text);
            } else if (temp1 != 0 && isOperatorClicked) {
                temp2 = Double.Parse(button.Text);
            }

            //if (isOperatorClicked)
            //{
             //  temp1 = Double.Parse(resultBox.Text);
            //    temp2 = Double.Parse(button.Text);
            //    // resultBox.Text = resultBox.Text + button.Text;
            //}
            //else if (containsDecimalPoint)
            //{
                // resultBox.Text = resultBox.Text + button.Text;
            //}
            // next line important because otherwise first number isn't added to textBox
            resultBox.Text = resultBox.Text + button.Text;
            isOperatorClicked = false;            
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // he doesn't have this next line; makes sense
            // resultBox.Clear();
            resultBox.Text = "0";
            resultValue = 0;
            resetTempValues();
        }

        private void operator_Click(object sender, EventArgs e)
        {
            isOperatorClicked = true;
            // "makes it access a single method, it's easier, you write less code"
            // because abstraction

            // as it stands this is basically the same code as button_Click
            Button button = (Button)sender;

            if (temp1 != 0)
            {
                // equalsButton.PerformClick();
                operatorClicked = button.Text;
            } else {
                operatorClicked = button.Text;
                resultValue = Double.Parse(resultBox.Text);
            }
            isOperatorClicked = true;
            operatorClicked = button.Text;
            resultValue = Double.Parse(resultBox.Text); // converts from string to double
            // resultBox.Text = resultBox.Text + button.Text;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            // resultValue = double.Parse(Convert.ToString(resultBox.Text));
            // double tempValue = 0;
            switch (operatorClicked)
            {
                case "+":
                    resultValue = temp1 + temp2;
                    resultBox.Clear();
                    resultBox.Text = Convert.ToString(temp1) + "+" + Convert.ToString(temp2);
                    resetTempValues();
                    // resultBox.Text = resultValue.ToString();
                    break;
                case "-":
                    resultValue = temp1 - temp2;
                    resultBox.Clear();
                    resultBox.Text = resultValue.ToString();
                    resetTempValues();
                    break;
                case "*":
                    resultValue = temp1 * temp2;
                    resultBox.Clear();
                    resultBox.Text = resultValue.ToString();
                    resetTempValues();
                    break;
                case "/":
                    resultValue = temp1 / temp2;
                    resultBox.Clear();
                    resultBox.Text = resultValue.ToString();
                    resetTempValues();
                    break;
                default:
                    break;
                    
            }
            isOperatorClicked = false;
            resultValue = 0;
        }
    }
}
