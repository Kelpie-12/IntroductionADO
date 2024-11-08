namespace Hw_06._11_DataBase
{
	partial class MainForms
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabAuthorsDetail = new System.Windows.Forms.TabPage();
			this.textBoxAuthorsFirstName = new System.Windows.Forms.TextBox();
			this.textBoxAuthorsLastName = new System.Windows.Forms.TextBox();
			this.textBoxAuthorsId = new System.Windows.Forms.TextBox();
			this.labelAid = new System.Windows.Forms.Label();
			this.labelAuthorsName = new System.Windows.Forms.Label();
			this.labelAuthorsFirst = new System.Windows.Forms.Label();
			this.tabAuthors = new System.Windows.Forms.TabPage();
			this.buttonDeleteA = new System.Windows.Forms.Button();
			this.buttonAddNewA = new System.Windows.Forms.Button();
			this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
			this.buttonSearchA = new System.Windows.Forms.Button();
			this.textSearchAuthors = new System.Windows.Forms.TextBox();
			this.lableSearch = new System.Windows.Forms.Label();
			this.AuthorsTab = new System.Windows.Forms.TabControl();
			this.panel1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabAuthorsDetail.SuspendLayout();
			this.tabAuthors.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
			this.AuthorsTab.SuspendLayout();
			this.SuspendLayout();
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
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 48);
			this.panel1.TabIndex = 1;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.button4);
			this.tabPage4.Controls.Add(this.button5);
			this.tabPage4.Controls.Add(this.dataGridView1);
			this.tabPage4.Controls.Add(this.button6);
			this.tabPage4.Controls.Add(this.textBox1);
			this.tabPage4.Controls.Add(this.label3);
			this.tabPage4.Location = new System.Drawing.Point(4, 29);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(768, 351);
			this.tabPage4.TabIndex = 5;
			this.tabPage4.Text = "Books";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.AutoSize = true;
			this.button4.Location = new System.Drawing.Point(632, 130);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(95, 33);
			this.button4.TabIndex = 5;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.Location = new System.Drawing.Point(632, 91);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(95, 33);
			this.button5.TabIndex = 4;
			this.button5.Text = "Add new ";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(14, 75);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(594, 270);
			this.dataGridView1.TabIndex = 3;
			// 
			// button6
			// 
			this.button6.AutoSize = true;
			this.button6.Location = new System.Drawing.Point(528, 29);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(80, 30);
			this.button6.TabIndex = 2;
			this.button6.Text = "Search";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(14, 31);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(508, 26);
			this.textBox1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Search ";
			// 
			// tabAuthorsDetail
			// 
			this.tabAuthorsDetail.Controls.Add(this.textBoxAuthorsFirstName);
			this.tabAuthorsDetail.Controls.Add(this.textBoxAuthorsLastName);
			this.tabAuthorsDetail.Controls.Add(this.textBoxAuthorsId);
			this.tabAuthorsDetail.Controls.Add(this.labelAid);
			this.tabAuthorsDetail.Controls.Add(this.labelAuthorsName);
			this.tabAuthorsDetail.Controls.Add(this.labelAuthorsFirst);
			this.tabAuthorsDetail.Location = new System.Drawing.Point(4, 29);
			this.tabAuthorsDetail.Name = "tabAuthorsDetail";
			this.tabAuthorsDetail.Padding = new System.Windows.Forms.Padding(3);
			this.tabAuthorsDetail.Size = new System.Drawing.Size(768, 351);
			this.tabAuthorsDetail.TabIndex = 4;
			this.tabAuthorsDetail.Text = "Authors Detail";
			this.tabAuthorsDetail.UseVisualStyleBackColor = true;
			// 
			// textBoxAuthorsFirstName
			// 
			this.textBoxAuthorsFirstName.Location = new System.Drawing.Point(55, 82);
			this.textBoxAuthorsFirstName.Name = "textBoxAuthorsFirstName";
			this.textBoxAuthorsFirstName.Size = new System.Drawing.Size(534, 26);
			this.textBoxAuthorsFirstName.TabIndex = 5;
			// 
			// textBoxAuthorsLastName
			// 
			this.textBoxAuthorsLastName.Location = new System.Drawing.Point(55, 186);
			this.textBoxAuthorsLastName.Name = "textBoxAuthorsLastName";
			this.textBoxAuthorsLastName.Size = new System.Drawing.Size(534, 26);
			this.textBoxAuthorsLastName.TabIndex = 4;
			// 
			// textBoxAuthorsId
			// 
			this.textBoxAuthorsId.Location = new System.Drawing.Point(55, 276);
			this.textBoxAuthorsId.Name = "textBoxAuthorsId";
			this.textBoxAuthorsId.Size = new System.Drawing.Size(142, 26);
			this.textBoxAuthorsId.TabIndex = 3;
			// 
			// labelAid
			// 
			this.labelAid.AutoSize = true;
			this.labelAid.Location = new System.Drawing.Point(51, 234);
			this.labelAid.Name = "labelAid";
			this.labelAid.Size = new System.Drawing.Size(83, 20);
			this.labelAid.TabIndex = 2;
			this.labelAid.Text = "Authors Id";
			// 
			// labelAuthorsName
			// 
			this.labelAuthorsName.AutoSize = true;
			this.labelAuthorsName.Location = new System.Drawing.Point(51, 41);
			this.labelAuthorsName.Name = "labelAuthorsName";
			this.labelAuthorsName.Size = new System.Drawing.Size(146, 20);
			this.labelAuthorsName.TabIndex = 1;
			this.labelAuthorsName.Text = "Authors First Name";
			// 
			// labelAuthorsFirst
			// 
			this.labelAuthorsFirst.AutoSize = true;
			this.labelAuthorsFirst.Location = new System.Drawing.Point(51, 145);
			this.labelAuthorsFirst.Name = "labelAuthorsFirst";
			this.labelAuthorsFirst.Size = new System.Drawing.Size(146, 20);
			this.labelAuthorsFirst.TabIndex = 0;
			this.labelAuthorsFirst.Text = "Authors Last Name";
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
			this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAuthors.Location = new System.Drawing.Point(14, 75);
			this.dataGridViewAuthors.Name = "dataGridViewAuthors";
			this.dataGridViewAuthors.Size = new System.Drawing.Size(594, 270);
			this.dataGridViewAuthors.TabIndex = 3;
			// 
			// buttonSearchA
			// 
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
			// AuthorsTab
			// 
			this.AuthorsTab.Controls.Add(this.tabAuthors);
			this.AuthorsTab.Controls.Add(this.tabAuthorsDetail);
			this.AuthorsTab.Controls.Add(this.tabPage4);
			this.AuthorsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorsTab.Location = new System.Drawing.Point(12, 54);
			this.AuthorsTab.Name = "AuthorsTab";
			this.AuthorsTab.SelectedIndex = 0;
			this.AuthorsTab.Size = new System.Drawing.Size(776, 384);
			this.AuthorsTab.TabIndex = 2;
			// 
			// MainForms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AuthorsTab);
			this.Controls.Add(this.panel1);
			this.Name = "MainForms";
			this.Text = "Form";
			this.Load += new System.EventHandler(this.MainForms_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabAuthorsDetail.ResumeLayout(false);
			this.tabAuthorsDetail.PerformLayout();
			this.tabAuthors.ResumeLayout(false);
			this.tabAuthors.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
			this.AuthorsTab.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabAuthorsDetail;
		private System.Windows.Forms.TabPage tabAuthors;
		private System.Windows.Forms.Button buttonDeleteA;
		private System.Windows.Forms.Button buttonAddNewA;
		private System.Windows.Forms.DataGridView dataGridViewAuthors;
		private System.Windows.Forms.Button buttonSearchA;
		private System.Windows.Forms.TextBox textSearchAuthors;
		private System.Windows.Forms.Label lableSearch;
		private System.Windows.Forms.TabControl AuthorsTab;
		private System.Windows.Forms.TextBox textBoxAuthorsFirstName;
		private System.Windows.Forms.TextBox textBoxAuthorsLastName;
		private System.Windows.Forms.TextBox textBoxAuthorsId;
		private System.Windows.Forms.Label labelAid;
		private System.Windows.Forms.Label labelAuthorsName;
		private System.Windows.Forms.Label labelAuthorsFirst;
	}
}

