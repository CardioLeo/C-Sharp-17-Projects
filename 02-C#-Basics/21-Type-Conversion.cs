namespace conversions
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void okButton_Click(object sender, EventArgs e)
		{
			// from video 21
			int i;
			i = Convert.ToInt32("Hello World!");
			// below begins coding along with video 22
			double k = 3.5;
			int j = (int)k; // this will truncate the value of k when saving into j
			// resultLabel.Text = i; // use helper method to convert
			resultLabel.Text = i.ToString(); // should output 3, truncated

			// next he comments out all of the above
			
			string i2 = inputTextBox.Text;
			int j2 = int.Parse(i); // will only work when the string looks exactly like a number!
			// need rigorous testing and checks!
			int k2 = j2 + 1; // misread the 1 as an i, and figured he meant i2
			resultLabel.Text = k2.ToString();

			// does he not use i2?
		}
	}
}

// this is just the code he wrote, so I could follow along without creating a whole new project
