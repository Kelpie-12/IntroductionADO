namespace Academy
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageStudent = new System.Windows.Forms.TabPage();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.tabPageDisciplines = new System.Windows.Forms.TabPage();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.statusStripStudents = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelStudentCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbGroupStudent = new System.Windows.Forms.ComboBox();
			this.cbDirection = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControlMain.SuspendLayout();
			this.tabPageStudent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			this.statusStripStudents.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageStudent);
			this.tabControlMain.Controls.Add(this.tabPageGroups);
			this.tabControlMain.Controls.Add(this.tabPageDisciplines);
			this.tabControlMain.Controls.Add(this.tabPageTeachers);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControlMain.Location = new System.Drawing.Point(0, 0);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(894, 471);
			this.tabControlMain.TabIndex = 0;
			// 
			// tabPageStudent
			// 
			this.tabPageStudent.Controls.Add(this.label3);
			this.tabPageStudent.Controls.Add(this.cbDirection);
			this.tabPageStudent.Controls.Add(this.cbGroupStudent);
			this.tabPageStudent.Controls.Add(this.label2);
			this.tabPageStudent.Controls.Add(this.label1);
			this.tabPageStudent.Controls.Add(this.textBoxSearchStudent);
			this.tabPageStudent.Controls.Add(this.statusStripStudents);
			this.tabPageStudent.Controls.Add(this.dataGridViewStudents);
			this.tabPageStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPageStudent.Location = new System.Drawing.Point(4, 33);
			this.tabPageStudent.Name = "tabPageStudent";
			this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudent.Size = new System.Drawing.Size(886, 434);
			this.tabPageStudent.TabIndex = 0;
			this.tabPageStudent.Text = "Students";
			this.tabPageStudent.UseVisualStyleBackColor = true;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPageGroups.Location = new System.Drawing.Point(4, 33);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(789, 434);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// tabPageDisciplines
			// 
			this.tabPageDisciplines.Location = new System.Drawing.Point(4, 34);
			this.tabPageDisciplines.Name = "tabPageDisciplines";
			this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisciplines.Size = new System.Drawing.Size(789, 434);
			this.tabPageDisciplines.TabIndex = 2;
			this.tabPageDisciplines.Text = "Disciplines";
			this.tabPageDisciplines.UseVisualStyleBackColor = true;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 34);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Size = new System.Drawing.Size(789, 434);
			this.tabPageTeachers.TabIndex = 3;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.Location = new System.Drawing.Point(8, 66);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.Size = new System.Drawing.Size(873, 340);
			this.dataGridViewStudents.TabIndex = 0;
			// 
			// statusStripStudents
			// 
			this.statusStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStudentCount});
			this.statusStripStudents.Location = new System.Drawing.Point(3, 409);
			this.statusStripStudents.Name = "statusStripStudents";
			this.statusStripStudents.Size = new System.Drawing.Size(880, 22);
			this.statusStripStudents.TabIndex = 1;
			this.statusStripStudents.Text = "statusStrip1";
			// 
			// toolStripStatusLabelStudentCount
			// 
			this.toolStripStatusLabelStudentCount.Name = "toolStripStatusLabelStudentCount";
			this.toolStripStatusLabelStudentCount.Size = new System.Drawing.Size(13, 17);
			this.toolStripStatusLabelStudentCount.Text = "0";
			// 
			// textBoxSearchStudent
			// 
			this.textBoxSearchStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSearchStudent.Location = new System.Drawing.Point(97, 18);
			this.textBoxSearchStudent.Name = "textBoxSearchStudent";
			this.textBoxSearchStudent.Size = new System.Drawing.Size(191, 29);
			this.textBoxSearchStudent.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Поиск";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(304, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Группа";
			// 
			// cbGroupStudent
			// 
			this.cbGroupStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbGroupStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGroupStudent.FormattingEnabled = true;
			this.cbGroupStudent.Location = new System.Drawing.Point(383, 15);
			this.cbGroupStudent.Name = "cbGroupStudent";
			this.cbGroupStudent.Size = new System.Drawing.Size(101, 32);
			this.cbGroupStudent.TabIndex = 6;
			// 
			// cbDirection
			// 
			this.cbDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Location = new System.Drawing.Point(652, 15);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(215, 32);
			this.cbDirection.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(503, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "Направление";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 471);
			this.Controls.Add(this.tabControlMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Academy";
			this.tabControlMain.ResumeLayout(false);
			this.tabPageStudent.ResumeLayout(false);
			this.tabPageStudent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			this.statusStripStudents.ResumeLayout(false);
			this.statusStripStudents.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabPageStudent;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageDisciplines;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.StatusStrip statusStripStudents;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStudentCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbDirection;
		private System.Windows.Forms.ComboBox cbGroupStudent;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSearchStudent;
	}
}

