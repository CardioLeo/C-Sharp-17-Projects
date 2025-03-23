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
    }
}
