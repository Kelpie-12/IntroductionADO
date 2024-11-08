using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Author.Views
{
	public interface IAuthorsView
	{
		string AuthorsId { get; set; }
		string AuthorsLastName { get; set; }
		string AuthorsFirstName { get; set; }
		string SearchValue { get; set; }
		bool IsEdit { get; set; }
		bool IsSuccessful { get; set; }
		string Message { get; set; }

		event EventHandler SearchEvent;
		event EventHandler AddNewEvent;
		event EventHandler DeleteEvent;
		event EventHandler SaveEvent;
		event EventHandler CancelEvent;

		void SetAuthorsListBindingSource(BindingSource authorsList);
		void Show();

	}
}
