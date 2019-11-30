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
		const string none_string = "(none)";
		string source_path = "";
		string dest_path = "";
		bool allow_drop = false;
		bool is_file_link = true;

		public MainForm()
		{
			InitializeComponent();

			Icon = Properties.Resources.SmallIcon;

			l_source_path.Text = none_string;
			l_dest_path.Text = none_string;

			btn_browse_dest.Enabled = false;
		}

		private void set_source_path(string path, bool is_file)
		{
			is_file_link = is_file;
			source_path = l_source_path.Text = path;
			btn_browse_dest.Enabled = true;

			if (is_file)
			{
				tb_link_name.Text = Path.GetFileName(source_path);
			}
			else
			{
				tb_link_name.Text = source_path.Split(Path.DirectorySeparatorChar).Last();

				if (tb_link_name.Text == "" && source_path == Path.GetPathRoot(source_path))
				{
					tb_link_name.Text = source_path.Replace(":" + Path.DirectorySeparatorChar, "");
				}
			}
		}

		private void l_dest_path_Click(object sender, EventArgs e)
		{
			l_dest_path.Text = none_string;
			dest_path = "";
		}

		private void btn_browse_source_folder_Click(object sender, EventArgs e)
		{
			if (FBD_Source.ShowDialog() == DialogResult.OK)
			{
				set_source_path(FBD_Source.SelectedPath, false);
			}
		}

		private void btn_browse_source_file_Click(object sender, EventArgs e)
		{
			if (OFD_Source.ShowDialog() == DialogResult.OK)
			{
				set_source_path(OFD_Source.FileName, true);
			}
		}

		private void btn_browse_dest_Click(object sender, EventArgs e)
		{
			FBD_Dest.SelectedPath = dest_path == "" ? (is_file_link ? Path.GetDirectoryName(source_path) : source_path) : dest_path;

			if (FBD_Dest.ShowDialog() == DialogResult.OK)
			{
				dest_path = l_dest_path.Text = FBD_Dest.SelectedPath;
			}
		}

		private void btn_make_Click(object sender, EventArgs e)
		{
			String name = tb_link_name.Text;

			bool existSrc = false;
			bool existDest = false;
			bool existLink = false;

			String srcPath = "";
			String destPath = "";

			try
			{
				srcPath = "\"" + source_path + "\"";

				if (is_file_link)
				{
					existSrc = File.Exists(source_path);
				}
				else
				{
					existSrc = Directory.Exists(source_path);
				}
			}
			catch
			{
			}

			try
			{
				if (dest_path.Last() == '\\')
				{
					destPath = "\"" + dest_path + name + "\"";
				}
				else
				{
					destPath = "\"" + dest_path + "/" + name + "\"";
				}

				existDest = Directory.Exists(dest_path);
			}
			catch
			{
			}

			try
			{
				String p = "";
				if (dest_path.Last() == '\\')
				{
					p = dest_path + name;
				}
				else
				{
					p = dest_path + "/" + name;

				}

				if (is_file_link)
				{
					existLink = File.Exists(p);
				}
				else
				{
					existLink = Directory.Exists(p);
				}
			}
			catch
			{
			}

			String res = "/c mklink " + (is_file_link ? "" : "/j ") + destPath + " " + srcPath;
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

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			if (allow_drop)
			{
				string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

				if (Path.GetExtension(path) == ".lnk")
				{
					string lnk_path = LNKResolver.ResolveShortcut(path);

					if (lnk_path != "")
						path = lnk_path;
				}

				bool is_file = File.Exists(path);
				set_source_path(path, is_file);
			}
		}

		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) && ((string[])e.Data.GetData(DataFormats.FileDrop)).Length == 1)
			{
				allow_drop = true;
				e.Effect = DragDropEffects.Link;
			}
			else
			{
				allow_drop = false;
				e.Effect = DragDropEffects.None;
			}
		}

		private void MainForm_DragLeave(object sender, EventArgs e)
		{

		}
	}
}
