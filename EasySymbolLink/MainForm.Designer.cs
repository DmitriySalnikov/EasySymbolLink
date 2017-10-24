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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.TB_Source = new System.Windows.Forms.TextBox();
			this.B_Browse_Source = new System.Windows.Forms.Button();
			this.B_Browse_Dest = new System.Windows.Forms.Button();
			this.TB_Dest = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.B_Make = new System.Windows.Forms.Button();
			this.FBD_Source = new System.Windows.Forms.FolderBrowserDialog();
			this.TB_LinkName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.FBD_Dest = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// TB_Source
			// 
			resources.ApplyResources(this.TB_Source, "TB_Source");
			this.TB_Source.Name = "TB_Source";
			// 
			// B_Browse_Source
			// 
			resources.ApplyResources(this.B_Browse_Source, "B_Browse_Source");
			this.B_Browse_Source.Name = "B_Browse_Source";
			this.B_Browse_Source.UseVisualStyleBackColor = true;
			this.B_Browse_Source.Click += new System.EventHandler(this.B_Browse_Source_Click);
			// 
			// B_Browse_Dest
			// 
			resources.ApplyResources(this.B_Browse_Dest, "B_Browse_Dest");
			this.B_Browse_Dest.Name = "B_Browse_Dest";
			this.B_Browse_Dest.UseVisualStyleBackColor = true;
			this.B_Browse_Dest.Click += new System.EventHandler(this.B_Browse_Dest_Click);
			// 
			// TB_Dest
			// 
			resources.ApplyResources(this.TB_Dest, "TB_Dest");
			this.TB_Dest.Name = "TB_Dest";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// B_Make
			// 
			resources.ApplyResources(this.B_Make, "B_Make");
			this.B_Make.Name = "B_Make";
			this.B_Make.UseVisualStyleBackColor = true;
			this.B_Make.Click += new System.EventHandler(this.B_Make_Click);
			// 
			// TB_LinkName
			// 
			resources.ApplyResources(this.TB_LinkName, "TB_LinkName");
			this.TB_LinkName.Name = "TB_LinkName";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TB_LinkName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.B_Make);
			this.Controls.Add(this.B_Browse_Dest);
			this.Controls.Add(this.TB_Dest);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.B_Browse_Source);
			this.Controls.Add(this.TB_Source);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TB_Source;
		private System.Windows.Forms.Button B_Browse_Source;
		private System.Windows.Forms.Button B_Browse_Dest;
		private System.Windows.Forms.TextBox TB_Dest;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button B_Make;
		private System.Windows.Forms.FolderBrowserDialog FBD_Source;
		private System.Windows.Forms.TextBox TB_LinkName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.FolderBrowserDialog FBD_Dest;
	}
}

