using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurencyConverter
{
    public partial class currencyConverterForm: Form
    {
        public currencyConverterForm()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/finance/markets/currencies?hl=en");
        }
    }
}
