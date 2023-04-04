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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Data.SqlClient;

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
				SqlCommand command = new SqlCommand("select CategoryID as ID,CategoryNo as No,CategoryName as Category from Category", conn);
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

		
		private void ImageUploadButton_Click(object sender, EventArgs e)
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
	}
}
