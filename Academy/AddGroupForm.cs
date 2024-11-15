﻿using System;
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
	public partial class AddGroupForm : Form
	{
		public AddGroupForm()
		{
			InitializeComponent();
			cbLearningForm.Items.AddRange(Connector.SelectColumn("form_name", "LearningForms").ToArray());
			cbGroupDirection.Items.AddRange(Connector.SelectColumn("derection_name", "Directions").ToArray());
		}
		public byte GetWeekDays()
		{
			byte days = 0;
			byte day = 1;
			for (byte i = 0; i < checkedLBCroup.Items.Count;i++)
			{
				Console.Write(checkedLBCroup.GetItemChecked(i) + "\t");
				if (checkedLBCroup.GetItemChecked(i))
					days |= (byte)(day << i);				
			}
            Console.WriteLine(days);
            return days;
		}
		private void btnSaveGroup_Click(object sender, EventArgs e)
		{
            GetWeekDays(); 

		}
	}
}
