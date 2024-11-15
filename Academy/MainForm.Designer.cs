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
			this.label3 = new System.Windows.Forms.Label();
			this.cbDirection = new System.Windows.Forms.ComboBox();
			this.cbGroupStudent = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
			this.btnAddGroup = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.cbDirectionOnGroup = new System.Windows.Forms.ComboBox();
			this.tabPageDisciplines = new System.Windows.Forms.TabPage();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.statusStripStudents = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelStudentCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControlMain.SuspendLayout();
			this.tabPageStudent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
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
			this.tabControlMain.Size = new System.Drawing.Size(1066, 449);
			this.tabControlMain.TabIndex = 0;
			this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
			// 
			// tabPageStudent
			// 
			this.tabPageStudent.Controls.Add(this.label3);
			this.tabPageStudent.Controls.Add(this.cbDirection);
			this.tabPageStudent.Controls.Add(this.cbGroupStudent);
			this.tabPageStudent.Controls.Add(this.label2);
			this.tabPageStudent.Controls.Add(this.label1);
			this.tabPageStudent.Controls.Add(this.textBoxSearchStudent);
			this.tabPageStudent.Controls.Add(this.dataGridViewStudents);
			this.tabPageStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPageStudent.Location = new System.Drawing.Point(4, 33);
			this.tabPageStudent.Name = "tabPageStudent";
			this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudent.Size = new System.Drawing.Size(1058, 412);
			this.tabPageStudent.TabIndex = 0;
			this.tabPageStudent.Text = "Students";
			this.tabPageStudent.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(654, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "Направление";
			// 
			// cbDirection
			// 
			this.cbDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Location = new System.Drawing.Point(803, 6);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(215, 32);
			this.cbDirection.TabIndex = 7;
			// 
			// cbGroupStudent
			// 
			this.cbGroupStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbGroupStudent.FormattingEnabled = true;
			this.cbGroupStudent.Location = new System.Drawing.Point(534, 6);
			this.cbGroupStudent.Name = "cbGroupStudent";
			this.cbGroupStudent.Size = new System.Drawing.Size(101, 32);
			this.cbGroupStudent.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(455, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Группа";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Поиск";
			// 
			// textBoxSearchStudent
			// 
			this.textBoxSearchStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSearchStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBoxSearchStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.textBoxSearchStudent.Location = new System.Drawing.Point(148, 11);
			this.textBoxSearchStudent.Name = "textBoxSearchStudent";
			this.textBoxSearchStudent.Size = new System.Drawing.Size(191, 29);
			this.textBoxSearchStudent.TabIndex = 2;
			this.textBoxSearchStudent.TextChanged += new System.EventHandler(this.textBoxSearchStudent_TextChanged);
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.Location = new System.Drawing.Point(8, 46);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.Size = new System.Drawing.Size(918, 363);
			this.dataGridViewStudents.TabIndex = 0;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
			this.tabPageGroups.Controls.Add(this.btnAddGroup);
			this.tabPageGroups.Controls.Add(this.label5);
			this.tabPageGroups.Controls.Add(this.label4);
			this.tabPageGroups.Controls.Add(this.tbSearch);
			this.tabPageGroups.Controls.Add(this.cbDirectionOnGroup);
			this.tabPageGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabPageGroups.Location = new System.Drawing.Point(4, 33);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(1058, 412);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// dataGridViewGroups
			// 
			this.dataGridViewGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGroups.Location = new System.Drawing.Point(10, 65);
			this.dataGridViewGroups.Name = "dataGridViewGroups";
			this.dataGridViewGroups.Size = new System.Drawing.Size(1042, 361);
			this.dataGridViewGroups.TabIndex = 5;
			// 
			// btnAddGroup
			// 
			this.btnAddGroup.AutoSize = true;
			this.btnAddGroup.Location = new System.Drawing.Point(898, 6);
			this.btnAddGroup.Name = "btnAddGroup";
			this.btnAddGroup.Size = new System.Drawing.Size(151, 34);
			this.btnAddGroup.TabIndex = 4;
			this.btnAddGroup.Text = "Add new group";
			this.btnAddGroup.UseVisualStyleBackColor = true;
			this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(382, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(219, 24);
			this.label5.TabIndex = 3;
			this.label5.Text = "Направление обучения";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 24);
			this.label4.TabIndex = 2;
			this.label4.Text = "Поиск по имени";
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(165, 11);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(211, 29);
			this.tbSearch.TabIndex = 1;
			// 
			// cbDirectionOnGroup
			// 
			this.cbDirectionOnGroup.FormattingEnabled = true;
			this.cbDirectionOnGroup.Location = new System.Drawing.Point(609, 8);
			this.cbDirectionOnGroup.Name = "cbDirectionOnGroup";
			this.cbDirectionOnGroup.Size = new System.Drawing.Size(271, 32);
			this.cbDirectionOnGroup.TabIndex = 0;
			// 
			// tabPageDisciplines
			// 
			this.tabPageDisciplines.Location = new System.Drawing.Point(4, 33);
			this.tabPageDisciplines.Name = "tabPageDisciplines";
			this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisciplines.Size = new System.Drawing.Size(1058, 412);
			this.tabPageDisciplines.TabIndex = 2;
			this.tabPageDisciplines.Text = "Disciplines";
			this.tabPageDisciplines.UseVisualStyleBackColor = true;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 33);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Size = new System.Drawing.Size(1058, 412);
			this.tabPageTeachers.TabIndex = 3;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// statusStripStudents
			// 
			this.statusStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStudentCount});
			this.statusStripStudents.Location = new System.Drawing.Point(0, 449);
			this.statusStripStudents.Name = "statusStripStudents";
			this.statusStripStudents.Size = new System.Drawing.Size(1066, 22);
			this.statusStripStudents.TabIndex = 1;
			this.statusStripStudents.Text = "statusStrip1";
			// 
			// toolStripStatusLabelStudentCount
			// 
			this.toolStripStatusLabelStudentCount.Name = "toolStripStatusLabelStudentCount";
			this.toolStripStatusLabelStudentCount.Size = new System.Drawing.Size(13, 17);
			this.toolStripStatusLabelStudentCount.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1066, 471);
			this.Controls.Add(this.tabControlMain);
			this.Controls.Add(this.statusStripStudents);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Academy";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControlMain.ResumeLayout(false);
			this.tabPageStudent.ResumeLayout(false);
			this.tabPageStudent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageGroups.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
			this.statusStripStudents.ResumeLayout(false);
			this.statusStripStudents.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.Button btnAddGroup;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.ComboBox cbDirectionOnGroup;
		private System.Windows.Forms.DataGridView dataGridViewGroups;
	}
}

