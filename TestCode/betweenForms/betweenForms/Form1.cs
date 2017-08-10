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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 f = new Form2();
			if (f.ShowDialog() == DialogResult.OK)   //open another form, 
			{
				textBox1.Text = f.Myval;
			}
		}
	}
}
