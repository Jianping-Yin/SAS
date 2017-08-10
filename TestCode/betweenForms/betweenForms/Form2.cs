using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betweenForms
{
	public partial class Form2 : Form
	{
		public string Myval { get; set; }
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Myval = textBox1.Text;
			
		}

		//public void ShowMyDialogBox()
		//{
		//	Form2 testDialog = new Form2();

		//	// Show testDialog as a modal dialog and determine if DialogResult = OK.
		//	if (testDialog.ShowDialog(this) == DialogResult.OK)
		//	{
		//		// Read the contents of testDialog's TextBox.
		//		this.txtResult.Text = testDialog.TextBox1.Text;
		//	}
		//	else
		//	{
		//		this.txtResult.Text = "Cancelled";
		//	}
		//	testDialog.Dispose(); //right conern can not close //You can use this method to display a modal dialog box in your application. When this method is called, the code following it is not executed until after the dialog box is closed. The dialog box can be assigned one of the values of the DialogResult enumeration by assigning it to the DialogResult property of a Button on the form or by setting the DialogResult property of the form in code. This value is then returned by this method. You can use this return value to determine how to process the actions that occurred in the dialog box. For example, if the dialog box was closed and returned the DialogResult.Cancel value through this method, you could prevent code following the call to ShowDialog from executing.
		//}
	}
}
