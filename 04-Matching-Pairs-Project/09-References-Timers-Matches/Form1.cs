using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// my code here is based on the instructor's code, and I'm learning a lot;
// but I also feel like this could be made to be more readable,
// if nothing else by good use of comments

namespace MatchingPairsGame
{
    public partial class Form1: Form
    {
        // from video 09 of section 04; preping references
        // 
        Label firstClicked = null;
        Label secondClicked = null;
        // int matchFound = 0;

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
            if (timer1.Enabled == true)
            {
                // timer starts running only after two non-matching icons shown to player
                return; // ignore any clicks if timer is running
            }
            // a stub, an empty method for the event handler
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                // okay; this actually is important! I was wrong
                // it just didn't make any difference earlier

                // clickedLabel.ForeColor = Color.Black;
                // now he says we should comment this out
                // to test the firstClicked etc vars
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                    // by returning here, it doesn't set the timer, and the timer doesn't call the tick (or reset) function
                    // this means that the colors should stay black, and the icons should remain visible; smart
                }

                timer1.Start(); // will call timer1_Tick();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // I don't like this name, timer1_Tick, because it would make more sense
            // as, say, "reset_seen_icons()" or something like that
            // before any click, timer stops - he says
            timer1.Stop();
            // makes them invisible (but they're already invisible...?)
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            // resets variable again to be clicked on
            firstClicked = null;
            secondClicked = null;
        }

        // check whether the game has been completed by all icon images being matched
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
        }
    }
}
