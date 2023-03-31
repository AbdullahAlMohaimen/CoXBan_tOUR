using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoXBan_tOUR
{
	public partial class UserLoginPage : Form
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public UserLoginPage()
		{
			InitializeComponent();
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void goToAdminPage_Click(object sender, EventArgs e)
		{
			AdminLogin al=new AdminLogin();
			al.Show();
			this.Hide();
		}

		private void UserLoginPage_Load(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.UtcNow.Date;
			txt_Date.Text = dateTime.ToString("dd - MM - yyyy");
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void ForgetPassword_Click(object sender, EventArgs e)
		{
			UserForgetPassword ufp = new UserForgetPassword();
			ufp.Show();
			this.Hide();
		}

		private void UserCreateAccount_Click(object sender, EventArgs e)
		{
			UserCreateAccount uca = new UserCreateAccount();
			uca.Show();
			this.Hide();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			String email, password;
			email = txt_Email.Text;
			password = txt_Password.Text;

			try
			{
				if(email == "" || password == "")
				{
					MessageBox.Show("Please enter your email and password first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					SqlCommand command = new SqlCommand("Select * from Customer where Customer_Email='" + email + "' and Customer_Password='" + password + "'", conn);
					SqlDataReader dr = command.ExecuteReader();

					if(dr.Read())
					{
						UserPage up = new UserPage();
						up.SetEmail = txt_Email.Text;
						up.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						txt_Email.Clear();
						txt_Password.Clear();
					}
				}
			}
			catch
			{
				MessageBox.Show("Something Problem!!\nPlease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_Email.Clear();
				txt_Password.Clear();
			}
			finally
			{
				conn.Close();
			}
		}
	}
}
