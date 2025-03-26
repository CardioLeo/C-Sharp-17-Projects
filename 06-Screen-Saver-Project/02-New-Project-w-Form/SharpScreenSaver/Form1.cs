using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpScreenSaver
{
    public partial class formScreenSaver: Form
    {
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
        }
    }
}
