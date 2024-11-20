namespace HW_Author.Views
{
	partial class AuthorsView
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
			this.AuthorsTab = new System.Windows.Forms.TabControl();
			this.tabAuthors = new System.Windows.Forms.TabPage();
			this.buttonDeleteA = new System.Windows.Forms.Button();
			this.buttonAddNewA = new System.Windows.Forms.Button();
			this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
			this.buttonSearchA = new System.Windows.Forms.Button();
			this.textSearchAuthors = new System.Windows.Forms.TextBox();
			this.lableSearch = new System.Windows.Forms.Label();
			this.tabAuthorsDetaill = new System.Windows.Forms.TabPage();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.textBoxAuthorsFirstName = new System.Windows.Forms.TextBox();
			this.textBoxAuthorsLastName = new System.Windows.Forms.TextBox();
			this.textBoxAuthorsId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonAuthorClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.AuthorsTab.SuspendLayout();
			this.tabAuthors.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
			this.tabAuthorsDetaill.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// AuthorsTab
			// 
			this.AuthorsTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AuthorsTab.Controls.Add(this.tabAuthors);
			this.AuthorsTab.Controls.Add(this.tabAuthorsDetaill);
			this.AuthorsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorsTab.Location = new System.Drawing.Point(12, 60);
			this.AuthorsTab.Name = "AuthorsTab";
			this.AuthorsTab.SelectedIndex = 0;
			this.AuthorsTab.Size = new System.Drawing.Size(776, 384);
			this.AuthorsTab.TabIndex = 6;
			// 
			// tabAuthors
			// 
			this.tabAuthors.Controls.Add(this.buttonDeleteA);
			this.tabAuthors.Controls.Add(this.buttonAddNewA);
			this.tabAuthors.Controls.Add(this.dataGridViewAuthors);
			this.tabAuthors.Controls.Add(this.buttonSearchA);
			this.tabAuthors.Controls.Add(this.textSearchAuthors);
			this.tabAuthors.Controls.Add(this.lableSearch);
			this.tabAuthors.Location = new System.Drawing.Point(4, 29);
			this.tabAuthors.Name = "tabAuthors";
			this.tabAuthors.Padding = new System.Windows.Forms.Padding(3);
			this.tabAuthors.Size = new System.Drawing.Size(768, 351);
			this.tabAuthors.TabIndex = 1;
			this.tabAuthors.Text = "Authors";
			this.tabAuthors.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteA
			// 
			this.buttonDeleteA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDeleteA.AutoSize = true;
			this.buttonDeleteA.Location = new System.Drawing.Point(632, 130);
			this.buttonDeleteA.Name = "buttonDeleteA";
			this.buttonDeleteA.Size = new System.Drawing.Size(95, 33);
			this.buttonDeleteA.TabIndex = 5;
			this.buttonDeleteA.Text = "Delete";
			this.buttonDeleteA.UseVisualStyleBackColor = true;
			// 
			// buttonAddNewA
			// 
			this.buttonAddNewA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddNewA.AutoSize = true;
			this.buttonAddNewA.Location = new System.Drawing.Point(632, 91);
			this.buttonAddNewA.Name = "buttonAddNewA";
			this.buttonAddNewA.Size = new System.Drawing.Size(95, 33);
			this.buttonAddNewA.TabIndex = 4;
			this.buttonAddNewA.Text = "Add new ";
			this.buttonAddNewA.UseVisualStyleBackColor = true;
			// 
			// dataGridViewAuthors
			// 
			this.dataGridViewAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAuthors.Location = new System.Drawing.Point(14, 75);
			this.dataGridViewAuthors.Name = "dataGridViewAuthors";
			this.dataGridViewAuthors.Size = new System.Drawing.Size(594, 270);
			this.dataGridViewAuthors.TabIndex = 3;
			// 
			// buttonSearchA
			// 
			this.buttonSearchA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSearchA.AutoSize = true;
			this.buttonSearchA.Location = new System.Drawing.Point(528, 29);
			this.buttonSearchA.Name = "buttonSearchA";
			this.buttonSearchA.Size = new System.Drawing.Size(80, 30);
			this.buttonSearchA.TabIndex = 2;
			this.buttonSearchA.Text = "Search";
			this.buttonSearchA.UseVisualStyleBackColor = true;
			// 
			// textSearchAuthors
			// 
			this.textSearchAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textSearchAuthors.Location = new System.Drawing.Point(14, 31);
			this.textSearchAuthors.Name = "textSearchAuthors";
			this.textSearchAuthors.Size = new System.Drawing.Size(508, 26);
			this.textSearchAuthors.TabIndex = 1;
			// 
			// lableSearch
			// 
			this.lableSearch.AutoSize = true;
			this.lableSearch.Location = new System.Drawing.Point(10, 8);
			this.lableSearch.Name = "lableSearch";
			this.lableSearch.Size = new System.Drawing.Size(64, 20);
			this.lableSearch.TabIndex = 0;
			this.lableSearch.Text = "Search ";
			// 
			// tabAuthorsDetaill
			// 
			this.tabAuthorsDetaill.Controls.Add(this.buttonCancel);
			this.tabAuthorsDetaill.Controls.Add(this.buttonSave);
			this.tabAuthorsDetaill.Controls.Add(this.textBoxAuthorsFirstName);
			this.tabAuthorsDetaill.Controls.Add(this.textBoxAuthorsLastName);
			this.tabAuthorsDetaill.Controls.Add(this.textBoxAuthorsId);
			this.tabAuthorsDetaill.Controls.Add(this.label2);
			this.tabAuthorsDetaill.Controls.Add(this.label4);
			this.tabAuthorsDetaill.Controls.Add(this.label5);
			this.tabAuthorsDetaill.Location = new System.Drawing.Point(4, 29);
			this.tabAuthorsDetaill.Name = "tabAuthorsDetaill";
			this.tabAuthorsDetaill.Padding = new System.Windows.Forms.Padding(3);
			this.tabAuthorsDetaill.Size = new System.Drawing.Size(768, 351);
			this.tabAuthorsDetaill.TabIndex = 6;
			this.tabAuthorsDetaill.Text = "AuthorsDetail";
			this.tabAuthorsDetaill.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.AutoSize = true;
			this.buttonCancel.Location = new System.Drawing.Point(492, 312);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(95, 33);
			this.buttonCancel.TabIndex = 13;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.AutoSize = true;
			this.buttonSave.Location = new System.Drawing.Point(318, 312);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(95, 33);
			this.buttonSave.TabIndex = 12;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			// 
			// textBoxAuthorsFirstName
			// 
			this.textBoxAuthorsFirstName.Location = new System.Drawing.Point(53, 73);
			this.textBoxAuthorsFirstName.Name = "textBoxAuthorsFirstName";
			this.textBoxAuthorsFirstName.Size = new System.Drawing.Size(360, 26);
			this.textBoxAuthorsFirstName.TabIndex = 11;
			// 
			// textBoxAuthorsLastName
			// 
			this.textBoxAuthorsLastName.Location = new System.Drawing.Point(53, 177);
			this.textBoxAuthorsLastName.Name = "textBoxAuthorsLastName";
			this.textBoxAuthorsLastName.Size = new System.Drawing.Size(360, 26);
			this.textBoxAuthorsLastName.TabIndex = 10;
			// 
			// textBoxAuthorsId
			// 
			this.textBoxAuthorsId.Location = new System.Drawing.Point(53, 267);
			this.textBoxAuthorsId.Name = "textBoxAuthorsId";
			this.textBoxAuthorsId.ReadOnly = true;
			this.textBoxAuthorsId.Size = new System.Drawing.Size(142, 26);
			this.textBoxAuthorsId.TabIndex = 9;
			this.textBoxAuthorsId.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Authors Id";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Authors First Name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(49, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Authors Last Name";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.buttonAuthorClose);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 48);
			this.panel1.TabIndex = 5;
			// 
			// buttonAuthorClose
			// 
			this.buttonAuthorClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAuthorClose.AutoSize = true;
			this.buttonAuthorClose.Location = new System.Drawing.Point(754, 9);
			this.buttonAuthorClose.Name = "buttonAuthorClose";
			this.buttonAuthorClose.Size = new System.Drawing.Size(30, 30);
			this.buttonAuthorClose.TabIndex = 6;
			this.buttonAuthorClose.Text = "X";
			this.buttonAuthorClose.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Authors";
			// 
			// AuthorsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AuthorsTab);
			this.Controls.Add(this.panel1);
			this.Name = "AuthorsView";
			this.Text = "AuthorsView";
			this.AuthorsTab.ResumeLayout(false);
			this.tabAuthors.ResumeLayout(false);
			this.tabAuthors.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
			this.tabAuthorsDetaill.ResumeLayout(false);
			this.tabAuthorsDetaill.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl AuthorsTab;
		private System.Windows.Forms.TabPage tabAuthors;
		private System.Windows.Forms.Button buttonDeleteA;
		private System.Windows.Forms.Button buttonAddNewA;
		private System.Windows.Forms.DataGridView dataGridViewAuthors;
		private System.Windows.Forms.Button buttonSearchA;
		private System.Windows.Forms.TextBox textSearchAuthors;
		private System.Windows.Forms.Label lableSearch;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabAuthorsDetaill;
		private System.Windows.Forms.TextBox textBoxAuthorsFirstName;
		private System.Windows.Forms.TextBox textBoxAuthorsLastName;
		private System.Windows.Forms.TextBox textBoxAuthorsId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonAuthorClose;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
	}
}