﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_Acadeny
{
	public partial class ViewStudent : Form
	{
		DataTable dt;
		public ViewStudent(DataGridViewRow row)
		{
			InitializeComponent();
			LoadStudent(ref row);
		}
		void LoadStudent(ref DataGridViewRow row)
		{
			tbStidentId.Text = row.Cells[0].Value.ToString();
			tbStidentId.ReadOnly=true;
			tbStudentName.Text = row.Cells[1].Value.ToString();
			tbStudentLast.Text = row.Cells[2].Value.ToString();
			tbStudentMiddle.Text = row.Cells[3].Value.ToString();
			dTPBirthDay.Value = Convert.ToDateTime(row.Cells[4].Value);
			cbStudentAddGroup.DataSource = Connector.Select("*", "Groups");
			cbStudentAddGroup.DisplayMember = "group_name";
			cbStudentAddGroup.ValueMember = "group_id";
			 cbStudentAddGroup.SelectedValue = Convert.ToInt32(row.Cells[5].Value);
			
		}

		private void btnSaveGroup_Click(object sender, EventArgs e)
		{
			dt = Connector.Select("*", "Students", $"student_id = {Convert.ToInt32(tbStidentId.Text)}");
			dt.Rows[0].Delete();
			DataRow r = dt.NewRow();
			r[0] = Convert.ToInt32(tbStidentId.Text);
			r[1] = tbStudentName.Text ;
			r[2] = tbStudentLast.Text;
			r[3] = tbStudentMiddle.Text;
			r[4] = dTPBirthDay.Value;
			r[5] = cbStudentAddGroup.SelectedValue;
			dt.Rows.Add(r);
			Connector.UpdateStudent(ref dt);		
		}
	}
}