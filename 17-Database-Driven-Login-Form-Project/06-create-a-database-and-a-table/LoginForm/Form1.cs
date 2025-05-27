using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class loginForm: Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=GLASSMOUND\SQLSERVER2022;Initial Catalog=userLogin;Integrated Security=True;");
            string query = "SELECT * FROM logins WHERE username ='"+usernameTextBox.Text.Trim()+"'AND password ='"+passwordTextBox.Text.Trim()+"'"; // he did not capitalize the 'select'

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                loggedInForm objloggedInForm = new loggedInForm();
                this.Hide();
                objloggedInForm.Show();
                // hides main form if logged in
                // then shows second form
            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
