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
using System.Data.SqlClient;
using System.Configuration;


namespace PayrollSystem
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void btLogin_Click(object sender, EventArgs e)
		{
			if (IsValidCredential() && IsAuthenticated())
			{
				MainMenu main = new MainMenu();
				main.Show();
				this.Hide();
			}
			else
			{
				txtUser.Text = string.Empty;
				txtPass.Text = string.Empty;
			}
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void txtUser_TextChanged(object sender, EventArgs e)
		{

		}

		private bool IsValidCredential()
		{
			if (String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtPass.Text))
			{
				MessageBox.Show("InValid Credentials", Application.ProductName);
				return false;
			}
			return true;
		}
		private bool IsAuthenticated()
		{
			String ConnectionString = "Data Source=NAGU\\SQLEXPRESS;Initial Catalog=Payroll; User ID=sa;Password=dharani@123";
			SqlConnection connection = new SqlConnection(ConnectionString);
			try
			{
				connection.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM LOGIN", connection);
				SqlDataReader dataReader = command.ExecuteReader();
				while (dataReader.Read())
				{
					if (txtUser.Text.Equals(dataReader["Username"]) && txtPass.Text.Equals(dataReader["Password"]))
					{
						return true;
					}	
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Connection Failed", Application.ProductName);
			}
			finally
			{
				connection.Close();
			}
			MessageBox.Show("invalid Credentiel", Application.ProductName);
			return false;
		}

	}


}
