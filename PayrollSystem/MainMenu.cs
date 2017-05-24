using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}


		private void btlogout_Click(object sender, EventArgs e)
		{
			LoginForm login = new LoginForm();
			login.Show();
			this.Hide();
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btAddEmp_Click(object sender, EventArgs e)
		{
			EmpDetails empdetails = new EmpDetails();
			empdetails.Show();
			this.Hide();
		}

		private void btOk_Click(object sender, EventArgs e)
		{

		}

		private void btAddSalary_Click(object sender, EventArgs e)
		{
			Salary sal = new Salary();
	        sal.Show();
			this.Hide();
		}

		private void btPaySlip_Click(object sender, EventArgs e)
		{
			GeneratePayslip pay = new GeneratePayslip();
			pay.Show();
			this.Hide();
		}
	}
}
