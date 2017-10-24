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
				TB_LinkName.Text = (new Uri(FBD_Source.SelectedPath)).Segments.Last();
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
			String name = TB_LinkName.Text;

			bool existSrc = false;
			bool existDest = false;
			bool existLink = false;

			String srcPath = "";
			String destPath = "";

			try
			{
				srcPath = "\"" + TB_Source.Text + "\"";
				existSrc = Directory.Exists(TB_Source.Text);
			}
			catch
			{
			}
			try
			{
				if (TB_Dest.Text.Last() == '\\')
				{
					destPath = "\"" + TB_Dest.Text + name + "\"";
				}
				else
				{
					destPath = "\"" + TB_Dest.Text + "/" + name + "\"";

				}
				existDest = Directory.Exists(TB_Dest.Text);
			}
			catch
			{
			}
			try
			{
				String p = "";
				if (TB_Dest.Text.Last() == '\\')
				{
					p = TB_Dest.Text + name;
				}
				else
				{
					p = TB_Dest.Text + "/" + name;

				}
				existLink = Directory.Exists(p);
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
