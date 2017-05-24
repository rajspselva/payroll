using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSystem.Common;

namespace PayrollSystem
{
	public partial class Salary : Form
	{
		public Salary()
		{
			InitializeComponent();
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Constants.Save_Credentials, Application.ProductName);
		}

		private void btBack_Click(object sender, EventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
			this.Hide();
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void txtCtc_Leave(object sender, EventArgs e)
		{
			double ctcAmount = double.Parse(txtCtc.Text);
			txtBasic.Text= (ctcAmount * (20f / 100f)).ToString("0.0");
		txtAllowence.Text = (ctcAmount * (70f / 100f)).ToString("0.0");
			txtPf.Text = (ctcAmount * (12f / 100f)).ToString("0.0");
		}

		
	}
}
