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
	public partial class AdminForgetPassword : Form
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public AdminForgetPassword()
		{
			InitializeComponent();
		}

		private void UserForgetPass_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			String adminEmail, adminPassword, adminConfirmPassword;
			adminEmail = txt_Email.Text;
			adminPassword = txt_Password.Text;
			adminConfirmPassword = txt_ConfirmPassword.Text;

			try
			{
				if(adminEmail == "" || adminPassword == "" || adminConfirmPassword == "")
				{
					MessageBox.Show("Please enter your email and password first!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
				else
				{
					SqlCommand command=new SqlCommand("Select AdminName from Admin where AdminEmail='" + adminEmail + "'",conn);
					SqlDataReader dr=command.ExecuteReader();

					if(dr.Read())
					{
						string adminName = dr.GetString(0);
						conn.Close();
						if (adminPassword == adminConfirmPassword)
						{
							conn.Open();

							using (SqlTransaction updateTransaction = conn.BeginTransaction())
							{
								try
								{
									SqlCommand sqlCommand = new SqlCommand("update Admin set AdminPassword='"+adminPassword+"' where AdminEmail='"+adminEmail+"'",conn,updateTransaction);
									sqlCommand.ExecuteNonQuery();
									updateTransaction.Commit();

									MessageBox.Show($"Dear {adminName}\n\nYour password successfully changed!!\nPlease Login?", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
									txt_Email.Clear();
									txt_Password.Clear();
									txt_ConfirmPassword.Clear();

									AdminLogin al = new AdminLogin();
									al.Show();
									this.Hide();

								}
								catch
								{
									updateTransaction.Rollback();
									MessageBox.Show($"Dear {adminName}\n\nYour password not changed!!\nSomething Problem....Please try Again", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
							}
						}
						else
						{
							MessageBox.Show("Password not match!!\nPlease try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							txt_Password.Clear();
							txt_ConfirmPassword.Clear();
						}
					}
					else
					{
						MessageBox.Show("Email not found!!\nPlease enter correct email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						txt_Email.Clear();
						txt_Password.Clear();
						txt_ConfirmPassword.Clear();
					}
				}
			}
			catch
			{
				MessageBox.Show("Something Problem!!\nPlease try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_Email.Clear();
				txt_Password.Clear();
				txt_ConfirmPassword.Clear();
			}
			finally
			{
				conn.Close();
			}
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
			AdminLogin al=new AdminLogin();
			al.Show();
			this.Hide();
		}

		private void AdminForgetPassword_Load(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.UtcNow.Date;
			txt_Date.Text = dateTime.ToString("dd - MM - yyyy");
		}
	}
}
