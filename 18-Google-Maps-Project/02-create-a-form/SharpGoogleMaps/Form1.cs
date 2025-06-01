using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpGoogleMaps
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string street = streetTextBox.Text;
            string city = cityTextBox.Text;
            string state = stateTextBox.Text;
            string zipcode = zipcodeTextBox.Text;

            try
            {
                StringBuilder queryData = new StringBuilder();
                queryData.Append("http://maps.google.com/maps?=");
                if (street != string.Empty)
                {
                    queryData.Append(street + ", " + "+ ");
                }
                if (city != string.Empty)
                {
                    queryData.Append(street + ", " + "+ ");
                }
                if (state != string.Empty)
                {
                    queryData.Append(street + ", " + "+ ");
                }
                if (zipcode != string.Empty)
                {
                    queryData.Append(street + ", " + "+ ");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
    }
}
