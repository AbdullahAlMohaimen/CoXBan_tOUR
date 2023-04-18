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

namespace CoXBan_tOUR.Admin.Add
{
	public partial class VehicleController : UserControl
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public VehicleController()
		{
			InitializeComponent();
			getCategoryName();
			getAllVehicle();
		}

		private void VehicleController_Load(object sender, EventArgs e)
		{

			
		}

		public void getCategoryName()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			try
			{
				SqlCommand command = new SqlCommand("Select CategoryName from Category", conn);
				SqlDataReader dr = command.ExecuteReader();

				while (dr.Read())
				{
					txt_categoryName.Items.Add(dr[0].ToString());
				}
			}
			catch
			{
				MessageBox.Show("Connection Problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}

		public void getAllVehicle()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			try
			{
				SqlCommand command = new SqlCommand("Select VehicleID as ID,VehicleName as Name,CategoryName as Category,VDistrict as District,VehicleTotalSeat as TotalSeat,VehicleRentPrice as RentPrice from Vehicle v join Category c on v.CategoryID=c.CategoryID", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable vehicleTable= new DataTable();
				sda.Fill(vehicleTable);
				allVehicleList.DataSource= vehicleTable;
			}
			catch
			{
				MessageBox.Show("Vehicle List not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		private void vehicleImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
			if (opnfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				vehicleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
				vehicleImage.Image = Image.FromFile(opnfd.FileName);
				this.vehicleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			}
		}

		private void AddVehicle_Click(object sender, EventArgs e)
		{
			string categoryName, vehicleName, vehicleDistrict, vehicleLicenseNo, vehicleStatus;
			int vehicleTotalSeat,categoryID;
			float vehicleRentPrice;
			Image vImage;

			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			categoryName = txt_categoryName.Text;


			try
			{
				SqlCommand command = new SqlCommand("Select CategoryID from Category where CategoryName='" + categoryName + "'", conn);
				SqlDataReader dr=command.ExecuteReader();
				if (dr.Read())
				{
					categoryID = dr.GetInt32(0);

					conn.Close();
					vehicleName = txt_VehicleName.Text;
					vehicleDistrict = txt_VehicleDIstrict.Text;
					vehicleLicenseNo= txt_LicenseNumber.Text;
					vehicleStatus = txt_VehicleStatus.Text;
					vehicleTotalSeat = (int)Convert.ToInt32(txt_TotalSeat.Text);
					vehicleRentPrice = (float)Convert.ToDecimal(txt_RentPrice.Text);
					vImage = vehicleImage.Image;
					conn.Open();

					if(vehicleName == "" || vehicleDistrict == "" || vehicleLicenseNo == "" || vehicleStatus == "" || vehicleTotalSeat == null || vehicleRentPrice == null)
					{
						MessageBox.Show("Please Insert all the field...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else if( vImage == null)
					{
						MessageBox.Show("Please Select an Image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						using (SqlTransaction vehicleInsertTransaction = conn.BeginTransaction())
						{
							try
							{
								SqlCommand insertCommand = new SqlCommand("Insert into Vehicle(CategoryID,VehicleName,VDistrict,VehicleLicenseNo,VehicleTotalSeat,VehicleRentPrice,VehicleStatus,VehicleImage) values ('"+categoryID+"','"+vehicleName+"','"+ vehicleDistrict + "','"+ vehicleLicenseNo + "','"+ vehicleTotalSeat + "','"+ vehicleRentPrice + "','"+ vehicleStatus + "','"+ vImage + "')", conn,vehicleInsertTransaction);
								insertCommand.ExecuteNonQuery();
								vehicleInsertTransaction.Commit();

								MessageBox.Show("Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
								txt_VehicleName.Clear();
								txt_TotalSeat.Clear();
								txt_LicenseNumber.Clear();
								txt_RentPrice.Clear();
								conn.Close();
								getAllVehicle();
							}
							catch
							{
								MessageBox.Show("Vehicle Information added Fail..\nPlease try again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								vehicleInsertTransaction.Rollback();
								conn.Close();
							}
						}
					}

				}
				else
				{
					MessageBox.Show("Category ID not found","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				}
			}
			catch
			{
				MessageBox.Show("Something Problem....!!\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}
			
		}

		private void vehicleSearch_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			string searchText = txt_VehicleSearch.Text;

			try
			{
				SqlCommand command = new SqlCommand("Select VehicleID as ID,VehicleName as Name,CategoryName as Category,VDistrict as District,VehicleTotalSeat as TotalSeat,VehicleRentPrice as RentPrice from Vehicle v join Category c on v.CategoryID=c.CategoryID where CategoryName='"+searchText+"'", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				allVehicleList.DataSource= dt;
			}
			catch
			{

			}
			finally
			{
				conn.Close();
			}
		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			getAllVehicle();
		}
	}
}
