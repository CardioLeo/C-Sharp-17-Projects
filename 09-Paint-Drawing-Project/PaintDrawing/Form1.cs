using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintDrawing
{
    public partial class Form1: Form
    {
        // variables available to everything we will code:
        // creates bitmap which user will draw on
        Bitmap bmp = new Bitmap(1024, 768);
        // var for default pen color and size
        Pen p = new Pen(Color.Black, 5);
        // bool var for whether pen is drawing or not
        bool drawing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // mouse down event, originally
            // name changed, because he wants it used by mouse up as well. huh

            // when MouseClick == true
            // check drawing bool;
            // if drawing bool == true
            // make drawing bool false;
            // else, if false, make true
            // (I'm adding these comments because initially this seemed completely
            // redundant until I realized that it was dependent on the event handler)
            if (drawing)
                drawing = false;
            else
                drawing = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp); // passes essentially global var bmp to this method
                g.DrawEllipse(p, e.X, e.Y, 3, 1); // the actual command to draw
                pictureBox1.Image = bmp; // draws the whole image now that it has been drawn onto
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // red button
            p.Color = Color.Red;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // blue button
            p.Color = Color.Blue;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // green button
            p.Color = Color.Green;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // purple button
            p.Color = Color.Purple;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // lime button
            p.Color = Color.Lime;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // black button
            p.Color = Color.Black;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            // white button
            p.Color = Color.White;
        }
    }
}
