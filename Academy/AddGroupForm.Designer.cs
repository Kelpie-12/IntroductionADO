﻿namespace Academy
{
	partial class AddGroupForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBGroupName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbGroupDirection = new System.Windows.Forms.ComboBox();
			this.dateTPGroupTime = new System.Windows.Forms.DateTimePicker();
			this.checkedLBCroup = new System.Windows.Forms.CheckedListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbLearningForm = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTPGroupStart = new System.Windows.Forms.DateTimePicker();
			this.btnSaveGroup = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(30, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название группы";
			// 
			// textBGroupName
			// 
			this.textBGroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBGroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.textBGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBGroupName.Location = new System.Drawing.Point(287, 39);
			this.textBGroupName.Name = "textBGroupName";
			this.textBGroupName.Size = new System.Drawing.Size(370, 32);
			this.textBGroupName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(30, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(251, 26);
			this.label2.TabIndex = 2;
			this.label2.Text = "Направление обучения";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(378, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "Время";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(33, 324);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 26);
			this.label4.TabIndex = 5;
			this.label4.Text = "Дни обучения";
			// 
			// cbGroupDirection
			// 
			this.cbGroupDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGroupDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbGroupDirection.FormattingEnabled = true;
			this.cbGroupDirection.Location = new System.Drawing.Point(287, 88);
			this.cbGroupDirection.Name = "cbGroupDirection";
			this.cbGroupDirection.Size = new System.Drawing.Size(370, 33);
			this.cbGroupDirection.TabIndex = 6;
			// 
			// dateTPGroupTime
			// 
			this.dateTPGroupTime.CustomFormat = "HH:mm";
			this.dateTPGroupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTPGroupTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTPGroupTime.Location = new System.Drawing.Point(487, 143);
			this.dateTPGroupTime.Name = "dateTPGroupTime";
			this.dateTPGroupTime.Size = new System.Drawing.Size(97, 32);
			this.dateTPGroupTime.TabIndex = 7;
			// 
			// checkedLBCroup
			// 
			this.checkedLBCroup.CheckOnClick = true;
			this.checkedLBCroup.ColumnWidth = 200;
			this.checkedLBCroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkedLBCroup.FormattingEnabled = true;
			this.checkedLBCroup.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
			this.checkedLBCroup.Location = new System.Drawing.Point(222, 265);
			this.checkedLBCroup.MultiColumn = true;
			this.checkedLBCroup.Name = "checkedLBCroup";
			this.checkedLBCroup.Size = new System.Drawing.Size(435, 112);
			this.checkedLBCroup.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(33, 199);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(185, 26);
			this.label5.TabIndex = 9;
			this.label5.Text = "Форма обучения";
			// 
			// cbLearningForm
			// 
			this.cbLearningForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLearningForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbLearningForm.FormattingEnabled = true;
			this.cbLearningForm.Location = new System.Drawing.Point(287, 199);
			this.cbLearningForm.Name = "cbLearningForm";
			this.cbLearningForm.Size = new System.Drawing.Size(370, 33);
			this.cbLearningForm.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(33, 149);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 26);
			this.label6.TabIndex = 11;
			this.label6.Text = "Дата старта";
			// 
			// dateTPGroupStart
			// 
			this.dateTPGroupStart.CustomFormat = "HH:mm";
			this.dateTPGroupStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTPGroupStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTPGroupStart.Location = new System.Drawing.Point(206, 143);
			this.dateTPGroupStart.Name = "dateTPGroupStart";
			this.dateTPGroupStart.Size = new System.Drawing.Size(144, 32);
			this.dateTPGroupStart.TabIndex = 12;
			// 
			// btnSaveGroup
			// 
			this.btnSaveGroup.AutoSize = true;
			this.btnSaveGroup.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSaveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSaveGroup.Location = new System.Drawing.Point(383, 414);
			this.btnSaveGroup.Name = "btnSaveGroup";
			this.btnSaveGroup.Size = new System.Drawing.Size(131, 36);
			this.btnSaveGroup.TabIndex = 13;
			this.btnSaveGroup.Text = "Сохранить";
			this.btnSaveGroup.UseVisualStyleBackColor = true;
			this.btnSaveGroup.Click += new System.EventHandler(this.btnSaveGroup_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSize = true;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(526, 414);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(131, 36);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnRefresh
			// 
			this.btnRefresh.AutoSize = true;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnRefresh.Location = new System.Drawing.Point(38, 413);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(131, 38);
			this.btnRefresh.TabIndex = 15;
			this.btnRefresh.Text = "Сбросить";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// AddGroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 461);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSaveGroup);
			this.Controls.Add(this.dateTPGroupStart);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbLearningForm);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.checkedLBCroup);
			this.Controls.Add(this.dateTPGroupTime);
			this.Controls.Add(this.cbGroupDirection);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBGroupName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AddGroupForm";
			this.Text = "AddGroupForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.TextBox textBGroupName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		internal System.Windows.Forms.ComboBox cbGroupDirection;
		internal System.Windows.Forms.DateTimePicker dateTPGroupTime;
		private System.Windows.Forms.CheckedListBox checkedLBCroup;
		private System.Windows.Forms.Label label5;
		internal System.Windows.Forms.ComboBox cbLearningForm;
		private System.Windows.Forms.Label label6;
		internal System.Windows.Forms.DateTimePicker dateTPGroupStart;
		private System.Windows.Forms.Button btnSaveGroup;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnRefresh;
	}
}