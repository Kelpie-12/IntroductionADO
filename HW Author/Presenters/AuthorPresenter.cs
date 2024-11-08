using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using HW_Author.Models;
using HW_Author.Views;

namespace HW_Author.Presenters
{
	public class AuthorsPresenter
	{
		private IAuthorsView view;
		private IAuthorsRepository repository;
		private BindingSource authorsBindingSource;
		private IEnumerable<AuthorsModel> authorsList;

		public AuthorsPresenter(IAuthorsView view, IAuthorsRepository repository)
		{
			this.authorsBindingSource = new BindingSource();
			this.view = view;
			this.repository = repository;
			this.view.SearchEvent += SearchAuthor;
			this.view.AddNewEvent += AddNewAuthor;
			this.view.DeleteEvent += DeleteAuthor;
			this.view.SaveEvent += SaveAuthor;
			this.view.CancelEvent += CancelAction;

			this.view.SetAuthorsListBindingSource(authorsBindingSource);

			LoadAllAuthorsList();
			this.view.Show();


		}

		private void LoadAllAuthorsList()
		{
			authorsList = repository.GetAll();
			authorsBindingSource.DataSource = authorsList;
		}

		private void CancelAction(object sender, EventArgs e)
		{
			CleanViewFields();
		}

		private void SaveAuthor(object sender, EventArgs e)
		{
			var model = new AuthorsModel();
			model.Id = Convert.ToInt32(view.AuthorsId);
			model.Last_name = view.AuthorsLastName;
			model.First_name = view.AuthorsFirstName;
			try
			{
				repository.Add(model);
				view.IsSuccessful = true;
				LoadAllAuthorsList();
				CleanViewFields();
				view.Message = "Author add";

			}
			catch (Exception ex)
			{
				view.IsSuccessful = false;
				view.Message = ex.Message;
			}

		}

		private void CleanViewFields()
		{
			view.AuthorsId = "0";
			view.AuthorsLastName = string.Empty;
			view.AuthorsFirstName = string.Empty;
		}

		private void DeleteAuthor(object sender, EventArgs e)
		{
			try
			{
				var author = (AuthorsModel)authorsBindingSource.Current;
				repository.Delete(author.Id);
				view.IsSuccessful = true;
				view.Message = "Author deleted";
				LoadAllAuthorsList();
			}
			catch (Exception ex)
			{
				view.IsSuccessful = false;
				view.Message = "Error";
			}
		}

		private void AddNewAuthor(object sender, EventArgs e)
		{
			view.IsEdit = false;
		}

		private void SearchAuthor(object sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
			if (emptyValue == false)
				authorsList = repository.GetByValue(this.view.SearchValue);
			else authorsList = repository.GetAll();
			authorsBindingSource.DataSource = authorsList;
		}

	}
}
