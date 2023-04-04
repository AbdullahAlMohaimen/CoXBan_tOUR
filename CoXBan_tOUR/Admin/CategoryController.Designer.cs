namespace CoXBan_tOUR.Admin.Add
{
	partial class CategoryController
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_CategoryName = new MaterialSkin.Controls.MaterialTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ImageUploadButton = new System.Windows.Forms.Button();
			this.CategoryImage = new System.Windows.Forms.PictureBox();
			this.AddCategory = new System.Windows.Forms.Button();
			this.allCategoryList = new Guna.UI2.WinForms.Guna2DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.CategoryImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.allCategoryList)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SeaGreen;
			this.panel1.Location = new System.Drawing.Point(0, 240);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(886, 2);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(643, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Add a New Category";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(20, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Category Name";
			// 
			// txt_CategoryName
			// 
			this.txt_CategoryName.AnimateReadOnly = false;
			this.txt_CategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_CategoryName.Depth = 0;
			this.txt_CategoryName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txt_CategoryName.LeadingIcon = null;
			this.txt_CategoryName.Location = new System.Drawing.Point(23, 41);
			this.txt_CategoryName.MaxLength = 50;
			this.txt_CategoryName.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_CategoryName.Multiline = false;
			this.txt_CategoryName.Name = "txt_CategoryName";
			this.txt_CategoryName.Size = new System.Drawing.Size(300, 50);
			this.txt_CategoryName.TabIndex = 8;
			this.txt_CategoryName.Text = "";
			this.txt_CategoryName.TrailingIcon = null;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(20, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 21);
			this.label3.TabIndex = 9;
			this.label3.Text = "Category Image";
			// 
			// ImageUploadButton
			// 
			this.ImageUploadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ImageUploadButton.BackColor = System.Drawing.Color.Brown;
			this.ImageUploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImageUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ImageUploadButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ImageUploadButton.Location = new System.Drawing.Point(150, 141);
			this.ImageUploadButton.Name = "ImageUploadButton";
			this.ImageUploadButton.Size = new System.Drawing.Size(104, 27);
			this.ImageUploadButton.TabIndex = 20;
			this.ImageUploadButton.Text = "Upload Image";
			this.ImageUploadButton.UseVisualStyleBackColor = false;
			this.ImageUploadButton.Click += new System.EventHandler(this.ImageUploadButton_Click);
			// 
			// CategoryImage
			// 
			this.CategoryImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.CategoryImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.CategoryImage.Location = new System.Drawing.Point(24, 118);
			this.CategoryImage.Name = "CategoryImage";
			this.CategoryImage.Size = new System.Drawing.Size(90, 90);
			this.CategoryImage.TabIndex = 21;
			this.CategoryImage.TabStop = false;
			// 
			// AddCategory
			// 
			this.AddCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AddCategory.BackColor = System.Drawing.Color.Brown;
			this.AddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddCategory.Location = new System.Drawing.Point(150, 181);
			this.AddCategory.Name = "AddCategory";
			this.AddCategory.Size = new System.Drawing.Size(173, 27);
			this.AddCategory.TabIndex = 22;
			this.AddCategory.Text = "Add Category";
			this.AddCategory.UseVisualStyleBackColor = false;
			this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
			// 
			// allCategoryList
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.allCategoryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.allCategoryList.BackgroundColor = System.Drawing.Color.Moccasin;
			this.allCategoryList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.allCategoryList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allCategoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.allCategoryList.ColumnHeadersHeight = 28;
			this.allCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.allCategoryList.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.allCategoryList.DefaultCellStyle = dataGridViewCellStyle3;
			this.allCategoryList.EnableHeadersVisualStyles = true;
			this.allCategoryList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allCategoryList.Location = new System.Drawing.Point(24, 249);
			this.allCategoryList.Name = "allCategoryList";
			this.allCategoryList.ReadOnly = true;
			this.allCategoryList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.allCategoryList.RowHeadersWidth = 40;
			this.allCategoryList.RowTemplate.Height = 28;
			this.allCategoryList.RowTemplate.ReadOnly = true;
			this.allCategoryList.Size = new System.Drawing.Size(443, 290);
			this.allCategoryList.TabIndex = 30;
			this.allCategoryList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.allCategoryList.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.allCategoryList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.allCategoryList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.allCategoryList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.allCategoryList.ThemeStyle.BackColor = System.Drawing.Color.Moccasin;
			this.allCategoryList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allCategoryList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.allCategoryList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
			this.allCategoryList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allCategoryList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.allCategoryList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.allCategoryList.ThemeStyle.HeaderStyle.Height = 28;
			this.allCategoryList.ThemeStyle.ReadOnly = true;
			this.allCategoryList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.allCategoryList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.allCategoryList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allCategoryList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.allCategoryList.ThemeStyle.RowsStyle.Height = 28;
			this.allCategoryList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allCategoryList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// CategoryController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.Controls.Add(this.allCategoryList);
			this.Controls.Add(this.AddCategory);
			this.Controls.Add(this.CategoryImage);
			this.Controls.Add(this.ImageUploadButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_CategoryName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "CategoryController";
			this.Size = new System.Drawing.Size(886, 552);
			this.Load += new System.EventHandler(this.CategoryController_Load);
			((System.ComponentModel.ISupportInitialize)(this.CategoryImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.allCategoryList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private MaterialSkin.Controls.MaterialTextBox txt_CategoryName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ImageUploadButton;
		private System.Windows.Forms.PictureBox CategoryImage;
		private System.Windows.Forms.Button AddCategory;
		private Guna.UI2.WinForms.Guna2DataGridView allCategoryList;
	}
}
