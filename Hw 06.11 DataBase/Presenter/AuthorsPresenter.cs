using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hw_06._11_DataBase.Models;
using Hw_06._11_DataBase.View;

namespace Hw_06._11_DataBase.Presenter
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
			throw new NotImplementedException();
		}

		private void SaveAuthor(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void DeleteAuthor(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void AddNewAuthor(object sender, EventArgs e)
		{
			throw new NotImplementedException();
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
