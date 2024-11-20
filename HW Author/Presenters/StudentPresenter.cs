using HW_Author.Models;
using HW_Author.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Author.Presenters
{
	public class StudentPresenter
	{
		private IStudentsView view;
		private IStudentRepository repository;
		private BindingSource studentBindingSource;
		private IEnumerable<StudentModel> studentsList;

		public StudentPresenter(IStudentsView view, IStudentRepository repository)
		{
			this.studentBindingSource = new BindingSource();
			this.view = view;
			this.repository = repository;
			this.view.SearchEvent += SearchStudent;
			this.view.AddNewEvent += AddNewStudent;
			this.view.DeleteEvent += DeleteStudent;
			this.view.SaveEvent += SaveStudent;
			this.view.CancelEvent += CancelAction;

			this.view.SetAuthorsListBindingSource(studentBindingSource);

			LoadAllStudentsList();
			this.view.Show();


		}

		private void SearchStudent(object sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
			if (emptyValue == false)
				studentsList = repository.GetByValue(this.view.SearchValue);
			else studentsList = repository.GetAll();
			studentBindingSource.DataSource = studentsList;
		}

		private void AddNewStudent(object sender, EventArgs e)
		{
			view.IsEdit = false;
		}

		private void DeleteStudent(object sender, EventArgs e)
		{
			try
			{
				var student = (StudentModel)studentBindingSource.Current;
				repository.Delete(student.Id);
				view.IsSuccessful = true;
				view.Message = "Author deleted";
				LoadAllStudentsList();
			}
			catch (Exception ex)
			{
				view.IsSuccessful = false;
				view.Message = "Error";
			}
		}

		private void SaveStudent(object sender, EventArgs e)
		{
			var model = new StudentModel();
			model.Id = Convert.ToInt32(view.StudentId);
			model.LastName = view.StudentLastName;
			model.FirstName = view.StudentFirstName;
			try
			{
				repository.Add(model);
				view.IsSuccessful = true;
				LoadAllStudentsList();
				CleanViewFields();
				view.Message = "Author add";

			}
			catch (Exception ex)
			{
				view.IsSuccessful = false;
				view.Message = ex.Message;
			}
		}

		private void LoadAllStudentsList()
		{
			studentsList = repository.GetAll();
			studentBindingSource.DataSource = studentsList;
		}

		private void CancelAction(object sender, EventArgs e)
		{
			CleanViewFields();
		}

		private void CleanViewFields()
		{
			view.StudentId = 0;
			view.StudentLastName = string.Empty;
			view.StudentFirstName = string.Empty;
			view.StudentMiddleName = string.Empty;
			view.StudentGroup = 0;
		}
	}
}
