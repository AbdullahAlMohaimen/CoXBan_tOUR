namespace CoXBan_tOUR.Admin.Add
{
	partial class TouristPlaceController
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt_TouristPlaceName = new MaterialSkin.Controls.MaterialTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.allTouristPlaceList = new Guna.UI2.WinForms.Guna2DataGridView();
			this.touristPlaceLoading = new Guna.UI2.WinForms.Guna2CircleButton();
			this.touristPlaceDistrict = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txt_TouristPlaceSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.touristPlaceSearch = new Guna.UI2.WinForms.Guna2CircleButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_TouristPlaceThana = new MaterialSkin.Controls.MaterialTextBox();
			this.txt_TouristPlaceDIstrict = new MaterialSkin.Controls.MaterialComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_TouristPlaceDescription = new MaterialSkin.Controls.MaterialTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.touristPlaceImage1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.touristPlaceImage2 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.touristPlaceImage3 = new System.Windows.Forms.PictureBox();
			this.UpdateResort = new System.Windows.Forms.Button();
			this.AddResort = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_TouristPlaceLocation = new MaterialSkin.Controls.MaterialTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_TouristPlaceRating = new MaterialSkin.Controls.MaterialTextBox();
			((System.ComponentModel.ISupportInitialize)(this.allTouristPlaceList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.touristPlaceImage1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.touristPlaceImage2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.touristPlaceImage3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SeaGreen;
			this.panel1.Location = new System.Drawing.Point(0, 276);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1032, 2);
			this.panel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(20, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(274, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Add a New Tourist Place";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkGreen;
			this.panel2.Location = new System.Drawing.Point(20, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(280, 2);
			this.panel2.TabIndex = 34;
			// 
			// txt_TouristPlaceName
			// 
			this.txt_TouristPlaceName.AnimateReadOnly = false;
			this.txt_TouristPlaceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_TouristPlaceName.Depth = 0;
			this.txt_TouristPlaceName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txt_TouristPlaceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_TouristPlaceName.Hint = "Enter Tourist Place Name";
			this.txt_TouristPlaceName.LeadingIcon = null;
			this.txt_TouristPlaceName.Location = new System.Drawing.Point(23, 69);
			this.txt_TouristPlaceName.MaxLength = 50;
			this.txt_TouristPlaceName.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_TouristPlaceName.Multiline = false;
			this.txt_TouristPlaceName.Name = "txt_TouristPlaceName";
			this.txt_TouristPlaceName.Size = new System.Drawing.Size(230, 50);
			this.txt_TouristPlaceName.TabIndex = 44;
			this.txt_TouristPlaceName.Text = "";
			this.txt_TouristPlaceName.TrailingIcon = null;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label4.Location = new System.Drawing.Point(20, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 21);
			this.label4.TabIndex = 43;
			this.label4.Text = "Tourist Place Name";
			// 
			// allTouristPlaceList
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.allTouristPlaceList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.allTouristPlaceList.BackgroundColor = System.Drawing.Color.Moccasin;
			this.allTouristPlaceList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.allTouristPlaceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Moccasin;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allTouristPlaceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.allTouristPlaceList.ColumnHeadersHeight = 28;
			this.allTouristPlaceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.allTouristPlaceList.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.allTouristPlaceList.DefaultCellStyle = dataGridViewCellStyle9;
			this.allTouristPlaceList.EnableHeadersVisualStyles = true;
			this.allTouristPlaceList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allTouristPlaceList.Location = new System.Drawing.Point(24, 328);
			this.allTouristPlaceList.Name = "allTouristPlaceList";
			this.allTouristPlaceList.ReadOnly = true;
			this.allTouristPlaceList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.allTouristPlaceList.RowHeadersVisible = false;
			this.allTouristPlaceList.RowHeadersWidth = 40;
			this.allTouristPlaceList.RowTemplate.Height = 28;
			this.allTouristPlaceList.RowTemplate.ReadOnly = true;
			this.allTouristPlaceList.Size = new System.Drawing.Size(984, 335);
			this.allTouristPlaceList.TabIndex = 71;
			this.allTouristPlaceList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.allTouristPlaceList.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.allTouristPlaceList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.allTouristPlaceList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.allTouristPlaceList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.allTouristPlaceList.ThemeStyle.BackColor = System.Drawing.Color.Moccasin;
			this.allTouristPlaceList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allTouristPlaceList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.allTouristPlaceList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
			this.allTouristPlaceList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allTouristPlaceList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.allTouristPlaceList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.allTouristPlaceList.ThemeStyle.HeaderStyle.Height = 28;
			this.allTouristPlaceList.ThemeStyle.ReadOnly = true;
			this.allTouristPlaceList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.allTouristPlaceList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.allTouristPlaceList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allTouristPlaceList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.allTouristPlaceList.ThemeStyle.RowsStyle.Height = 28;
			this.allTouristPlaceList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allTouristPlaceList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// touristPlaceLoading
			// 
			this.touristPlaceLoading.BorderColor = System.Drawing.Color.Moccasin;
			this.touristPlaceLoading.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.touristPlaceLoading.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.touristPlaceLoading.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.touristPlaceLoading.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.touristPlaceLoading.FillColor = System.Drawing.Color.Moccasin;
			this.touristPlaceLoading.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.touristPlaceLoading.ForeColor = System.Drawing.Color.White;
			this.touristPlaceLoading.Image = global::CoXBan_tOUR.Properties.Resources.refresh;
			this.touristPlaceLoading.ImageSize = new System.Drawing.Size(30, 30);
			this.touristPlaceLoading.Location = new System.Drawing.Point(24, 290);
			this.touristPlaceLoading.Name = "touristPlaceLoading";
			this.touristPlaceLoading.PressedColor = System.Drawing.Color.Moccasin;
			this.touristPlaceLoading.ShadowDecoration.Color = System.Drawing.Color.Moccasin;
			this.touristPlaceLoading.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.touristPlaceLoading.Size = new System.Drawing.Size(37, 30);
			this.touristPlaceLoading.TabIndex = 72;
			this.touristPlaceLoading.Click += new System.EventHandler(this.touristPlaceLoading_Click);
			// 
			// touristPlaceDistrict
			// 
			this.touristPlaceDistrict.BackColor = System.Drawing.Color.Moccasin;
			this.touristPlaceDistrict.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.touristPlaceDistrict.BorderRadius = 8;
			this.touristPlaceDistrict.BorderThickness = 0;
			this.touristPlaceDistrict.Cursor = System.Windows.Forms.Cursors.Hand;
			this.touristPlaceDistrict.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.touristPlaceDistrict.DropDownHeight = 150;
			this.touristPlaceDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.touristPlaceDistrict.DropDownWidth = 120;
			this.touristPlaceDistrict.FillColor = System.Drawing.Color.Moccasin;
			this.touristPlaceDistrict.FocusedColor = System.Drawing.Color.Empty;
			this.touristPlaceDistrict.FocusedState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.touristPlaceDistrict.FocusedState.ForeColor = System.Drawing.Color.Black;
			this.touristPlaceDistrict.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.touristPlaceDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.touristPlaceDistrict.HoverState.FillColor = System.Drawing.Color.Brown;
			this.touristPlaceDistrict.HoverState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.touristPlaceDistrict.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.touristPlaceDistrict.IntegralHeight = false;
			this.touristPlaceDistrict.ItemHeight = 28;
			this.touristPlaceDistrict.Items.AddRange(new object[] {
            "Choose District",
            "Bagerhat",
            "Bandarban",
            "Barguna",
            "Barisal",
            "Bhola",
            "Bogra",
            "Brahmanbaria",
            "Chandpur",
            "Chittagong",
            "Chuadanga",
            "Comilla",
            "Cox\'\'s Bazar",
            "Dhaka",
            "Dinajpur",
            "Faridpur",
            "Feni",
            "Gaibandha",
            "Gazipur",
            "Gopalganj",
            "Habiganj",
            "Jamalpur",
            "Jessore",
            "Jhenaidah",
            "Jhalokati",
            "Joypurhat",
            "Khagrachari",
            "Khulna",
            "Kushtia",
            "Kishoreganj",
            "Kurigram",
            "Lakshmipur",
            "Lalmonirhat",
            "Madaripur",
            "Magura",
            "Manikganj",
            "Maulvibazar",
            "Meherpur",
            "Munshiganj",
            "Mymensingh",
            "Naogaon",
            "Narayanganj",
            "Natore",
            "Narail",
            "Narsingdi",
            "Nawabganj",
            "Netrokona",
            "Nilphamari",
            "Noakhali",
            "Pabna ",
            "Panchagarh",
            "Patuakhali",
            "Pirojpur",
            "Rangamati",
            "Rajbari",
            "Rajshahi",
            "Rangpur",
            "Satkhira",
            "Shariatpur",
            "Sherpur",
            "Sirajgonj",
            "Sunamganj",
            "Sylhet ",
            "Tangail",
            "Thakurgaon"});
			this.touristPlaceDistrict.Location = new System.Drawing.Point(520, 287);
			this.touristPlaceDistrict.MaxDropDownItems = 5;
			this.touristPlaceDistrict.Name = "touristPlaceDistrict";
			this.touristPlaceDistrict.ShadowDecoration.Color = System.Drawing.Color.Gray;
			this.touristPlaceDistrict.Size = new System.Drawing.Size(219, 34);
			this.touristPlaceDistrict.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.touristPlaceDistrict.TabIndex = 73;
			this.touristPlaceDistrict.SelectedIndexChanged += new System.EventHandler(this.resortcategory_SelectedIndexChanged);
			// 
			// txt_TouristPlaceSearch
			// 
			this.txt_TouristPlaceSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_TouristPlaceSearch.BorderRadius = 1;
			this.txt_TouristPlaceSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.txt_TouristPlaceSearch.BorderThickness = 2;
			this.txt_TouristPlaceSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_TouristPlaceSearch.DefaultText = "";
			this.txt_TouristPlaceSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_TouristPlaceSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_TouristPlaceSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TouristPlaceSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TouristPlaceSearch.FillColor = System.Drawing.Color.Moccasin;
			this.txt_TouristPlaceSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TouristPlaceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TouristPlaceSearch.ForeColor = System.Drawing.Color.Black;
			this.txt_TouristPlaceSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TouristPlaceSearch.Location = new System.Drawing.Point(754, 285);
			this.txt_TouristPlaceSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.txt_TouristPlaceSearch.Name = "txt_TouristPlaceSearch";
			this.txt_TouristPlaceSearch.PasswordChar = '\0';
			this.txt_TouristPlaceSearch.PlaceholderText = "";
			this.txt_TouristPlaceSearch.SelectedText = "";
			this.txt_TouristPlaceSearch.Size = new System.Drawing.Size(200, 36);
			this.txt_TouristPlaceSearch.TabIndex = 74;
			this.txt_TouristPlaceSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_TouristPlaceSearch.TextChanged += new System.EventHandler(this.txt_TouristPlaceSearch_TextChanged);
			// 
			// touristPlaceSearch
			// 
			this.touristPlaceSearch.BorderColor = System.Drawing.Color.Moccasin;
			this.touristPlaceSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.touristPlaceSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.touristPlaceSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.touristPlaceSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.touristPlaceSearch.FillColor = System.Drawing.Color.Moccasin;
			this.touristPlaceSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.touristPlaceSearch.ForeColor = System.Drawing.Color.White;
			this.touristPlaceSearch.Image = global::CoXBan_tOUR.Properties.Resources.transparency;
			this.touristPlaceSearch.ImageSize = new System.Drawing.Size(30, 30);
			this.touristPlaceSearch.Location = new System.Drawing.Point(962, 290);
			this.touristPlaceSearch.Name = "touristPlaceSearch";
			this.touristPlaceSearch.PressedColor = System.Drawing.Color.Moccasin;
			this.touristPlaceSearch.ShadowDecoration.Color = System.Drawing.Color.Moccasin;
			this.touristPlaceSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.touristPlaceSearch.Size = new System.Drawing.Size(37, 30);
			this.touristPlaceSearch.TabIndex = 75;
			this.touristPlaceSearch.Click += new System.EventHandler(this.touristPlaceSearch_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(272, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 21);
			this.label2.TabIndex = 76;
			this.label2.Text = "District";
			// 
			// txt_TouristPlaceThana
			// 
			this.txt_TouristPlaceThana.AnimateReadOnly = false;
			this.txt_TouristPlaceThana.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_TouristPlaceThana.Depth = 0;
			this.txt_TouristPlaceThana.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txt_TouristPlaceThana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_TouristPlaceThana.Hint = "Enter Tourist Place Thana";
			this.txt_TouristPlaceThana.LeadingIcon = null;
			this.txt_TouristPlaceThana.Location = new System.Drawing.Point(528, 69);
			this.txt_TouristPlaceThana.MaxLength = 50;
			this.txt_TouristPlaceThana.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_TouristPlaceThana.Multiline = false;
			this.txt_TouristPlaceThana.Name = "txt_TouristPlaceThana";
			this.txt_TouristPlaceThana.Size = new System.Drawing.Size(230, 50);
			this.txt_TouristPlaceThana.TabIndex = 77;
			this.txt_TouristPlaceThana.Text = "";
			this.txt_TouristPlaceThana.TrailingIcon = null;
			// 
			// txt_TouristPlaceDIstrict
			// 
			this.txt_TouristPlaceDIstrict.AutoResize = false;
			this.txt_TouristPlaceDIstrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txt_TouristPlaceDIstrict.Depth = 0;
			this.txt_TouristPlaceDIstrict.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.txt_TouristPlaceDIstrict.DropDownHeight = 174;
			this.txt_TouristPlaceDIstrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txt_TouristPlaceDIstrict.DropDownWidth = 121;
			this.txt_TouristPlaceDIstrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.txt_TouristPlaceDIstrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_TouristPlaceDIstrict.FormattingEnabled = true;
			this.txt_TouristPlaceDIstrict.IntegralHeight = false;
			this.txt_TouristPlaceDIstrict.ItemHeight = 43;
			this.txt_TouristPlaceDIstrict.Items.AddRange(new object[] {
            "Choose District",
            "Dhaka",
            "Faridpur",
            "Gazipur",
            "Gopalganj",
            "Jamalpur",
            "Kishoreganj",
            "Madaripur",
            "Manikganj",
            "Munshiganj",
            "Mymensingh",
            "Narayanganj",
            "Narsingdi",
            "Netrokona",
            "Rajbari",
            "Shariatpur",
            "Sherpur",
            "Tangail                         ",
            "Bogra                              ",
            "Joypurhat                         ",
            "Naogaon                      ",
            "Natore                             ",
            "Nawabganj                          ",
            "Pabna                              ",
            "Rajshahi                         ",
            "Sirajgonj                           ",
            "Dinajpur                           ",
            "Gaibandha                          ",
            "Kurigram                           ",
            "Lalmonirhat                        ",
            "Nilphamari                         ",
            "Panchagarh                         ",
            "Rangpur                            ",
            "Thakurgaon                         ",
            "Barguna                       ",
            "Barisal                       ",
            "Bhola                              ",
            "Jhalokati                          ",
            "Patuakhali                         ",
            "Pirojpur                          ",
            "Bandarban                          ",
            "Brahmanbaria                       ",
            "Chandpur                           ",
            "Chittagong                         ",
            "Comilla                            ",
            "Cox\'\'s Bazar                       ",
            "Feni                               ",
            "Khagrachari                        ",
            "Lakshmipur                         ",
            "Noakhali                           ",
            "Rangamati                          ",
            "Habiganj                           ",
            "Maulvibazar                        ",
            "Sunamganj                          ",
            "Sylhet                             ",
            "Bagerhat                           ",
            "Chuadanga                          ",
            "Jessore                            ",
            "Jhenaidah                          ",
            "Khulna                             ",
            "Kushtia                             ",
            "Magura                             ",
            "Meherpur                           ",
            "Narail                             ",
            "Satkhira"});
			this.txt_TouristPlaceDIstrict.Location = new System.Drawing.Point(276, 68);
			this.txt_TouristPlaceDIstrict.MaxDropDownItems = 4;
			this.txt_TouristPlaceDIstrict.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_TouristPlaceDIstrict.Name = "txt_TouristPlaceDIstrict";
			this.txt_TouristPlaceDIstrict.Size = new System.Drawing.Size(230, 49);
			this.txt_TouristPlaceDIstrict.StartIndex = 0;
			this.txt_TouristPlaceDIstrict.TabIndex = 78;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(524, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 21);
			this.label3.TabIndex = 79;
			this.label3.Text = "Thana";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(524, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 21);
			this.label5.TabIndex = 80;
			this.label5.Text = "Description";
			// 
			// txt_TouristPlaceDescription
			// 
			this.txt_TouristPlaceDescription.AnimateReadOnly = false;
			this.txt_TouristPlaceDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_TouristPlaceDescription.Depth = 0;
			this.txt_TouristPlaceDescription.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txt_TouristPlaceDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_TouristPlaceDescription.Hint = "Description";
			this.txt_TouristPlaceDescription.LeadingIcon = null;
			this.txt_TouristPlaceDescription.Location = new System.Drawing.Point(528, 146);
			this.txt_TouristPlaceDescription.MaxLength = 50;
			this.txt_TouristPlaceDescription.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_TouristPlaceDescription.Multiline = false;
			this.txt_TouristPlaceDescription.Name = "txt_TouristPlaceDescription";
			this.txt_TouristPlaceDescription.Size = new System.Drawing.Size(230, 50);
			this.txt_TouristPlaceDescription.TabIndex = 81;
			this.txt_TouristPlaceDescription.Text = "";
			this.txt_TouristPlaceDescription.TrailingIcon = null;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(20, 122);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 21);
			this.label6.TabIndex = 82;
			this.label6.Text = "First Image";
			// 
			// touristPlaceImage1
			// 
			this.touristPlaceImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.touristPlaceImage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.touristPlaceImage1.Location = new System.Drawing.Point(24, 146);
			this.touristPlaceImage1.Name = "touristPlaceImage1";
			this.touristPlaceImage1.Size = new System.Drawing.Size(124, 124);
			this.touristPlaceImage1.TabIndex = 83;
			this.touristPlaceImage1.TabStop = false;
			this.touristPlaceImage1.Click += new System.EventHandler(this.touristPlaceImage1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label7.Location = new System.Drawing.Point(180, 122);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(118, 21);
			this.label7.TabIndex = 84;
			this.label7.Text = "Second Image";
			// 
			// touristPlaceImage2
			// 
			this.touristPlaceImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.touristPlaceImage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.touristPlaceImage2.Location = new System.Drawing.Point(184, 146);
			this.touristPlaceImage2.Name = "touristPlaceImage2";
			this.touristPlaceImage2.Size = new System.Drawing.Size(124, 124);
			this.touristPlaceImage2.TabIndex = 85;
			this.touristPlaceImage2.TabStop = false;
			this.touristPlaceImage2.Click += new System.EventHandler(this.touristPlaceImage2_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label8.Location = new System.Drawing.Point(340, 122);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(118, 21);
			this.label8.TabIndex = 86;
			this.label8.Text = "Second Image";
			// 
			// touristPlaceImage3
			// 
			this.touristPlaceImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.touristPlaceImage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.touristPlaceImage3.Location = new System.Drawing.Point(344, 146);
			this.touristPlaceImage3.Name = "touristPlaceImage3";
			this.touristPlaceImage3.Size = new System.Drawing.Size(124, 124);
			this.touristPlaceImage3.TabIndex = 87;
			this.touristPlaceImage3.TabStop = false;
			this.touristPlaceImage3.Click += new System.EventHandler(this.touristPlaceImage3_Click);
			// 
			// UpdateResort
			// 
			this.UpdateResort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.UpdateResort.BackColor = System.Drawing.Color.Brown;
			this.UpdateResort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.UpdateResort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.UpdateResort.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateResort.Location = new System.Drawing.Point(544, 225);
			this.UpdateResort.Name = "UpdateResort";
			this.UpdateResort.Size = new System.Drawing.Size(200, 36);
			this.UpdateResort.TabIndex = 89;
			this.UpdateResort.Text = "Update Resort";
			this.UpdateResort.UseVisualStyleBackColor = false;
			// 
			// AddResort
			// 
			this.AddResort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AddResort.BackColor = System.Drawing.Color.Brown;
			this.AddResort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.AddResort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddResort.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddResort.Location = new System.Drawing.Point(799, 225);
			this.AddResort.Name = "AddResort";
			this.AddResort.Size = new System.Drawing.Size(200, 36);
			this.AddResort.TabIndex = 88;
			this.AddResort.Text = "Add Resort";
			this.AddResort.UseVisualStyleBackColor = false;
			this.AddResort.Click += new System.EventHandler(this.AddResort_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label9.Location = new System.Drawing.Point(774, 43);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 21);
			this.label9.TabIndex = 91;
			this.label9.Text = "Location";
			// 
			// txt_TouristPlaceLocation
			// 
			this.txt_TouristPlaceLocation.AnimateReadOnly = false;
			this.txt_TouristPlaceLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_TouristPlaceLocation.Depth = 0;
			this.txt_TouristPlaceLocation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txt_TouristPlaceLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_TouristPlaceLocation.Hint = "Enter Tourist Place Location";
			this.txt_TouristPlaceLocation.LeadingIcon = null;
			this.txt_TouristPlaceLocation.Location = new System.Drawing.Point(778, 69);
			this.txt_TouristPlaceLocation.MaxLength = 50;
			this.txt_TouristPlaceLocation.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_TouristPlaceLocation.Multiline = false;
			this.txt_TouristPlaceLocation.Name = "txt_TouristPlaceLocation";
			this.txt_TouristPlaceLocation.Size = new System.Drawing.Size(230, 50);
			this.txt_TouristPlaceLocation.TabIndex = 90;
			this.txt_TouristPlaceLocation.Text = "";
			this.txt_TouristPlaceLocation.TrailingIcon = null;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label10.Location = new System.Drawing.Point(774, 121);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 21);
			this.label10.TabIndex = 92;
			this.label10.Text = "Rating";
			// 
			// txt_TouristPlaceRating
			// 
			this.txt_TouristPlaceRating.AnimateReadOnly = false;
			this.txt_TouristPlaceRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_TouristPlaceRating.Depth = 0;
			this.txt_TouristPlaceRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txt_TouristPlaceRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_TouristPlaceRating.Hint = "Tourist Place Rating";
			this.txt_TouristPlaceRating.LeadingIcon = null;
			this.txt_TouristPlaceRating.Location = new System.Drawing.Point(778, 146);
			this.txt_TouristPlaceRating.MaxLength = 50;
			this.txt_TouristPlaceRating.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_TouristPlaceRating.Multiline = false;
			this.txt_TouristPlaceRating.Name = "txt_TouristPlaceRating";
			this.txt_TouristPlaceRating.Size = new System.Drawing.Size(230, 50);
			this.txt_TouristPlaceRating.TabIndex = 93;
			this.txt_TouristPlaceRating.Text = "5";
			this.txt_TouristPlaceRating.TrailingIcon = null;
			// 
			// TouristPlaceController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.Controls.Add(this.txt_TouristPlaceRating);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txt_TouristPlaceLocation);
			this.Controls.Add(this.UpdateResort);
			this.Controls.Add(this.AddResort);
			this.Controls.Add(this.touristPlaceImage3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.touristPlaceImage2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.touristPlaceImage1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_TouristPlaceDescription);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_TouristPlaceDIstrict);
			this.Controls.Add(this.txt_TouristPlaceThana);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.touristPlaceSearch);
			this.Controls.Add(this.txt_TouristPlaceSearch);
			this.Controls.Add(this.touristPlaceDistrict);
			this.Controls.Add(this.touristPlaceLoading);
			this.Controls.Add(this.allTouristPlaceList);
			this.Controls.Add(this.txt_TouristPlaceName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "TouristPlaceController";
			this.Size = new System.Drawing.Size(1032, 678);
			((System.ComponentModel.ISupportInitialize)(this.allTouristPlaceList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.touristPlaceImage1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.touristPlaceImage2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.touristPlaceImage3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private MaterialSkin.Controls.MaterialTextBox txt_TouristPlaceName;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2DataGridView allTouristPlaceList;
		private Guna.UI2.WinForms.Guna2CircleButton touristPlaceLoading;
		private Guna.UI2.WinForms.Guna2ComboBox touristPlaceDistrict;
		private Guna.UI2.WinForms.Guna2TextBox txt_TouristPlaceSearch;
		private Guna.UI2.WinForms.Guna2CircleButton touristPlaceSearch;
		private System.Windows.Forms.Label label2;
		private MaterialSkin.Controls.MaterialTextBox txt_TouristPlaceThana;
		private MaterialSkin.Controls.MaterialComboBox txt_TouristPlaceDIstrict;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private MaterialSkin.Controls.MaterialTextBox txt_TouristPlaceDescription;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox touristPlaceImage1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox touristPlaceImage2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox touristPlaceImage3;
		private System.Windows.Forms.Button UpdateResort;
		private System.Windows.Forms.Button AddResort;
		private System.Windows.Forms.Label label9;
		private MaterialSkin.Controls.MaterialTextBox txt_TouristPlaceLocation;
		private System.Windows.Forms.Label label10;
		private MaterialSkin.Controls.MaterialTextBox txt_TouristPlaceRating;
	}
}
