using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
	public partial class Identity : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void okButton_Click(object sender, EventArgs e)
        {
			string age = ageBox.Text;
			string savingsGoal = savingsGoalBox.Text;

			string result = "Hello, you said your age is " + age + " and that your savings goals are to save " + savingsGoal + " in dollars.";

			resultLabel.Text = result;
        }
    }
}