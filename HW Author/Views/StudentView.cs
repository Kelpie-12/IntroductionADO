using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Author.Views
{
	public partial class StudentView : Form, IStudentsView
	{
		private string message;
		private bool isSuccessful;
		private bool isEdit;
		public StudentView()
		{
			InitializeComponent();
			AssociateAndRaiseViewEvents();
			tbStudent.TabPages.Remove(tPageAddStudent);
			//buttonAuthorClose.Click += delegate { this.Close(); };

		}
		private void AssociateAndRaiseViewEvents()
		{
			btnSearchStudent.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
			textSearchStudent.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter) 
					SearchEvent?.Invoke(this, EventArgs.Empty);	
			};
			btnAddNewStudent.Click += delegate
			{
				AddNewEvent?.Invoke(this, EventArgs.Empty);
				tbStudent.TabPages.Remove(tPageStudent);
				tbStudent.TabPages.Add(tPageAddStudent);
			};
			btnDeleteStudent.Click += delegate
			{
				var result = MessageBox.Show("Are you sure you want to delete the selected auhtor?", "Warning",
					 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					DeleteEvent?.Invoke(this, EventArgs.Empty);
					MessageBox.Show(Message);
				}
			};
			btnSaveNewStudent.Click += delegate
			{
				SaveEvent?.Invoke(this, EventArgs.Empty);
				if (isSuccessful)
				{
					tbStudent.TabPages.Remove(tPageAddStudent);
					tbStudent.TabPages.Add(tPageStudent);
				}
				MessageBox.Show(Message);
			};
			btnCancelStudent.Click += delegate
			{
				CancelEvent?.Invoke(this, EventArgs.Empty);
				tbStudent.TabPages.Remove(tPageAddStudent);
				tbStudent.TabPages.Add(tPageStudent);
			};
		}
		public string StudentLastName { get => textBLastNStudent.Text ; set => textBLastNStudent.Text=value; }
		public string StudentFirstName { get => textBFirstNStudent.Text; set => textBFirstNStudent.Text=value; }
		public string StudentMiddleName { get => textBMiddleNStudent.Text; set => textBMiddleNStudent.Text=value; }
		public DateTime StudentBirthDate { get => dTPBirthDayStudent.Value; set => dTPBirthDayStudent.Value=value; }
		public int StudentGroup { get => cbGroupStudent.SelectedIndex; set => cbGroupStudent.SelectedIndex=value; }
		public string SearchValue { get => textSearchStudent.Text; set => textSearchStudent.Text=value; }
		public bool IsEdit { get { return isEdit; } set => isEdit=value; }
		public bool IsSuccessful { get { return isSuccessful; } set => isSuccessful = value; }
		public string Message { get { return message; } set => message = value; }

		public int StudentId { get =>  Convert.ToInt32(textBIDStudent.Text); set => textBIDStudent.Text="0"; }

		public event EventHandler SearchEvent;
		public event EventHandler AddNewEvent;
		public event EventHandler DeleteEvent;
		public event EventHandler SaveEvent;
		public event EventHandler CancelEvent;

		public void SetAuthorsListBindingSource(BindingSource studentList)
		{
			dataGridViewStudents.DataSource=studentList;
		}
		private static StudentView instance;
		public static StudentView GetInstance(Form parentContainer)
		{
			if (instance == null || instance.IsDisposed)
			{
				instance = new StudentView();
				instance.MdiParent = parentContainer;
				instance.FormBorderStyle = FormBorderStyle.None;
				instance.Dock = DockStyle.Fill;
			}
			else
			{
				if (instance.WindowState == FormWindowState.Minimized)
					instance.WindowState = FormWindowState.Normal;
				instance.BringToFront();
			}
			return instance;
		}

		private void btnSaveNewStudent_Click(object sender, EventArgs e)
		{

		}
	}
}
