using System;
using System.Windows.Forms;

namespace IMEChange
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		protected override void OnLoad(EventArgs e)
		{
			SendKeys.Send("+(%)");
			Close();
		}
	}
}
