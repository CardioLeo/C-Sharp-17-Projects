using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void cboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // if enter key is pressed...
                // go to the text in the combo box
                webBrowser1.Navigate(cboLocation.Text);
            }
        }

        // Visual Studio is kind of stupid about naming things
        // but immediately below is the btnBackward_Click function
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        // "go-to ->" button code follows next ("btnGoTo")
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cboLocation.Text);
        }

        // code to update form1 title when new web page loaded
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "Sharp Web Browser - " + webBrowser1.DocumentTitle;
        }
    }
}
