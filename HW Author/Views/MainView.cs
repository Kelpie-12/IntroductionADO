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
	public partial class MainView : Form,IMainView
	{
		public MainView()
		{
			InitializeComponent();
			buttonAuthor.Click += delegate { ShowAuthorView?.Invoke(this, EventArgs.Empty); };
			btnStudent.Click += delegate { ShowStudentView?.Invoke(this, EventArgs.Empty); };
		}

		public event EventHandler ShowAuthorView;
		public event EventHandler CloseAuthorView;
		public event EventHandler ShowStudentView;
		public event EventHandler CloseStudentView;
	}
}
