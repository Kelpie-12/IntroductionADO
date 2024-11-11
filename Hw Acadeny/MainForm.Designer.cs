namespace Hw_Acadeny
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
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageStudent = new System.Windows.Forms.TabPage();
			this.statusStripStudents = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelStudentCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.cbDirection = new System.Windows.Forms.ComboBox();
			this.cbGroupStudent = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.tabPageGroup = new System.Windows.Forms.TabPage();
			this.tabPageDiscipline = new System.Windows.Forms.TabPage();
			this.tabPageTeacher = new System.Windows.Forms.TabPage();
			this.tabControlMain.SuspendLayout();
			this.tabPageStudent.SuspendLayout();
			this.statusStripStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageStudent);
			this.tabControlMain.Controls.Add(this.tabPageGroup);
			this.tabControlMain.Controls.Add(this.tabPageDiscipline);
			this.tabControlMain.Controls.Add(this.tabPageTeacher);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControlMain.Location = new System.Drawing.Point(0, 0);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(971, 533);
			this.tabControlMain.TabIndex = 0;
			// 
			// tabPageStudent
			// 
			this.tabPageStudent.Controls.Add(this.statusStripStudents);
			this.tabPageStudent.Controls.Add(this.label3);
			this.tabPageStudent.Controls.Add(this.cbDirection);
			this.tabPageStudent.Controls.Add(this.cbGroupStudent);
			this.tabPageStudent.Controls.Add(this.label2);
			this.tabPageStudent.Controls.Add(this.label1);
			this.tabPageStudent.Controls.Add(this.textBoxSearchStudent);
			this.tabPageStudent.Controls.Add(this.dataGridViewStudents);
			this.tabPageStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPageStudent.Location = new System.Drawing.Point(4, 34);
			this.tabPageStudent.Name = "tabPageStudent";
			this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudent.Size = new System.Drawing.Size(963, 495);
			this.tabPageStudent.TabIndex = 0;
			this.tabPageStudent.Text = "Student";
			this.tabPageStudent.UseVisualStyleBackColor = true;
			// 
			// statusStripStudents
			// 
			this.statusStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStudentCount});
			this.statusStripStudents.Location = new System.Drawing.Point(3, 470);
			this.statusStripStudents.Name = "statusStripStudents";
			this.statusStripStudents.Size = new System.Drawing.Size(957, 22);
			this.statusStripStudents.TabIndex = 15;
			this.statusStripStudents.Text = "statusStrip1";
			// 
			// toolStripStatusLabelStudentCount
			// 
			this.toolStripStatusLabelStudentCount.Name = "toolStripStatusLabelStudentCount";
			this.toolStripStatusLabelStudentCount.Size = new System.Drawing.Size(13, 17);
			this.toolStripStatusLabelStudentCount.Text = "0";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(562, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 25);
			this.label3.TabIndex = 14;
			this.label3.Text = "Направление";
			// 
			// cbDirection
			// 
			this.cbDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Location = new System.Drawing.Point(726, 12);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(215, 33);
			this.cbDirection.Sorted = true;
			this.cbDirection.TabIndex = 30;
			this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
			// 
			// cbGroupStudent
			// 
			this.cbGroupStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbGroupStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGroupStudent.FormattingEnabled = true;
			this.cbGroupStudent.Location = new System.Drawing.Point(432, 10);
			this.cbGroupStudent.Name = "cbGroupStudent";
			this.cbGroupStudent.Size = new System.Drawing.Size(101, 33);
			this.cbGroupStudent.TabIndex = 12;
			this.cbGroupStudent.SelectedIndexChanged += new System.EventHandler(this.cbGroupStudent_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(331, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 25);
			this.label2.TabIndex = 11;
			this.label2.Text = "Группа";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 25);
			this.label1.TabIndex = 10;
			this.label1.Text = "Поиск";
			// 
			// textBoxSearchStudent
			// 
			this.textBoxSearchStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSearchStudent.Location = new System.Drawing.Point(104, 15);
			this.textBoxSearchStudent.Name = "textBoxSearchStudent";
			this.textBoxSearchStudent.Size = new System.Drawing.Size(221, 30);
			this.textBoxSearchStudent.TabIndex = 9;
			this.textBoxSearchStudent.TextChanged += new System.EventHandler(this.textBoxSearchStudent_TextChanged);
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.Location = new System.Drawing.Point(8, 51);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.Size = new System.Drawing.Size(947, 436);
			this.dataGridViewStudents.TabIndex = 0;
			// 
			// tabPageGroup
			// 
			this.tabPageGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPageGroup.Location = new System.Drawing.Point(4, 34);
			this.tabPageGroup.Name = "tabPageGroup";
			this.tabPageGroup.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroup.Size = new System.Drawing.Size(963, 495);
			this.tabPageGroup.TabIndex = 1;
			this.tabPageGroup.Text = "Group";
			this.tabPageGroup.UseVisualStyleBackColor = true;
			// 
			// tabPageDiscipline
			// 
			this.tabPageDiscipline.Location = new System.Drawing.Point(4, 34);
			this.tabPageDiscipline.Name = "tabPageDiscipline";
			this.tabPageDiscipline.Size = new System.Drawing.Size(963, 495);
			this.tabPageDiscipline.TabIndex = 2;
			this.tabPageDiscipline.Text = "Discipline";
			this.tabPageDiscipline.UseVisualStyleBackColor = true;
			// 
			// tabPageTeacher
			// 
			this.tabPageTeacher.Location = new System.Drawing.Point(4, 34);
			this.tabPageTeacher.Name = "tabPageTeacher";
			this.tabPageTeacher.Size = new System.Drawing.Size(963, 495);
			this.tabPageTeacher.TabIndex = 3;
			this.tabPageTeacher.Text = "Teacher";
			this.tabPageTeacher.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(971, 533);
			this.Controls.Add(this.tabControlMain);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.tabControlMain.ResumeLayout(false);
			this.tabPageStudent.ResumeLayout(false);
			this.tabPageStudent.PerformLayout();
			this.statusStripStudents.ResumeLayout(false);
			this.statusStripStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabPageStudent;
		private System.Windows.Forms.TabPage tabPageGroup;
		private System.Windows.Forms.TabPage tabPageDiscipline;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.TabPage tabPageTeacher;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbDirection;
		private System.Windows.Forms.ComboBox cbGroupStudent;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSearchStudent;
		private System.Windows.Forms.StatusStrip statusStripStudents;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStudentCount;
	}
}

