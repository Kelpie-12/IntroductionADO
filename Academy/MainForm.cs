using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			dataGridViewStudents.DataSource = Connector.Select("last_name, first_name, birth_date, group_name, derection_name", "Students, Groups, Directions", "[group]=group_id and direction = direction_id");
			dataGridViewStudents.Rows.CollectionChanged += new CollectionChangeEventHandler(CountRows);
		}
		void CountRows(object sender, EventArgs e)
		{
			toolStripStatusLabelStudentCount.Text = $"Колличество студентов {dataGridViewStudents.RowCount}";
			
		}

		private void textBoxSearchStudent_KeyDown(object sender, KeyEventArgs e)
		{

		}
	}
}
