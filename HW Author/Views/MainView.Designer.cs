namespace HW_Author.Views
{
	partial class MainView
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
			this.buttonAuthor = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.Controls.Add(this.buttonAuthor);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(135, 511);
			this.panel1.TabIndex = 0;
			// 
			// buttonAuthor
			// 
			this.buttonAuthor.AutoSize = true;
			this.buttonAuthor.BackColor = System.Drawing.SystemColors.Control;
			this.buttonAuthor.FlatAppearance.BorderSize = 0;
			this.buttonAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAuthor.Location = new System.Drawing.Point(5, 77);
			this.buttonAuthor.Name = "buttonAuthor";
			this.buttonAuthor.Size = new System.Drawing.Size(127, 41);
			this.buttonAuthor.TabIndex = 0;
			this.buttonAuthor.Text = "Authors";
			this.buttonAuthor.UseVisualStyleBackColor = false;
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 511);
			this.Controls.Add(this.panel1);
			this.IsMdiContainer = true;
			this.Name = "MainView";
			this.Text = "MainView";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonAuthor;
	}
}