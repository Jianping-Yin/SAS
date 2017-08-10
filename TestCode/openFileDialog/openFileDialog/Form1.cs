using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openFileDialog
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "open File Dialog";
			ofd.InitialDirectory = @"C:\csvAnalysis";
			ofd.Filter = "csv file (*.csv)|*.csv";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				textBox1.Text = ofd.FileName;
			}

			//	string filename = "";

			//OpenFileDialog ofd = new OpenFileDialog();
			//DialogResult dr = ofd.ShowDialog();

			//if (dr == DialogResult.OK)
			//{
			//	filename = ofd.FileName;
			//}
			//if (filename != "")


			//string folderpath = "";
			//FolderBrowserDialog fbd = new FolderBrowserDialog();
			//DialogResult dr = fbd.ShowDialog();

			//if (dr == DialogResult.OK)
			//{
			//	folderpath = fbd.SelectedPath;
			//}

			//if (folderpath != "")


		}
	}
}
