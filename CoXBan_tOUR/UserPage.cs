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
	public partial class UserPage : Form
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public UserPage()
		{
			InitializeComponent();
		}

		//Collect Login Email
		public string Email;
		public string SetEmail
		{
			get { return Email; }
			set { Email = value; }
		}

		private void UserPage_Load(object sender, EventArgs e)
		{
			//CURRENT DATE
			DateTime dateTime = DateTime.UtcNow.Date;
			txt_Date.Text = dateTime.ToString("dd - MM - yyyy");


			//
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();
			try
			{
				SqlCommand command = new SqlCommand("select CustomerName from Customer where CustomerEmail='" + Email + "'", conn);
				SqlDataReader dr = command.ExecuteReader();

				if (dr.Read())
				{
					string userName = dr.GetString(0);
					userCombobox.Items.Add(userName);
					userCombobox.Items.Add("Profile");
					userCombobox.Items.Add("Setting");
					userCombobox.Items.Add("Logout");
				}
			}
			catch
			{
				MessageBox.Show("Something Problem!");
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

		private void button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void userCombobox_SelectedIndexChanged(object sender, EventArgs e)
		{

			ComboBox cmb = (ComboBox)sender;
			string selectedValue = cmb.SelectedItem as string;

			String userComboboxText = userCombobox.Text;

			if(selectedValue == "Logout")
			{
				UserLoginPage ulp= new UserLoginPage();
				ulp.Show();
				this.Hide();
			}
		}
	}
}
