using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpScreenSaver
{
    public partial class formScreenSaver: Form
    {
        List<Image> BGImages = new List<Image>();
        // stores images
        List<BritPic> BritPics = new List<BritPic>();
        // stores objects, will hold position of photos
        Random rand = new Random();

        class BritPic {
            public int PicNum;
            public float X;
            public float Y;
            public float Speed;
            // all public means they can be accessed by any part of the code
        }
        public formScreenSaver()
        {
            InitializeComponent();
        }

        private void formScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void formScreenSaver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            //Close();
            // doesn't work, because too sensitive?
        }

        private void formScreenSaver_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("../../../../../../Images-for-Screensaver-Project/"); // he has merely "pics"

            foreach (string image in images)
            {
                BGImages.Add(new Bitmap(image));
            }
            for (int i = 0; i < 50; i++)
            {
                BritPic mp = new BritPic();
                mp.PicNum = i % BGImages.Count;
                mp.X = rand.Next(0, Width);
                mp.Y = rand.Next(0, Height);

                BritPics.Add(mp);
            }
        }
    }
}
