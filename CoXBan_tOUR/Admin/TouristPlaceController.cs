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
	public partial class TouristPlaceController : UserControl
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public TouristPlaceController()
		{
			InitializeComponent();
			getAllTouristPlace();
		}

		public void getAllTouristPlace()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			try
			{
				SqlCommand command = new SqlCommand("select TouristPlaceNo as No, TouristPlaceName as Place,TouristPlaceDistrict as" +
					" District,TouristPlaceThana as Thana,TouristPlaceRating as Rating from TouristPlace", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable touristPlaceTable= new DataTable();
				sda.Fill(touristPlaceTable);
				allTouristPlaceList.DataSource = touristPlaceTable;
			}
			catch
			{
				MessageBox.Show("Something Problem.....!\nData loaded failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			finally
			{ 
				conn.Close(); 
			}
		}
		private void touristPlaceImage1_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
			if (opnfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				touristPlaceImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
				touristPlaceImage1.Image = Image.FromFile(opnfd.FileName);
				this.touristPlaceImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			}
		}

		private void touristPlaceImage2_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
			if (opnfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				touristPlaceImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
				touristPlaceImage2.Image = Image.FromFile(opnfd.FileName);
				this.touristPlaceImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			}
		}

		private void touristPlaceImage3_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
			if (opnfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				touristPlaceImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
				touristPlaceImage3.Image = Image.FromFile(opnfd.FileName);
				this.touristPlaceImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			}
		}

		private void AddResort_Click(object sender, EventArgs e)
		{
			string touristPlaceName, touristPlaceDistrict, touristPlaceThana, touristPlaceLocation, touristPlaceDescription;
			float touristPlaceRating;
			Image touristPlaceImageOne, touristPlaceImageTwo, touristPlaceImageThree;

			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			touristPlaceName = txt_TouristPlaceName.Text;
			touristPlaceDistrict = txt_TouristPlaceDIstrict.SelectedItem.ToString();
			touristPlaceThana = txt_TouristPlaceThana.Text;
			touristPlaceLocation = txt_TouristPlaceLocation.Text;
			touristPlaceDescription = txt_TouristPlaceDescription.Text;
			touristPlaceRating = (float)Convert.ToDecimal(txt_TouristPlaceRating.Text);
			touristPlaceImageOne = touristPlaceImage1.Image;
			touristPlaceImageTwo = touristPlaceImage2.Image;
			touristPlaceImageThree = touristPlaceImage3.Image;

			try
			{
				if(touristPlaceName == null || touristPlaceDistrict == null|| touristPlaceThana == null || touristPlaceLocation == null || touristPlaceDescription == null)
				{
					MessageBox.Show("Please Insert all the field...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else if(touristPlaceImageOne == null && touristPlaceImageTwo == null && touristPlaceImageThree == null)
				{
					MessageBox.Show("Please Select atleast an Image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					using (SqlTransaction touristPlaceInsertTransaction = conn.BeginTransaction())
					{
						try
						{
							SqlCommand insertCommand = new SqlCommand("insert into TouristPlace(TouristPlaceName," +
								"TouristPlaceDistrict,TouristPlaceThana,TouristPLaceLocation,TouristPlaceDescription," +
								"TouristPlaceRating,TouristPlaceFirstImage,TouristPlaceSecondImage,TouristPlaceThirdImage)" +
								"values('"+ touristPlaceName + "','"+ touristPlaceDistrict + "','"+ touristPlaceThana + "'," +
								"'"+ touristPlaceLocation + "','"+ touristPlaceDescription + "','"+ touristPlaceRating + "'," +
								"'"+ touristPlaceImageOne + "','"+ touristPlaceImageTwo+ "','"+ touristPlaceImageThree + "')", conn, touristPlaceInsertTransaction);
							insertCommand.ExecuteNonQuery();
							touristPlaceInsertTransaction.Commit();

							MessageBox.Show("Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
							getAllTouristPlace();
							txt_TouristPlaceName.Clear();
							txt_TouristPlaceThana.Clear();
							txt_TouristPlaceLocation.Clear();
							txt_TouristPlaceDescription.Clear();
							txt_TouristPlaceRating.Clear();

						}
						catch
						{
							MessageBox.Show("Tourist Place Information added Fail..\nPlease try again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							touristPlaceInsertTransaction.Rollback();
							conn.Close();
						}
					}
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

		private void resortcategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			string district = touristPlaceDistrict.SelectedItem.ToString();

			try
			{
				SqlCommand command = new SqlCommand("select TouristPlaceNo as No, TouristPlaceName as Place," +
					"TouristPlaceDistrict as District,TouristPlaceThana as Thana,TouristPlaceRating as Rating " +
					"from TouristPlace where TouristPlaceDistrict='"+ district + "'", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable touristPlaceTable = new DataTable();
				sda.Fill(touristPlaceTable);
				allTouristPlaceList.DataSource = touristPlaceTable;
			}
			catch
			{
				MessageBox.Show("Search Data Not Found","Data Not Found",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}
		}

		private void touristPlaceLoading_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			try
			{
				SqlCommand command = new SqlCommand("select TouristPlaceNo as No, TouristPlaceName as Place,TouristPlaceDistrict as" +
					" District,TouristPlaceThana as Thana,TouristPlaceRating as Rating from TouristPlace", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable touristPlaceTable = new DataTable();
				sda.Fill(touristPlaceTable);
				allTouristPlaceList.DataSource = touristPlaceTable;
			}
			catch
			{
				MessageBox.Show("Something Problem.....!\nData loaded failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			finally
			{
				conn.Close();
			}
		}

		private void txt_TouristPlaceSearch_TextChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			string searchText = txt_TouristPlaceSearch.Text;

			try
			{
				SqlCommand command = new SqlCommand("select TouristPlaceNo as No, TouristPlaceName as Place," +
					"TouristPlaceDistrict as District,TouristPlaceThana as Thana,TouristPlaceRating as Rating " +
					"from TouristPlace where TouristPlaceNo like '%"+searchText+ "%' or  TouristPlaceName like " +
					"'%"+ searchText + "%' or TouristPlaceThana like '%"+ searchText + "%'", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable touristPlaceTable = new DataTable();
				sda.Fill(touristPlaceTable);
				allTouristPlaceList.DataSource = touristPlaceTable;
			}
			catch
			{
				MessageBox.Show("Search Data Not Found", "Data Not Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}
		}

		private void touristPlaceSearch_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			string searchText = txt_TouristPlaceSearch.Text;

			try
			{
				SqlCommand command = new SqlCommand("select TouristPlaceNo as No, TouristPlaceName as Place," +
					"TouristPlaceDistrict as District,TouristPlaceThana as Thana,TouristPlaceRating as Rating " +
					"from TouristPlace where TouristPlaceNo like '%" + searchText + "%' or  TouristPlaceName like " +
					"'%" + searchText + "%' or TouristPlaceThana like '%" + searchText + "%'", conn);
				SqlDataAdapter sda = new SqlDataAdapter(command);
				DataTable touristPlaceTable = new DataTable();
				sda.Fill(touristPlaceTable);
				allTouristPlaceList.DataSource = touristPlaceTable;
			}
			catch
			{
				MessageBox.Show("Search Data Not Found", "Data Not Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}
		}
	}
}
