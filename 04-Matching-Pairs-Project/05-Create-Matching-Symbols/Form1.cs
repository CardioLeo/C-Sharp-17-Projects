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
            "U", "U",
            "g", "g",
            "k", "k",
            "R", "R",
            "7", "7",
            "#", "#",
            "s", "s",
        };
        public Form1()
        {
            InitializeComponent();
        }
    }
}
