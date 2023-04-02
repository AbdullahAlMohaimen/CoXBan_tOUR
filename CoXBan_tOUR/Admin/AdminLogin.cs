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
	public partial class AdminLogin : Form
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public AdminLogin()
		{
			InitializeComponent();
		}

		private void AdminLogin_Load(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.UtcNow.Date;
			txt_Date.Text = dateTime.ToString("dd - MM - yyyy");
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			String adminEamil, adminPassword;
			adminEamil = txt_Email.Text;
			adminPassword = txt_Password.Text;

			try
			{
				if(adminEamil=="" || adminPassword=="")
				{
					MessageBox.Show("Please enter your email and password first!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					SqlCommand command = new SqlCommand("select * from Admin where AdminEmail='"+adminEamil+"' and AdminPassword='"+adminPassword+"'",conn);
					SqlDataReader dr=command.ExecuteReader();

					if(dr.Read())
					{
						AdminPage ap=new AdminPage();
						ap.SetAdminEmail = txt_Email.Text;
						ap.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Admin not found\nPlease try again and enter a correct email and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		}

		private void button2_Click(object sender, EventArgs e)
		{
			UserLoginPage ulp=new UserLoginPage();
			ulp.Show();
			this.Hide();
		}

		private void ForgetPassword_Click(object sender, EventArgs e)
		{
			AdminForgetPassword afp = new AdminForgetPassword();
			afp.Show();
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
