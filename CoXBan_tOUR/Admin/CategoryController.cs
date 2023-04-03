using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoXBan_tOUR.Admin.Add
{
	public partial class CategoryController : UserControl
	{
		public CategoryController()
		{
			InitializeComponent();
		}

		private void CategoryController_Load(object sender, EventArgs e)
		{

		}

		private void ImageUploadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
			if (opnfd.ShowDialog() == DialogResult.OK)
			{
				CategoryImage.Image = new Bitmap(opnfd.FileName);
			}
		}
	}
}
