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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using CoXBan_tOUR.Admin;
using CoXBan_tOUR.Admin.Add;

namespace CoXBan_tOUR
{
	public partial class AdminPage : Form
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public AdminPage()
		{
			InitializeComponent();

			//HomeController homeController = new HomeController();
			//AddUserControl(homeController);

			CategoryController categoryController = new CategoryController();
			AddUserControl(categoryController);
		}


		//Collect Login Email
		public string AdminEmail;
		public string SetAdminEmail
		{
			get { return AdminEmail; }
			set { AdminEmail = value; }
		}

		//UserControl
		public void AddUserControl(UserControl userControl)
		{
			userControl.Dock = DockStyle.Fill;
			panelContainer.Controls.Clear();
			panelContainer.Controls.Add(userControl);
			userControl.BringToFront();
		}
		private void AdminPage_Load(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.UtcNow.Date;
			txt_Date.Text = dateTime.ToString("dd - MM - yyyy");


			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			try
			{
				SqlCommand command = new SqlCommand("select AdminName from Admin where AdminEmail='" + AdminEmail + "'", conn);
				SqlDataReader dr = command.ExecuteReader();

				if (dr.Read())
				{
					string adminName = dr.GetString(0);
					adminCombobox.Items.Add(adminName);
					adminCombobox.Items.Add("Setting");
					adminCombobox.Items.Add("Logout");
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

		private void Minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void userCombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox cmb = (ComboBox)sender;
			string selectedValue = cmb.SelectedItem as string;

			String userComboboxText = adminCombobox.Text;

			if (selectedValue == "Logout")
			{
				AdminLogin alp = new AdminLogin();
				alp.Show();
				this.Hide();
			}
		}

		private void Home_Click(object sender, EventArgs e)
		{
			HomeController homeController = new HomeController();
			AddUserControl(homeController);

		}

		private void Category_Click(object sender, EventArgs e)
		{
			CategoryController categoryController = new CategoryController();
			AddUserControl(categoryController);
		}

		private void Vehicle_Click(object sender, EventArgs e)
		{
			VehicleController vehicleController = new VehicleController();
			AddUserControl(vehicleController);
		}

		private void Resort_Click(object sender, EventArgs e)
		{
			ResortController resortController = new ResortController();
			AddUserControl(resortController);
		}

		private void ResortRoom_Click(object sender, EventArgs e)
		{
			ResortRoomController resortRoomController = new ResortRoomController();
			AddUserControl(resortRoomController);
		}

		private void TouristPlace_Click(object sender, EventArgs e)
		{
			TouristPlaceController touristPlaceController = new TouristPlaceController();
			AddUserControl(touristPlaceController);
		}

		private void News_Click(object sender, EventArgs e)
		{
			NewsController newsController = new NewsController();
			AddUserControl(newsController);
		}

		private void Admin_Click(object sender, EventArgs e)
		{
			AdminController adminController = new AdminController();
			AddUserControl(adminController);
		}

		private void Customer_Click(object sender, EventArgs e)
		{
			CustomerController customerController = new CustomerController();
			AddUserControl(customerController);
		}

		private void Setting_Click(object sender, EventArgs e)
		{
			SettingController settingController = new SettingController();
			AddUserControl(settingController);
		}

		private void panelContainer_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
