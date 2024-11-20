namespace HW_Author.Views
{
	partial class StudentView
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.tbStudent = new System.Windows.Forms.TabControl();
			this.tPageStudent = new System.Windows.Forms.TabPage();
			this.btnEditStudent = new System.Windows.Forms.Button();
			this.btnDeleteStudent = new System.Windows.Forms.Button();
			this.btnAddNewStudent = new System.Windows.Forms.Button();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.btnSearchStudent = new System.Windows.Forms.Button();
			this.textSearchStudent = new System.Windows.Forms.TextBox();
			this.tPageAddStudent = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.textBIDStudent = new System.Windows.Forms.TextBox();
			this.btnCancelStudent = new System.Windows.Forms.Button();
			this.btnSaveNewStudent = new System.Windows.Forms.Button();
			this.cbGroupStudent = new System.Windows.Forms.ComboBox();
			this.dTPBirthDayStudent = new System.Windows.Forms.DateTimePicker();
			this.textBMiddleNStudent = new System.Windows.Forms.TextBox();
			this.textBLastNStudent = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBFirstNStudent = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.tbStudent.SuspendLayout();
			this.tPageStudent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			this.tPageAddStudent.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(822, 58);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Student";
			// 
			// tbStudent
			// 
			this.tbStudent.Controls.Add(this.tPageStudent);
			this.tbStudent.Controls.Add(this.tPageAddStudent);
			this.tbStudent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbStudent.Location = new System.Drawing.Point(0, 58);
			this.tbStudent.Name = "tbStudent";
			this.tbStudent.SelectedIndex = 0;
			this.tbStudent.Size = new System.Drawing.Size(822, 415);
			this.tbStudent.TabIndex = 1;
			// 
			// tPageStudent
			// 
			this.tPageStudent.Controls.Add(this.panel4);
			this.tPageStudent.Controls.Add(this.panel3);
			this.tPageStudent.Controls.Add(this.panel2);
			this.tPageStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tPageStudent.Location = new System.Drawing.Point(4, 33);
			this.tPageStudent.Name = "tPageStudent";
			this.tPageStudent.Padding = new System.Windows.Forms.Padding(3);
			this.tPageStudent.Size = new System.Drawing.Size(814, 378);
			this.tPageStudent.TabIndex = 0;
			this.tPageStudent.Text = "Student";
			this.tPageStudent.UseVisualStyleBackColor = true;
			// 
			// btnEditStudent
			// 
			this.btnEditStudent.AutoSize = true;
			this.btnEditStudent.Location = new System.Drawing.Point(16, 236);
			this.btnEditStudent.Name = "btnEditStudent";
			this.btnEditStudent.Size = new System.Drawing.Size(103, 34);
			this.btnEditStudent.TabIndex = 12;
			this.btnEditStudent.Text = "Edit";
			this.btnEditStudent.UseVisualStyleBackColor = true;
			// 
			// btnDeleteStudent
			// 
			this.btnDeleteStudent.AutoSize = true;
			this.btnDeleteStudent.Location = new System.Drawing.Point(16, 302);
			this.btnDeleteStudent.Name = "btnDeleteStudent";
			this.btnDeleteStudent.Size = new System.Drawing.Size(103, 34);
			this.btnDeleteStudent.TabIndex = 11;
			this.btnDeleteStudent.Text = "Delete";
			this.btnDeleteStudent.UseVisualStyleBackColor = true;
			// 
			// btnAddNewStudent
			// 
			this.btnAddNewStudent.AutoSize = true;
			this.btnAddNewStudent.Location = new System.Drawing.Point(16, 172);
			this.btnAddNewStudent.Name = "btnAddNewStudent";
			this.btnAddNewStudent.Size = new System.Drawing.Size(103, 34);
			this.btnAddNewStudent.TabIndex = 10;
			this.btnAddNewStudent.Text = "Add new ";
			this.btnAddNewStudent.UseVisualStyleBackColor = true;
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewStudents.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.Size = new System.Drawing.Size(672, 304);
			this.dataGridViewStudents.TabIndex = 9;
			// 
			// btnSearchStudent
			// 
			this.btnSearchStudent.AutoSize = true;
			this.btnSearchStudent.Location = new System.Drawing.Point(16, 23);
			this.btnSearchStudent.Name = "btnSearchStudent";
			this.btnSearchStudent.Size = new System.Drawing.Size(103, 34);
			this.btnSearchStudent.TabIndex = 8;
			this.btnSearchStudent.Text = "Search";
			this.btnSearchStudent.UseVisualStyleBackColor = true;
			// 
			// textSearchStudent
			// 
			this.textSearchStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textSearchStudent.Location = new System.Drawing.Point(10, 23);
			this.textSearchStudent.Name = "textSearchStudent";
			this.textSearchStudent.Size = new System.Drawing.Size(641, 29);
			this.textSearchStudent.TabIndex = 7;
			// 
			// tPageAddStudent
			// 
			this.tPageAddStudent.Controls.Add(this.label7);
			this.tPageAddStudent.Controls.Add(this.textBIDStudent);
			this.tPageAddStudent.Controls.Add(this.btnCancelStudent);
			this.tPageAddStudent.Controls.Add(this.btnSaveNewStudent);
			this.tPageAddStudent.Controls.Add(this.cbGroupStudent);
			this.tPageAddStudent.Controls.Add(this.dTPBirthDayStudent);
			this.tPageAddStudent.Controls.Add(this.textBMiddleNStudent);
			this.tPageAddStudent.Controls.Add(this.textBLastNStudent);
			this.tPageAddStudent.Controls.Add(this.label6);
			this.tPageAddStudent.Controls.Add(this.label5);
			this.tPageAddStudent.Controls.Add(this.label4);
			this.tPageAddStudent.Controls.Add(this.label3);
			this.tPageAddStudent.Controls.Add(this.label2);
			this.tPageAddStudent.Controls.Add(this.textBFirstNStudent);
			this.tPageAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tPageAddStudent.ForeColor = System.Drawing.Color.Black;
			this.tPageAddStudent.Location = new System.Drawing.Point(4, 33);
			this.tPageAddStudent.Name = "tPageAddStudent";
			this.tPageAddStudent.Padding = new System.Windows.Forms.Padding(3);
			this.tPageAddStudent.Size = new System.Drawing.Size(814, 378);
			this.tPageAddStudent.TabIndex = 1;
			this.tPageAddStudent.Text = "Add new Student";
			this.tPageAddStudent.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(14, 281);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 26);
			this.label7.TabIndex = 13;
			this.label7.Text = "ID";
			// 
			// textBIDStudent
			// 
			this.textBIDStudent.Location = new System.Drawing.Point(188, 281);
			this.textBIDStudent.Name = "textBIDStudent";
			this.textBIDStudent.ReadOnly = true;
			this.textBIDStudent.Size = new System.Drawing.Size(396, 32);
			this.textBIDStudent.TabIndex = 12;
			// 
			// btnCancelStudent
			// 
			this.btnCancelStudent.AutoSize = true;
			this.btnCancelStudent.Location = new System.Drawing.Point(346, 328);
			this.btnCancelStudent.Name = "btnCancelStudent";
			this.btnCancelStudent.Size = new System.Drawing.Size(104, 36);
			this.btnCancelStudent.TabIndex = 11;
			this.btnCancelStudent.Text = "Cancel";
			this.btnCancelStudent.UseVisualStyleBackColor = true;
			// 
			// btnSaveNewStudent
			// 
			this.btnSaveNewStudent.AutoSize = true;
			this.btnSaveNewStudent.Location = new System.Drawing.Point(48, 328);
			this.btnSaveNewStudent.Name = "btnSaveNewStudent";
			this.btnSaveNewStudent.Size = new System.Drawing.Size(104, 36);
			this.btnSaveNewStudent.TabIndex = 10;
			this.btnSaveNewStudent.Text = "Save";
			this.btnSaveNewStudent.UseVisualStyleBackColor = true;
			this.btnSaveNewStudent.Click += new System.EventHandler(this.btnSaveNewStudent_Click);
			// 
			// cbGroupStudent
			// 
			this.cbGroupStudent.FormattingEnabled = true;
			this.cbGroupStudent.Location = new System.Drawing.Point(188, 230);
			this.cbGroupStudent.Name = "cbGroupStudent";
			this.cbGroupStudent.Size = new System.Drawing.Size(396, 33);
			this.cbGroupStudent.TabIndex = 9;
			// 
			// dTPBirthDayStudent
			// 
			this.dTPBirthDayStudent.Location = new System.Drawing.Point(188, 168);
			this.dTPBirthDayStudent.Name = "dTPBirthDayStudent";
			this.dTPBirthDayStudent.Size = new System.Drawing.Size(396, 32);
			this.dTPBirthDayStudent.TabIndex = 8;
			// 
			// textBMiddleNStudent
			// 
			this.textBMiddleNStudent.Location = new System.Drawing.Point(188, 121);
			this.textBMiddleNStudent.Name = "textBMiddleNStudent";
			this.textBMiddleNStudent.Size = new System.Drawing.Size(396, 32);
			this.textBMiddleNStudent.TabIndex = 7;
			// 
			// textBLastNStudent
			// 
			this.textBLastNStudent.Location = new System.Drawing.Point(188, 73);
			this.textBLastNStudent.Name = "textBLastNStudent";
			this.textBLastNStudent.Size = new System.Drawing.Size(396, 32);
			this.textBLastNStudent.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 233);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 26);
			this.label6.TabIndex = 5;
			this.label6.Text = "Group";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 26);
			this.label5.TabIndex = 4;
			this.label5.Text = "Birth day";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 26);
			this.label4.TabIndex = 3;
			this.label4.Text = "Middle name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Last name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "First name";
			// 
			// textBFirstNStudent
			// 
			this.textBFirstNStudent.Location = new System.Drawing.Point(188, 24);
			this.textBFirstNStudent.Name = "textBFirstNStudent";
			this.textBFirstNStudent.Size = new System.Drawing.Size(396, 32);
			this.textBFirstNStudent.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnSearchStudent);
			this.panel2.Controls.Add(this.btnDeleteStudent);
			this.panel2.Controls.Add(this.btnEditStudent);
			this.panel2.Controls.Add(this.btnAddNewStudent);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(675, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(136, 372);
			this.panel2.TabIndex = 13;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.textSearchStudent);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(672, 68);
			this.panel3.TabIndex = 14;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridViewStudents);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(3, 71);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(672, 304);
			this.panel4.TabIndex = 15;
			// 
			// StudentView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 473);
			this.Controls.Add(this.tbStudent);
			this.Controls.Add(this.panel1);
			this.Name = "StudentView";
			this.Text = "StudentView";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tbStudent.ResumeLayout(false);
			this.tPageStudent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			this.tPageAddStudent.ResumeLayout(false);
			this.tPageAddStudent.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tbStudent;
		private System.Windows.Forms.TabPage tPageStudent;
		private System.Windows.Forms.TabPage tPageAddStudent;
		private System.Windows.Forms.Button btnEditStudent;
		private System.Windows.Forms.Button btnDeleteStudent;
		private System.Windows.Forms.Button btnAddNewStudent;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.Button btnSearchStudent;
		private System.Windows.Forms.TextBox textSearchStudent;
		private System.Windows.Forms.TextBox textBLastNStudent;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBFirstNStudent;
		private System.Windows.Forms.TextBox textBMiddleNStudent;
		private System.Windows.Forms.Button btnCancelStudent;
		private System.Windows.Forms.Button btnSaveNewStudent;
		private System.Windows.Forms.ComboBox cbGroupStudent;
		private System.Windows.Forms.DateTimePicker dTPBirthDayStudent;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBIDStudent;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
	}
}