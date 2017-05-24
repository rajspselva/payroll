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
	public partial class GeneratePayslip : Form
	{
		public GeneratePayslip()
		{
			InitializeComponent();
		}

		private void GeneratePayslip_Load(object sender, EventArgs e)
		{

		}

		private void lbPayslip_Click(object sender, EventArgs e)
		{

		}

		private void lbEmployeename_Click(object sender, EventArgs e)
		{

		}

		private void lbctc_Click(object sender, EventArgs e)
		{

		}

		private void lbAttendance_Click(object sender, EventArgs e)
		{

		}

		private void lbMonth_Click(object sender, EventArgs e)
		{

		}

		private void lbtax_Click(object sender, EventArgs e)
		{

		}

		private void btGenerate_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Constants.Save_Credentials, Application.ProductName);
		}

		private void btCancel_Click(object sender, EventArgs e)
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
			txtTax.Text = (ctcAmount * (10f / 100f)).ToString("0.0");
			double tax = double.Parse(txtTax.Text);
			txtNetpay.Text = (ctcAmount - tax).ToString("0.0");
		}

	}
	}

