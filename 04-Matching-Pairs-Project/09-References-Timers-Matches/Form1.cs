using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingPairsGame
{
    public partial class Form1: Form
    {
        // from video 09 of section 04; preping references
        // 
        Label firstClicked = null;
        Label secondClicked = null;

        // create random object to generate random shapes, or icons
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!",
            "u", "u", // U and u are fine
            "U", "U", // don't use lower case g, it's a huge square, too big
            "k", "k",
            "R", "R",
            "7", "7",
            "#", "#",
            "s", "s",
        };
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];

                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label_click(object sender, EventArgs e)
        {
            // a stub, an empty method for the event handler
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                //if (clickedLabel.ForeColor == Color.Black)
                //return;
                // I commented out the above two lines
                // because I wasn't sure they actually did anything
                // for him... not yet, anyways
                // yeah; uncommented them and tested them and it doesn't change anything substantially

                // clickedLabel.ForeColor = Color.Black;
                // now he says we should comment this out
                // to test the firstClicked etc vars
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
            }
        }
    }
}
