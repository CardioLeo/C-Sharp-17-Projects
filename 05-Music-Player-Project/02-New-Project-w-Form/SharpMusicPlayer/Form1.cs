using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpMusicPlayer
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // code for browse button, dialog box
            // opens...? dialog box?
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            // have to specify a path; see below
            Player.URL = textBox1.Text; // displays path as text
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // plays the music
            Player.Ctlcontrols.play();
            // what if no music selected?
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // pauses the music
            Player.Ctlcontrols.pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // stops the music
            Player.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // exits application
            Close();
        }
    }
}
