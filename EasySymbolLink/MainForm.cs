using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EasySymbolLink
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();


		}

		private void B_Browse_Source_Click(object sender, EventArgs e)
		{
			if (FBD_Source.ShowDialog() == DialogResult.OK)
			{
				TB_Source.Text = FBD_Source.SelectedPath;
			}
		}

		private void B_Browse_Dest_Click(object sender, EventArgs e)
		{
			if (FBD_Dest.ShowDialog() == DialogResult.OK)
			{
				TB_Dest.Text = FBD_Dest.SelectedPath;
			}
		}

		private void B_Make_Click(object sender, EventArgs e)
		{
			Uri srcURI = null;
			Uri destURI = null;
			String name = TB_LinkName.Text;

			bool existSrc = false;
			bool existDest = false;
			bool existLink = false;

			String srcPath = "";
			String destPath = "";

			try
			{
				srcURI = new Uri(TB_Source.Text);
				srcPath = "\"" + srcURI.AbsolutePath + "\"";
				existSrc = Directory.Exists(srcURI.AbsolutePath);
			}
			catch
			{
			}
			try
			{
				destURI = new Uri(TB_Dest.Text);
				destPath = "\"" + destURI.AbsolutePath + "/" + name + "\"";
				existDest = Directory.Exists(destURI.AbsolutePath);
			}
			catch
			{
			}
			try
			{
				existLink = Directory.Exists(destURI.AbsolutePath + "/" + name);
			}
			catch
			{
			}

			String res = "/c mklink /j " + destPath + " " + srcPath;
			bool isError = false;

			if (existSrc && existDest && !existLink && name != "")
			{
				Process.Start("cmd.exe", res);
			}
			else
			{
				isError = true;
			}

			if (isError)
			{
				String error = "Please fix the following errors:\n";
				if (!existSrc)
				{
					error += "\nSource Path does not exist!";
				}
				if (!existDest)
				{
					error += "\nDestination path does not exist!";
				}
				if (name == "")
				{
					error += "\nName not specified!";
				}
				if (existLink)
				{
					error += "\nLink already exist!";
				}
				MessageBox.Show(error);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
