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
	public partial class UserForgetPassword : Form
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public UserForgetPassword()
		{
			InitializeComponent();
		}

		private void UserForgetPassword_Load(object sender, EventArgs e)
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

		private void button2_Click(object sender, EventArgs e)
		{
			UserLoginPage loginPage = new UserLoginPage();
			loginPage.ShowDialog();
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void UserForgetPass_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			String email, password, confirmPassword;
			email = txt_Email.Text; 
			password=txt_Password.Text; 
			confirmPassword = txt_ConfirmPassword.Text;

			try
			{
				if(email == "" || password == "" || confirmPassword == "")
				{
					MessageBox.Show("Please enter your email and password first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					SqlCommand command = new SqlCommand("Select CustomerName from Customer where CustomerEmail='" + email + "'",conn);
					SqlDataReader dr = command.ExecuteReader();
					
					if(dr.Read())
					{
						string customerName = dr.GetString(0);
						conn.Close();
						if(password==confirmPassword)
						{
							conn.Open();

							using (SqlTransaction updateTran = conn.BeginTransaction())
							{

								try
								{
									SqlCommand sqlCommand = new SqlCommand("Update Customer set CustomerPassword='"+password+"' where CustomerEmail='"+email+"'", conn,updateTran);
									sqlCommand.ExecuteNonQuery();
									updateTran.Commit();

									MessageBox.Show($"Dear {customerName}\n\nYour password successfully changed!!\nPlease Login?", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

									txt_Email.Clear();
									txt_Password.Clear();
									txt_ConfirmPassword.Clear();

									UserLoginPage ulp=new UserLoginPage();
									ulp.Show();
									this.Hide();
								}
								catch
								{
									updateTran.Rollback();
									MessageBox.Show($"Dear {customerName}\n\nYour password not changed!!\nSomething Problem....Please try Again", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}

							}
						}
						else
						{
							MessageBox.Show("Password not match\nPlease try again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							txt_ConfirmPassword.Clear();
						}
					}
					else
					{
						MessageBox.Show("User not found!\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						txt_Email.Clear();
						txt_Password.Clear();
						txt_ConfirmPassword.Clear();
					}
				}
			}
			catch
			{
				MessageBox.Show("Something Problem!!\nPlease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_Email.Clear();
				txt_Password.Clear();
				txt_ConfirmPassword.Clear();
			}
			finally 
			{ 
				conn.Close(); 
			}
		}
	}
}
