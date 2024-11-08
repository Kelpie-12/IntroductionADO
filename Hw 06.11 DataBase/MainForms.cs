using Hw_06._11_DataBase.View;
using System;
using System.Windows.Forms;
using System.Configuration;
using Hw_06._11_DataBase.Repository;
using Hw_06._11_DataBase.Presenter;

namespace Hw_06._11_DataBase
{
	public partial class MainForms : Form, IAuthorsView
	{
		private string message;
		private bool isSuccessful;
		private bool isEdit;	
		public MainForms()
		{
			InitializeComponent();
			AssociateAndRaiseViewEvents();
			AuthorsTab.TabPages.Remove(tabAuthorsDetail);
		}

		private void AssociateAndRaiseViewEvents()
		{
			buttonSearchA.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
			textSearchAuthors.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					SearchEvent?.Invoke(this, EventArgs.Empty);
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

		private void MainForms_Load(object sender, EventArgs e)
		{

		}
	}
}
