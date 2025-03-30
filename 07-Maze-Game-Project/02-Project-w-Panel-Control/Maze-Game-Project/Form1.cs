using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game_Project
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            // writing code to finish game here

            // winning message displayed here:
            MessageBox.Show("Congratulations! You won!");

            // ends game:
            Close();
        }
    }
}
