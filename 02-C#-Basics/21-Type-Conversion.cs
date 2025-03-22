namespace conversions
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void okButton_Click(object sender, EventArgs e)
		{
			int i;
			i = Convert.ToInt32("Hello World!");
		}
	}
}

// this is just the code he wrote, so I could follow along without creating a whole new project
