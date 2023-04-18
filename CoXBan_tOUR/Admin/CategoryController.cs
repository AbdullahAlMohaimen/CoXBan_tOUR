using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoXBan_tOUR.Admin.Add
{
	public partial class CategoryController : UserControl
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public CategoryController()
		{
			InitializeComponent();

			//defined
			getAllCategory();
		}

		public void getAllCategory()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();
			try
			{
				SqlCommand command = new SqlCommand("select CategoryID as ID,CategoryNo as CategoryNo,CategoryName as Category from Category", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable dataTable = new DataTable();
				sda.Fill(dataTable);
				allCategoryList.DataSource = dataTable;
			}
			catch
			{
				MessageBox.Show("Category List not Found!!");
			}
			finally
			{
				conn.Close();
			}
		}
		private void CategoryController_Load(object sender, EventArgs e)
		{

		}


		private void AddCategory_Click(object sender, EventArgs e)
		{
			string categoryName;
			Image categoryImage;

			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			categoryName = txt_CategoryName.Text;
			categoryImage = CategoryImage.Image;

			try
			{
				if(categoryName =="")
				{
					MessageBox.Show("Please enter a Category Name!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txt_CategoryName.Clear();
				}
				else if(categoryImage==null)
				{
					MessageBox.Show("Please Choose a Correct Image", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					SqlCommand cmd = new SqlCommand("Insert into Category(CategoryName,CategoryImage) values('" + categoryName + "','" + categoryImage + "') ", conn);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
					txt_CategoryName.Clear();
					getAllCategory();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something Problem\nPlease try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}
		}

		private void allCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			int categoryid = (int)Convert.ToDouble(allCategoryList.CurrentRow.Cells[0].Value);

			try
			{
				SqlCommand command = new SqlCommand("select CategoryName,CategoryImage from Category where CategoryID='" + categoryid + "'",conn);
				SqlDataReader dr=command.ExecuteReader();

				if (dr.Read())
				{
					string categoryName = dr.GetString(0);
					txt_CategoryName.Text = Convert.ToString(categoryName);


					CategoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
					this.CategoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

					conn.Close() ;
					if (categoryName == "Car" || categoryName == "Hiace" || categoryName == "Bus" || categoryName == "Jeep" || categoryName == "Bike" || categoryName == "Bicycle" || categoryName == "Chander Gari" || categoryName == "Boat")
					{
						conn.Open();
						try
						{
							SqlCommand vehicleCommand = new SqlCommand("Select CategoryName as Category,VehicleName as Name,CategoryNo as cNO,VehicleNo as vNo,VDistrict as  District,VehicleTotalSeat as Seat,VehicleRentPrice as Price from Category c join Vehicle v on c.CategoryID=v.CategoryID where CategoryName='" + categoryName + "'", conn);
							SqlDataAdapter cSDA = new SqlDataAdapter(vehicleCommand);
							DataTable cTable = new DataTable();
							cSDA.Fill(cTable);
							allList.DataSource = cTable;
							conn.Close();
						}
						catch
						{
							MessageBox.Show("VEHICLE category not found.\nSomething Problem.....!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							conn.Close();
						}
					}
					else if (categoryName == "Hotel" || categoryName == "Beach Resort" || categoryName == "Hill Resort")
					{
						conn.Open();
						try
						{
							SqlCommand resortCommand = new SqlCommand("Select CategoryName as Category,ResortName as Name,CategoryNo as cNO,ResortNo as rNo,RDistrict as  District,ResortTotalRoom as Room,ResortQuality as Quality from Category c join Resort r on c.CategoryID=r.CategoryID where CategoryName='" + categoryName + "'", conn);
							SqlDataAdapter rSDA = new SqlDataAdapter(resortCommand);
							DataTable rTable = new DataTable();
							rSDA.Fill(rTable);
							allList.DataSource = rTable;
							conn.Close();
						}
						catch
						{
							MessageBox.Show("RESORT category not found.\nSomething Problem.....!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							conn.Close();
						}
					}
					else
					{
						MessageBox.Show($"{categoryName} category not found.\nSomething Problem.....!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						conn.Close();
					}
				}

				/*SqlDataAdapter da = new SqlDataAdapter(command);
				DataSet ds = new DataSet();
				da.Fill(ds);

				MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0][0]);
				CategoryImage.Image = new Bitmap(ms);*/
			}
			catch
			{
				MessageBox.Show("Data not found!!\nSomething Problem...Please try again!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close() ;
			}
		}

		private void Search_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			string categoryName;
			categoryName=txt_CategorySearch.Text;

			try
			{
				SqlCommand command = new SqlCommand("Select * from Category where CategoryName='"+categoryName+"'",conn);
				SqlDataReader dr=command.ExecuteReader();
				if (dr.Read())
				{
					string cName = dr.GetString(2);
					conn.Close();

					if (cName == "Car" || cName == "Hiace" || cName == "Bus" || cName == "Jeep" || cName == "Bike" || cName == "Bicycle" || cName == "Chander Gari" || cName == "Boat")
					{
						conn.Open();
						try
						{
							SqlCommand vehicleCommand = new SqlCommand("Select CategoryName as Category,VehicleName as Name,CategoryNo as cNO,VehicleNo as vNo,VDistrict as  District,VehicleTotalSeat as Seat,VehicleRentPrice as Price from Category c join Vehicle v on c.CategoryID=v.CategoryID where CategoryName='" + categoryName + "'", conn);
							SqlDataAdapter cSDA = new SqlDataAdapter(vehicleCommand);
							DataTable cTable = new DataTable();
							cSDA.Fill(cTable);
							allList.DataSource = cTable;
							conn.Close();
						}
						catch
						{
							MessageBox.Show("VEHICLE category not found.\nSomething Problem.....!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							conn.Close();
						}
					}
					else if (cName == "Hotel" || cName == "Beach Resort" || cName == "Hill Resort")
					{
						conn.Open();
						try
						{
							SqlCommand resortCommand = new SqlCommand("Select CategoryName as Category,ResortName as Name,CategoryNo as cNO,ResortNo as rNo,RDistrict as  District,ResortTotalRoom as Room,ResortQuality as Quality from Category c join Resort r on c.CategoryID=r.CategoryID where CategoryName='" + categoryName + "'", conn);
							SqlDataAdapter rSDA= new SqlDataAdapter(resortCommand);
							DataTable rTable = new DataTable();
							rSDA.Fill(rTable);
							allList.DataSource = rTable;
							conn.Close() ;
						}
						catch
						{
							MessageBox.Show("RESORT category not found.\nSomething Problem.....!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							conn.Close();
						}
					}
					else
					{
						MessageBox.Show($"{categoryName} category not found.\nSomething Problem.....!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						conn.Close();
					}

				}
			}
			catch
			{
				MessageBox.Show("Something Problem...!\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close() ;
			}
		}

		private void CategoryImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
			if (opnfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				CategoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
				CategoryImage.Image = Image.FromFile(opnfd.FileName);
				this.CategoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			}
		}

		private void categoryRefresh_Click(object sender, EventArgs e)
		{
			getAllCategory();
		}
	}
}
