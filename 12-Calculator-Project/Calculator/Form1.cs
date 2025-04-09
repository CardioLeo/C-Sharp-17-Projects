using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0")
            {
                resultBox.Clear();
            }

            Button button = (Button)sender;
            resultBox.Text = resultBox.Text + button.Text;
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
            resultBox.Text = "0";
        }
    }
}
