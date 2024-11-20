using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_Author.Models;
using HW_Author.Views;
using HW_Author.Repositories;
using System.Windows.Forms;


namespace HW_Author.Presenters
{
	public class MainPresenter
	{
		private IMainView mainView;
		private readonly string sqlConnectionString;
		public MainPresenter(IMainView mainView, string sqlConnectionString)
		{
			this.mainView = mainView;
			this.sqlConnectionString = sqlConnectionString;
			this.mainView.ShowAuthorView += ShowAuthorView;
			this.mainView.ShowStudentView += ShowStudentView;
		}

		private void ShowStudentView(object sender, EventArgs e)
		{
			IStudentsView view = StudentView.GetInstance((MainView)mainView);
			IStudentRepository repository = new StudentRepository(sqlConnectionString);
			new StudentPresenter(view, repository);
		}

		private void ShowAuthorView(object sender, EventArgs e)
		{
			IAuthorsView view = AuthorsView.GetInstanc((MainView)mainView);
			IAuthorsRepository repository = new AuthorsRepository(sqlConnectionString);
			new AuthorsPresenter(view, repository);
		}
	}
}
