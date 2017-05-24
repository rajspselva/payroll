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
	public partial class EmpDetails : Form
	{
		public EmpDetails()
		{
			InitializeComponent();
		}

		private void btBack_Click(object sender, EventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
			this.Hide();
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Constants.Save_Credentials, Application.ProductName);
		}
	}
}
