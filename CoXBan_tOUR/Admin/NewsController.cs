using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace CoXBan_tOUR.Admin.Add
{
	public partial class NewsController : UserControl
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public NewsController()
		{
			InitializeComponent();
		}

		public string AdminEmail;
		public string SetEmail
		{
			get { return AdminEmail; }
			set { AdminEmail = value; }
		}

		private void NewsController_Load(object sender, EventArgs e)
		{
			//DateTime dateTime = DateTime.UtcNow.Date;
			//txt_NewsCurrentDate.Text = dateTime.ToString("dd  MMMM  yyyy");

			txt_NewsCurrentDate.Text = DateTime.Now.ToString("dd  MMMM  yyyy");
			txt_NewsCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss tt");

			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("Select AdminID,AdminName from Admin where AdminEmail='"+AdminEmail+"'",conn);
				SqlDataReader dr=cmd.ExecuteReader();

				if (dr.Read())
				{
					int AdminID = dr.GetInt32(0);
					string AdminName=dr.GetString(1);

					txt_AdminID.Text = AdminID.ToString();
					txt_AdminName.Text = AdminName.ToString();

				}
				else
				{
					MessageBox.Show("Admin Name not found", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				}
			}
			catch
			{
				MessageBox.Show("Something Problem ( AdminEmail )", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}

		}

		private void newsImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
			if (opnfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				newsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
				newsImage.Image = Image.FromFile(opnfd.FileName);
				this.newsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			}
		}

		private void AddResort_Click(object sender, EventArgs e)
		{
			string newsStatus;
			int adminID;
			Image nImage;
			DateTime date = DateTime.Now;
			string currentDate, currentTime;

			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();

			adminID = (int)Convert.ToInt32(txt_AdminID.Text);
			newsStatus = txt_NewsStatus.Text;
			nImage = newsImage.Image;
			currentDate = date.ToLongDateString();
			currentTime=date.ToLongTimeString();

			try
			{
				if (newsStatus == null && nImage == null)
				{
					MessageBox.Show("Choose an image or upload any photo\nPlease try again", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				}
				else
				{
					if(newsStatus == null)
					{
						using(SqlTransaction newsOne=conn.BeginTransaction())
						{
							try
							{
								SqlCommand commandOne = new SqlCommand("Insert into AdminNews(AdminID,NewsDate,NewsTime,NewsImage) " +
									"values('"+ adminID + "','"+ currentDate + "','"+ currentTime + "','"+ nImage + "')", conn, newsOne);
								commandOne.ExecuteNonQuery();
								newsOne.Commit();

								MessageBox.Show("Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
								conn.Close();
							}
							catch
							{
								MessageBox.Show("Resort Information added Fail(without status)..\nPlease try again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								newsOne.Rollback();
								conn.Close();
							}
						}
					}
					else if(nImage == null)
					{
						using (SqlTransaction newsTwo = conn.BeginTransaction())
						{
							try
							{
								SqlCommand commandOne = new SqlCommand("Insert into AdminNews(AdminID,NewsDate,NewsTime,NewsDescription) " +
									"values('" + adminID + "','" + currentDate + "','" + currentTime + "','" + newsStatus + "')", conn, newsTwo);
								commandOne.ExecuteNonQuery();
								newsTwo.Commit();

								MessageBox.Show("Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
								conn.Close();
							}
							catch
							{
								MessageBox.Show("Resort Information added Fail(without image)..\nPlease try again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								newsTwo.Rollback();
								conn.Close();
							}
						}
					}
					else
					{
						using (SqlTransaction newsThree = conn.BeginTransaction())
						{
							try
							{
								SqlCommand commandOne = new SqlCommand("Insert into AdminNews(AdminID,NewsDate,NewsTime,NewsDescription,NewsImage) " +
									"values('" + adminID + "','" + currentDate + "','" + currentTime + "','" + newsStatus + "','"+ nImage + "')", conn, newsThree);
								commandOne.ExecuteNonQuery();
								newsThree.Commit();

								MessageBox.Show("Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
								conn.Close();
							}
							catch
							{
								MessageBox.Show("Resort Information added Fail..\nPlease try again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								newsThree.Rollback();
								conn.Close();
							}
						}
					}
				}
			}
			catch
			{
				MessageBox.Show("Something Problem....!!\nPlease try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}
		}
	}
}
