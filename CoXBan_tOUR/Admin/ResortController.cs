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
using TheArtOfDevHtmlRenderer.Adapters;

namespace CoXBan_tOUR.Admin.Add
{
	public partial class ResortController : UserControl
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public ResortController()
		{
			InitializeComponent();
			getCategoryName();
			resortCategory();
			getAllResort();
		}


		public void getCategoryName()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			try
			{
				//SqlCommand command = new SqlCommand("Select CategoryName from Category", conn);
				SqlCommand command = new SqlCommand("Select CategoryName from Category where CategoryName not like '%Bus%' and CategoryName not like '%Car%' and CategoryName not like '%Bike%' and  CategoryName not like '%Chander Gari%' and CategoryName not like '%Jeep%' and CategoryName not like '%Hiace%' and CategoryName not like '%Bicycle%'", conn);
				SqlDataReader dr = command.ExecuteReader();

				while (dr.Read())
				{
					txt_resortCategoryName.Items.Add(dr[0].ToString());
				}
			}
			catch
			{
				MessageBox.Show("Connection Problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}

		public void resortCategory()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();
			try
			{
				SqlCommand command = new SqlCommand("Select CategoryName from Category where CategoryName not like '%Bus%' and CategoryName not like '%Car%' and CategoryName not like '%Bike%' and  CategoryName not like '%Chander Gari%' and CategoryName not like '%Jeep%' and CategoryName not like '%Hiace%' and CategoryName not like '%Bicycle%'", conn);
				SqlDataReader dr = command.ExecuteReader();

				while (dr.Read())
				{
					resortcategory.Items.Add(dr[0].ToString());
				}
			}
			catch
			{
				MessageBox.Show("Vehicle Category not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		public void getAllResort()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			try
			{
				SqlCommand command = new SqlCommand("Select ResortID as ID,ResortName as Name,CategoryName as Category,RDistrict as District,ResortTotalRoom as TotalRoom,ResortLocation as Location,ResortContactNumber as Number from Resort r join Category c on r.CategoryID=c.CategoryID", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable resortTable = new DataTable();
				sda.Fill(resortTable);
				allResortList.DataSource = resortTable;
			}
			catch
			{
				MessageBox.Show("Resort List not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AddResort_Click(object sender, EventArgs e)
		{
			string categoryName, resortName, resortDistrict, resortLocation, resortQuality,resortDescription,resortContactNumber;
			int resortTotalRoom, categoryID;
			Image rImage;

			SqlConnection conn=new SqlConnection(connectionString);
			conn.Open();

			categoryName = txt_resortCategoryName.SelectedItem.ToString();

			try
			{
				SqlCommand command = new SqlCommand("Select CategoryID from Category where CategoryName='" + categoryName + "'", conn);
				SqlDataReader dr=command.ExecuteReader();
				if(dr.Read())
				{
					//categoryID= Convert.ToInt32(dr["CategoryID"]);
					categoryID = dr.GetInt32(0);

					conn.Close();
					resortName = txt_resortName.Text;
					resortDistrict = txt_ResortDIstrict.SelectedItem.ToString();
					resortLocation = txt_ResortLocation.Text;
					resortTotalRoom = (int)Convert.ToInt32(txt_TotalRoom.Text);
					resortQuality = txt_ResortQuality.SelectedItem.ToString();
					resortDescription = txt_ResortDescription.Text;
					resortContactNumber = txt_ResortContactNumber.Text;
					rImage = resortImage.Image;
					conn.Open();

					if(resortName == null || resortDistrict == null || resortLocation == null || resortTotalRoom == 0 || resortQuality == null ||resortDescription == null || resortContactNumber == null)
					{
						MessageBox.Show("Please Insert all the field...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else if(rImage==null)
					{
						MessageBox.Show("Please Select an Image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						using (SqlTransaction resortInsertTransaction=conn.BeginTransaction())
						{
							try
							{
								SqlCommand insertCommand = new SqlCommand("Insert into Resort(CategoryID,ResortName,RDistrict,ResortLocation,ResortTotalRoom,ResortQuality,ResortDescription,ResortContactNumber,ResortImage) values('"+ categoryID + "','"+ resortName + "','"+ resortDistrict + "','"+resortLocation+"','"+ resortTotalRoom + "','"+ resortQuality + "','"+resortDescription+"','"+resortContactNumber+"','"+rImage+"')", conn, resortInsertTransaction);
								insertCommand.ExecuteNonQuery();
								resortInsertTransaction.Commit();

								MessageBox.Show("Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
								txt_resortName.Clear();
								txt_TotalRoom.Clear();
								txt_ResortLocation.Clear();
								txt_ResortContactNumber.Clear();
								txt_ResortDescription.Clear();
								conn.Close();
								getAllResort();
							}
							catch
							{
								MessageBox.Show("Resort Information added Fail..\nPlease try again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								resortInsertTransaction.Rollback();
								conn.Close();
							}

						}
					}
				}
				else
				{
					MessageBox.Show("Category ID not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch
			{
				MessageBox.Show("Something Problem....!!\nPlease try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}
		}

		private void resortImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
			if (opnfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				resortImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
				resortImage.Image = Image.FromFile(opnfd.FileName);
				this.resortImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			}
		}

		private void vehicleSearch_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			string searchText = txt_VehicleSearch.Text;

			try
			{
				SqlCommand command = new SqlCommand("Select ResortID as ID,ResortName as Name,CategoryName as Category,RDistrict as District,ResortTotalRoom as TotalRoom,ResortLocation as Location,ResortContactNumber as Number from Resort r join Category c on r.CategoryID=c.CategoryID where ResortName like '%" + searchText + "%' or RDistrict like '%" + searchText + "%' or ResortLocation like '%" + searchText + "%' or ResortQuality like '%" + searchText + "%' or ResortContactNumber like '%" + searchText + "%'", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				allResortList.DataSource = dt;
			}
			catch
			{
				MessageBox.Show($"{searchText} ??\nDo not found any data!!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				conn.Close();
			}
		}

		private void resortcategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection conn= new SqlConnection(connectionString);
			conn.Open();

			string categoryName=resortcategory.SelectedItem.ToString();

			try
			{
				SqlCommand command = new SqlCommand("Select ResortID as ID,ResortName as Name,CategoryName as Category,RDistrict as District,ResortTotalRoom as TotalRoom,ResortLocation as Location,ResortContactNumber as Number from Resort r join Category c on r.CategoryID=c.CategoryID where CategoryName='" + categoryName +"'", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				allResortList.DataSource = dt;
			}
			catch
			{
				MessageBox.Show($"{categoryName} ??\nData not found","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			getAllResort();
		}

		private void txt_VehicleSearch_TextChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			string searchText = txt_VehicleSearch.Text;

			try
			{
				SqlCommand command = new SqlCommand("Select ResortID as ID,ResortName as Name,CategoryName as Category,RDistrict as District,ResortTotalRoom as TotalRoom,ResortLocation as Location,ResortContactNumber as Number from Resort r join Category c on r.CategoryID=c.CategoryID where ResortName like '%" + searchText + "%' or RDistrict like '%" + searchText + "%' or ResortLocation like '%" + searchText + "%' or ResortQuality like '%" + searchText + "%' or ResortContactNumber like '%" + searchText + "%'", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				allResortList.DataSource = dt;
			}
			catch
			{
				MessageBox.Show($"{searchText} ??\nDo not found any data!!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				conn.Close();
			}
		}
	}
}
