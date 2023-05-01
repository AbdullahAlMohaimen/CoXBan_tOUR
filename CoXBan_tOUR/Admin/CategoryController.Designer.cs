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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_CategoryName = new MaterialSkin.Controls.MaterialTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.AddCategory = new System.Windows.Forms.Button();
			this.allCategoryList = new Guna.UI2.WinForms.Guna2DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.allList = new Guna.UI2.WinForms.Guna2DataGridView();
			this.UpdateCategory = new System.Windows.Forms.Button();
			this.txt_CategorySearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.Search = new Guna.UI2.WinForms.Guna2CircleButton();
			this.CategoryImage = new System.Windows.Forms.PictureBox();
			this.categoryRefresh = new Guna.UI2.WinForms.Guna2CircleButton();
			this.category = new Guna.UI2.WinForms.Guna2ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.allCategoryList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.allList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CategoryImage)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SeaGreen;
			this.panel1.Location = new System.Drawing.Point(0, 276);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1032, 2);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(20, 9);
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
			this.label2.Location = new System.Drawing.Point(20, 45);
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
			this.txt_CategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_CategoryName.Hint = "Enter Category Name";
			this.txt_CategoryName.LeadingIcon = null;
			this.txt_CategoryName.Location = new System.Drawing.Point(23, 69);
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
			this.label3.Location = new System.Drawing.Point(20, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 21);
			this.label3.TabIndex = 9;
			this.label3.Text = "Category Image";
			// 
			// AddCategory
			// 
			this.AddCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AddCategory.BackColor = System.Drawing.Color.Brown;
			this.AddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddCategory.Location = new System.Drawing.Point(150, 199);
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
			this.allCategoryList.Location = new System.Drawing.Point(349, 32);
			this.allCategoryList.Name = "allCategoryList";
			this.allCategoryList.ReadOnly = true;
			this.allCategoryList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.allCategoryList.RowHeadersVisible = false;
			this.allCategoryList.RowHeadersWidth = 40;
			this.allCategoryList.RowTemplate.Height = 28;
			this.allCategoryList.RowTemplate.ReadOnly = true;
			this.allCategoryList.Size = new System.Drawing.Size(659, 227);
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
			this.allCategoryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allCategoryList_CellContentClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkGreen;
			this.panel2.Location = new System.Drawing.Point(20, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(228, 2);
			this.panel2.TabIndex = 31;
			// 
			// allList
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.allList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.allList.BackgroundColor = System.Drawing.Color.Moccasin;
			this.allList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.allList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.allList.ColumnHeadersHeight = 28;
			this.allList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.allList.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.allList.DefaultCellStyle = dataGridViewCellStyle6;
			this.allList.EnableHeadersVisualStyles = true;
			this.allList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allList.Location = new System.Drawing.Point(24, 328);
			this.allList.Name = "allList";
			this.allList.ReadOnly = true;
			this.allList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.allList.RowHeadersVisible = false;
			this.allList.RowHeadersWidth = 40;
			this.allList.RowTemplate.Height = 28;
			this.allList.RowTemplate.ReadOnly = true;
			this.allList.Size = new System.Drawing.Size(984, 335);
			this.allList.TabIndex = 32;
			this.allList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.allList.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.allList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.allList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.allList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.allList.ThemeStyle.BackColor = System.Drawing.Color.Moccasin;
			this.allList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.allList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
			this.allList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.allList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.allList.ThemeStyle.HeaderStyle.Height = 28;
			this.allList.ThemeStyle.ReadOnly = true;
			this.allList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.allList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.allList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.allList.ThemeStyle.RowsStyle.Height = 28;
			this.allList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// UpdateCategory
			// 
			this.UpdateCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.UpdateCategory.BackColor = System.Drawing.Color.Brown;
			this.UpdateCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.UpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.UpdateCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateCategory.Location = new System.Drawing.Point(150, 232);
			this.UpdateCategory.Name = "UpdateCategory";
			this.UpdateCategory.Size = new System.Drawing.Size(173, 27);
			this.UpdateCategory.TabIndex = 33;
			this.UpdateCategory.Text = "Update Category";
			this.UpdateCategory.UseVisualStyleBackColor = false;
			// 
			// txt_CategorySearch
			// 
			this.txt_CategorySearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_CategorySearch.BorderRadius = 1;
			this.txt_CategorySearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.txt_CategorySearch.BorderThickness = 2;
			this.txt_CategorySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_CategorySearch.DefaultText = "";
			this.txt_CategorySearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_CategorySearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_CategorySearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_CategorySearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_CategorySearch.FillColor = System.Drawing.Color.Moccasin;
			this.txt_CategorySearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_CategorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_CategorySearch.ForeColor = System.Drawing.Color.Black;
			this.txt_CategorySearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_CategorySearch.Location = new System.Drawing.Point(792, 285);
			this.txt_CategorySearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.txt_CategorySearch.Name = "txt_CategorySearch";
			this.txt_CategorySearch.PasswordChar = '\0';
			this.txt_CategorySearch.PlaceholderText = "";
			this.txt_CategorySearch.SelectedText = "";
			this.txt_CategorySearch.Size = new System.Drawing.Size(162, 36);
			this.txt_CategorySearch.TabIndex = 35;
			this.txt_CategorySearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Search
			// 
			this.Search.BorderColor = System.Drawing.Color.Moccasin;
			this.Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.Search.FillColor = System.Drawing.Color.Moccasin;
			this.Search.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Search.ForeColor = System.Drawing.Color.White;
			this.Search.Image = global::CoXBan_tOUR.Properties.Resources.transparency;
			this.Search.ImageSize = new System.Drawing.Size(30, 30);
			this.Search.Location = new System.Drawing.Point(962, 290);
			this.Search.Name = "Search";
			this.Search.PressedColor = System.Drawing.Color.Moccasin;
			this.Search.ShadowDecoration.Color = System.Drawing.Color.Moccasin;
			this.Search.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.Search.Size = new System.Drawing.Size(37, 30);
			this.Search.TabIndex = 36;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// CategoryImage
			// 
			this.CategoryImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.CategoryImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.CategoryImage.Location = new System.Drawing.Point(24, 146);
			this.CategoryImage.Name = "CategoryImage";
			this.CategoryImage.Size = new System.Drawing.Size(113, 113);
			this.CategoryImage.TabIndex = 21;
			this.CategoryImage.TabStop = false;
			this.CategoryImage.Click += new System.EventHandler(this.CategoryImage_Click);
			// 
			// categoryRefresh
			// 
			this.categoryRefresh.BorderColor = System.Drawing.Color.Moccasin;
			this.categoryRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.categoryRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.categoryRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.categoryRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.categoryRefresh.FillColor = System.Drawing.Color.Moccasin;
			this.categoryRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.categoryRefresh.ForeColor = System.Drawing.Color.White;
			this.categoryRefresh.Image = global::CoXBan_tOUR.Properties.Resources.refresh;
			this.categoryRefresh.ImageSize = new System.Drawing.Size(30, 30);
			this.categoryRefresh.Location = new System.Drawing.Point(24, 290);
			this.categoryRefresh.Name = "categoryRefresh";
			this.categoryRefresh.PressedColor = System.Drawing.Color.Moccasin;
			this.categoryRefresh.ShadowDecoration.Color = System.Drawing.Color.Moccasin;
			this.categoryRefresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.categoryRefresh.Size = new System.Drawing.Size(37, 30);
			this.categoryRefresh.TabIndex = 37;
			this.categoryRefresh.Click += new System.EventHandler(this.categoryRefresh_Click);
			// 
			// category
			// 
			this.category.BackColor = System.Drawing.Color.Moccasin;
			this.category.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.category.BorderRadius = 8;
			this.category.BorderThickness = 0;
			this.category.Cursor = System.Windows.Forms.Cursors.Hand;
			this.category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.category.DropDownHeight = 150;
			this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.category.DropDownWidth = 120;
			this.category.FillColor = System.Drawing.Color.Moccasin;
			this.category.FocusedColor = System.Drawing.Color.Empty;
			this.category.FocusedState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.category.FocusedState.ForeColor = System.Drawing.Color.Black;
			this.category.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.category.HoverState.FillColor = System.Drawing.Color.Brown;
			this.category.HoverState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.category.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.category.IntegralHeight = false;
			this.category.ItemHeight = 28;
			this.category.Location = new System.Drawing.Point(565, 287);
			this.category.MaxDropDownItems = 5;
			this.category.Name = "category";
			this.category.ShadowDecoration.Color = System.Drawing.Color.Gray;
			this.category.Size = new System.Drawing.Size(219, 34);
			this.category.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.category.TabIndex = 72;
			this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
			// 
			// CategoryController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.Controls.Add(this.category);
			this.Controls.Add(this.categoryRefresh);
			this.Controls.Add(this.Search);
			this.Controls.Add(this.txt_CategorySearch);
			this.Controls.Add(this.UpdateCategory);
			this.Controls.Add(this.allList);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.allCategoryList);
			this.Controls.Add(this.AddCategory);
			this.Controls.Add(this.CategoryImage);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_CategoryName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "CategoryController";
			this.Size = new System.Drawing.Size(1032, 678);
			this.Load += new System.EventHandler(this.CategoryController_Load);
			((System.ComponentModel.ISupportInitialize)(this.allCategoryList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.allList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CategoryImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private MaterialSkin.Controls.MaterialTextBox txt_CategoryName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox CategoryImage;
		private System.Windows.Forms.Button AddCategory;
		private Guna.UI2.WinForms.Guna2DataGridView allCategoryList;
		private System.Windows.Forms.Panel panel2;
		private Guna.UI2.WinForms.Guna2DataGridView allList;
		private System.Windows.Forms.Button UpdateCategory;
		private Guna.UI2.WinForms.Guna2TextBox txt_CategorySearch;
		private Guna.UI2.WinForms.Guna2CircleButton Search;
		private Guna.UI2.WinForms.Guna2CircleButton categoryRefresh;
		private Guna.UI2.WinForms.Guna2ComboBox category;
	}
}
