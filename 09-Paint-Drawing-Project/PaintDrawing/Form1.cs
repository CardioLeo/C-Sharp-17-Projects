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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

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
    }
}
