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
			SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
			try
			{
				connection.Open();
				SqlCommand command = new SqlCommand("select * from login", connection);
				SqlDataReader datareader = command.ExecuteReader();
				while (datareader.Read())
				{
					if (string.IsNullOrEmpty(this.txtUser.Text) || string.IsNullOrEmpty(this.txtPass.Text))
					{
						MessageBox.Show(Constants.Empty_Credentials, Application.ProductName);
					}
					else

						if ((datareader["UserName"].ToString().Equals(txtUser.Text)) 
							&& (datareader["Password"].ToString().Equals(txtPass.Text)))
					{
						MainMenu mainMenu = new MainMenu();
						mainMenu.Show();
					}
					else
					{
						MessageBox.Show(Constants.Invalid_Credentials, Application.ProductName);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Can not open connection ! ");
			}
			finally
			{
				connection.Close();
			}
			
			
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private bool isValidCredentials()
		{
			if (string.IsNullOrEmpty(this.txtUser.Text) || string.IsNullOrEmpty(this.txtPass.Text))
			{
				MessageBox.Show(Constants.Empty_Credentials, Application.ProductName);
				return false;
			}
			return true;
		}

		private bool isValidUser()
		{
			if (!(txtUser.Text.Equals("admin") && txtPass.Text.Equals("admin")))
			{
				MessageBox.Show(Constants.Invalid_Credentials, Application.ProductName);
				return false;
			}
			return true;
		}

		private void txtUser_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
