using System;
using System.Windows.Forms;

namespace HW_Author.Views
{
	public interface IStudentsView
	{
		int StudentId { get; set; }
		string StudentLastName { get; set; }
		string StudentFirstName { get; set; }
		string StudentMiddleName { get; set; }
		DateTime StudentBirthDate {  get; set; }
		int StudentGroup { get; set; }	
		string SearchValue { get; set; }
		bool IsEdit { get; set; }
		bool IsSuccessful { get; set; }
		string Message { get; set; }

		event EventHandler SearchEvent;
		event EventHandler AddNewEvent;
		event EventHandler DeleteEvent;
		event EventHandler SaveEvent;
		event EventHandler CancelEvent;

		void SetAuthorsListBindingSource(BindingSource studentList);
		void Show();
	}
}
