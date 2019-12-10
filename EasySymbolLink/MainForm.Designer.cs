namespace EasySymbolLink
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.FBD_Source = new System.Windows.Forms.FolderBrowserDialog();
			this.FBD_Dest = new System.Windows.Forms.FolderBrowserDialog();
			this.btn_browse_dest = new System.Windows.Forms.Button();
			this.btn_browse_source_file = new System.Windows.Forms.Button();
			this.btn_browse_source_folder = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tb_link_name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_make = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.l_source_path = new System.Windows.Forms.Label();
			this.l_dest_path = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.OFD_Source = new System.Windows.Forms.OpenFileDialog();
			this.SFD_Dest = new System.Windows.Forms.SaveFileDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.l_error = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_browse_dest
			// 
			resources.ApplyResources(this.btn_browse_dest, "btn_browse_dest");
			this.btn_browse_dest.Name = "btn_browse_dest";
			this.toolTip1.SetToolTip(this.btn_browse_dest, resources.GetString("btn_browse_dest.ToolTip"));
			this.btn_browse_dest.UseVisualStyleBackColor = true;
			this.btn_browse_dest.Click += new System.EventHandler(this.btn_browse_dest_Click);
			// 
			// btn_browse_source_file
			// 
			resources.ApplyResources(this.btn_browse_source_file, "btn_browse_source_file");
			this.btn_browse_source_file.Name = "btn_browse_source_file";
			this.btn_browse_source_file.UseVisualStyleBackColor = true;
			this.btn_browse_source_file.Click += new System.EventHandler(this.btn_browse_source_file_Click);
			// 
			// btn_browse_source_folder
			// 
			resources.ApplyResources(this.btn_browse_source_folder, "btn_browse_source_folder");
			this.btn_browse_source_folder.Name = "btn_browse_source_folder";
			this.btn_browse_source_folder.UseVisualStyleBackColor = true;
			this.btn_browse_source_folder.Click += new System.EventHandler(this.btn_browse_source_folder_Click);
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.tb_link_name, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.btn_make, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.btn_browse_dest, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.l_source_path, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.l_dest_path, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.l_error, 0, 10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// tb_link_name
			// 
			resources.ApplyResources(this.tb_link_name, "tb_link_name");
			this.tb_link_name.Name = "tb_link_name";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// btn_make
			// 
			resources.ApplyResources(this.btn_make, "btn_make");
			this.btn_make.Name = "btn_make";
			this.btn_make.UseVisualStyleBackColor = true;
			this.btn_make.Click += new System.EventHandler(this.btn_make_Click);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// l_source_path
			// 
			resources.ApplyResources(this.l_source_path, "l_source_path");
			this.l_source_path.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.l_source_path.Name = "l_source_path";
			// 
			// l_dest_path
			// 
			resources.ApplyResources(this.l_dest_path, "l_dest_path");
			this.l_dest_path.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.l_dest_path.Name = "l_dest_path";
			this.l_dest_path.Click += new System.EventHandler(this.l_dest_path_Click);
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.btn_browse_source_file, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btn_browse_source_folder, 0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// l_error
			// 
			resources.ApplyResources(this.l_error, "l_error");
			this.l_error.Name = "l_error";
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.DragLeave += new System.EventHandler(this.MainForm_DragLeave);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FolderBrowserDialog FBD_Source;
		private System.Windows.Forms.FolderBrowserDialog FBD_Dest;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox tb_link_name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_make;
		private System.Windows.Forms.Button btn_browse_dest;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_browse_source_folder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label l_source_path;
		private System.Windows.Forms.Label l_dest_path;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btn_browse_source_file;
		private System.Windows.Forms.OpenFileDialog OFD_Source;
		private System.Windows.Forms.SaveFileDialog SFD_Dest;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label l_error;
	}
}

