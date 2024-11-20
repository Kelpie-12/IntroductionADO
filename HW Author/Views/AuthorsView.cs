using System;
using System.Windows.Forms;

namespace HW_Author.Views
{
	public partial class AuthorsView : Form, IAuthorsView
	{
		private string message;
		private bool isSuccessful;
		private bool isEdit;
		public AuthorsView()
		{
			InitializeComponent();
			AssociateAndRaiseViewEvents();
			AuthorsTab.TabPages.Remove(tabAuthorsDetaill);
			buttonAuthorClose.Click += delegate { this.Close(); };
		}

		private void AssociateAndRaiseViewEvents()
		{
			buttonSearchA.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
			textSearchAuthors.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					SearchEvent?.Invoke(this, EventArgs.Empty);
			};
			
			buttonAddNewA.Click += delegate 
			{
				AddNewEvent?.Invoke(this, EventArgs.Empty);
				AuthorsTab.TabPages.Remove(tabAuthors);
				AuthorsTab.TabPages.Add(tabAuthorsDetaill);
				tabAuthorsDetaill.Text = "Add new author";
			};

			buttonDeleteA.Click += delegate 
			{
				var result = MessageBox.Show("Are you sure you want to delete the selected auhtor?", "Warning",
					 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					DeleteEvent?.Invoke(this, EventArgs.Empty);
					MessageBox.Show(Message);
				}
			};
			
			buttonSave.Click += delegate 
			{ 
				
				SaveEvent?.Invoke(this, EventArgs.Empty);
			
				if (isSuccessful)
				{
					AuthorsTab.TabPages.Remove(tabAuthorsDetaill);
					AuthorsTab.TabPages.Add(tabAuthors);
				}
				MessageBox.Show(Message);
			};
			buttonCancel.Click += delegate 
			{ 
				CancelEvent?.Invoke(this, EventArgs.Empty);
				AuthorsTab.TabPages.Remove(tabAuthorsDetaill);
				AuthorsTab.TabPages.Add(tabAuthors);
			};
		}

		public string AuthorsId { get { return textBoxAuthorsId.Text; } set => textBoxAuthorsId.Text = value; }
		public string AuthorsLastName { get { return textBoxAuthorsLastName.Text; } set => textBoxAuthorsLastName.Text = value; }
		public string AuthorsFirstName { get { return textBoxAuthorsFirstName.Text; } set => textBoxAuthorsFirstName.Text = value; }
		public string SearchValue { get { return textSearchAuthors.Text; } set => textSearchAuthors.Text = value; }
		public bool IsEdit { get { return isEdit; } set => isEdit = value; }
		public bool IsSuccessful { get { return isSuccessful; } set => isSuccessful = value; }
		public string Message { get { return message; } set => message = value; }

		public event EventHandler SearchEvent;
		public event EventHandler AddNewEvent;
		public event EventHandler DeleteEvent;
		public event EventHandler SaveEvent;
		public event EventHandler CancelEvent;

		public void SetAuthorsListBindingSource(BindingSource authorsList)
		{
			dataGridViewAuthors.DataSource = authorsList;
		}

		private static AuthorsView instance;
		public static AuthorsView GetInstanc(Form parentContainer)
		{
			if (instance == null||instance.IsDisposed)
			{
				instance = new AuthorsView(); 
				instance.MdiParent= parentContainer;
				instance.FormBorderStyle = FormBorderStyle.None;
				instance.Dock= DockStyle.Fill;
			}
			else
			{
				if(instance.WindowState==FormWindowState.Minimized)
					instance.WindowState = FormWindowState.Normal;
				instance.BringToFront();
			}
			return instance;
		}

		
	}
}
