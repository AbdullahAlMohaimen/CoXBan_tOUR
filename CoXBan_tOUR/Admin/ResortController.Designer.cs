namespace CoXBan_tOUR.Admin.Add
{
	partial class ResortController
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_resortCategoryName = new MaterialSkin.Controls.MaterialComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_resortName = new MaterialSkin.Controls.MaterialTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_ResortDIstrict = new MaterialSkin.Controls.MaterialComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_TotalRoom = new MaterialSkin.Controls.MaterialTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_ResortLocation = new MaterialSkin.Controls.MaterialTextBox();
			this.txt_ResortDescription = new MaterialSkin.Controls.MaterialTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_ResortQuality = new MaterialSkin.Controls.MaterialComboBox();
			this.txt_ResortContactNumber = new MaterialSkin.Controls.MaterialTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.resortImage = new System.Windows.Forms.PictureBox();
			this.AddResort = new System.Windows.Forms.Button();
			this.UpdateResort = new System.Windows.Forms.Button();
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			this.vehicleSearch = new Guna.UI2.WinForms.Guna2CircleButton();
			this.txt_VehicleSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.allResortList = new Guna.UI2.WinForms.Guna2DataGridView();
			this.resortcategory = new Guna.UI2.WinForms.Guna2ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.resortImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.allResortList)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SeaGreen;
			this.panel1.Location = new System.Drawing.Point(0, 276);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1032, 2);
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(20, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Add a New Resort";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkGreen;
			this.panel2.Location = new System.Drawing.Point(20, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(204, 2);
			this.panel2.TabIndex = 33;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(20, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 21);
			this.label2.TabIndex = 34;
			this.label2.Text = "Category Name";
			// 
			// txt_resortCategoryName
			// 
			this.txt_resortCategoryName.AutoResize = false;
			this.txt_resortCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txt_resortCategoryName.Depth = 0;
			this.txt_resortCategoryName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.txt_resortCategoryName.DropDownHeight = 174;
			this.txt_resortCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txt_resortCategoryName.DropDownWidth = 121;
			this.txt_resortCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.txt_resortCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_resortCategoryName.FormattingEnabled = true;
			this.txt_resortCategoryName.IntegralHeight = false;
			this.txt_resortCategoryName.ItemHeight = 43;
			this.txt_resortCategoryName.Items.AddRange(new object[] {
            "Choose Category"});
			this.txt_resortCategoryName.Location = new System.Drawing.Point(23, 69);
			this.txt_resortCategoryName.MaxDropDownItems = 4;
			this.txt_resortCategoryName.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_resortCategoryName.Name = "txt_resortCategoryName";
			this.txt_resortCategoryName.Size = new System.Drawing.Size(230, 49);
			this.txt_resortCategoryName.StartIndex = 0;
			this.txt_resortCategoryName.TabIndex = 39;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label4.Location = new System.Drawing.Point(272, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 21);
			this.label4.TabIndex = 41;
			this.label4.Text = "Resort Name";
			// 
			// txt_resortName
			// 
			this.txt_resortName.AnimateReadOnly = false;
			this.txt_resortName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_resortName.Depth = 0;
			this.txt_resortName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txt_resortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_resortName.Hint = "Enter Resort Name";
			this.txt_resortName.LeadingIcon = null;
			this.txt_resortName.Location = new System.Drawing.Point(276, 68);
			this.txt_resortName.MaxLength = 50;
			this.txt_resortName.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_resortName.Multiline = false;
			this.txt_resortName.Name = "txt_resortName";
			this.txt_resortName.Size = new System.Drawing.Size(230, 50);
			this.txt_resortName.TabIndex = 42;
			this.txt_resortName.Text = "";
			this.txt_resortName.TrailingIcon = null;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(524, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 21);
			this.label6.TabIndex = 45;
			this.label6.Text = "District";
			// 
			// txt_ResortDIstrict
			// 
			this.txt_ResortDIstrict.AutoResize = false;
			this.txt_ResortDIstrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txt_ResortDIstrict.Depth = 0;
			this.txt_ResortDIstrict.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.txt_ResortDIstrict.DropDownHeight = 174;
			this.txt_ResortDIstrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txt_ResortDIstrict.DropDownWidth = 121;
			this.txt_ResortDIstrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.txt_ResortDIstrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_ResortDIstrict.FormattingEnabled = true;
			this.txt_ResortDIstrict.IntegralHeight = false;
			this.txt_ResortDIstrict.ItemHeight = 43;
			this.txt_ResortDIstrict.Items.AddRange(new object[] {
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
			this.txt_ResortDIstrict.Location = new System.Drawing.Point(528, 69);
			this.txt_ResortDIstrict.MaxDropDownItems = 4;
			this.txt_ResortDIstrict.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_ResortDIstrict.Name = "txt_ResortDIstrict";
			this.txt_ResortDIstrict.Size = new System.Drawing.Size(230, 49);
			this.txt_ResortDIstrict.StartIndex = 0;
			this.txt_ResortDIstrict.TabIndex = 52;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label8.Location = new System.Drawing.Point(774, 43);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 21);
			this.label8.TabIndex = 53;
			this.label8.Text = "Total Room";
			// 
			// txt_TotalRoom
			// 
			this.txt_TotalRoom.AnimateReadOnly = false;
			this.txt_TotalRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_TotalRoom.Depth = 0;
			this.txt_TotalRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txt_TotalRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_TotalRoom.Hint = "Enter Total Room";
			this.txt_TotalRoom.LeadingIcon = null;
			this.txt_TotalRoom.Location = new System.Drawing.Point(778, 69);
			this.txt_TotalRoom.MaxLength = 50;
			this.txt_TotalRoom.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_TotalRoom.Multiline = false;
			this.txt_TotalRoom.Name = "txt_TotalRoom";
			this.txt_TotalRoom.Size = new System.Drawing.Size(230, 50);
			this.txt_TotalRoom.TabIndex = 54;
			this.txt_TotalRoom.Text = "0";
			this.txt_TotalRoom.TrailingIcon = null;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(20, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 21);
			this.label3.TabIndex = 55;
			this.label3.Text = "Location";
			// 
			// txt_ResortLocation
			// 
			this.txt_ResortLocation.AnimateReadOnly = false;
			this.txt_ResortLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_ResortLocation.Depth = 0;
			this.txt_ResortLocation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txt_ResortLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_ResortLocation.Hint = "Resort Location";
			this.txt_ResortLocation.LeadingIcon = null;
			this.txt_ResortLocation.Location = new System.Drawing.Point(23, 146);
			this.txt_ResortLocation.MaxLength = 50;
			this.txt_ResortLocation.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_ResortLocation.Multiline = false;
			this.txt_ResortLocation.Name = "txt_ResortLocation";
			this.txt_ResortLocation.Size = new System.Drawing.Size(230, 50);
			this.txt_ResortLocation.TabIndex = 56;
			this.txt_ResortLocation.Text = "";
			this.txt_ResortLocation.TrailingIcon = null;
			// 
			// txt_ResortDescription
			// 
			this.txt_ResortDescription.AnimateReadOnly = false;
			this.txt_ResortDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_ResortDescription.Depth = 0;
			this.txt_ResortDescription.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txt_ResortDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_ResortDescription.Hint = "Resort Description";
			this.txt_ResortDescription.LeadingIcon = null;
			this.txt_ResortDescription.Location = new System.Drawing.Point(24, 220);
			this.txt_ResortDescription.MaxLength = 50;
			this.txt_ResortDescription.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_ResortDescription.Multiline = false;
			this.txt_ResortDescription.Name = "txt_ResortDescription";
			this.txt_ResortDescription.Size = new System.Drawing.Size(230, 50);
			this.txt_ResortDescription.TabIndex = 58;
			this.txt_ResortDescription.Text = "";
			this.txt_ResortDescription.TrailingIcon = null;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(21, 196);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 21);
			this.label5.TabIndex = 57;
			this.label5.Text = "Description";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label7.Location = new System.Drawing.Point(272, 121);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 21);
			this.label7.TabIndex = 59;
			this.label7.Text = "Quality";
			// 
			// txt_ResortQuality
			// 
			this.txt_ResortQuality.AutoResize = false;
			this.txt_ResortQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txt_ResortQuality.Depth = 0;
			this.txt_ResortQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.txt_ResortQuality.DropDownHeight = 174;
			this.txt_ResortQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txt_ResortQuality.DropDownWidth = 121;
			this.txt_ResortQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.txt_ResortQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_ResortQuality.FormattingEnabled = true;
			this.txt_ResortQuality.IntegralHeight = false;
			this.txt_ResortQuality.ItemHeight = 43;
			this.txt_ResortQuality.Items.AddRange(new object[] {
            "Resort Quality",
            "First Class",
            "Second Class",
            "Low Class",
            "Others"});
			this.txt_ResortQuality.Location = new System.Drawing.Point(276, 146);
			this.txt_ResortQuality.MaxDropDownItems = 4;
			this.txt_ResortQuality.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_ResortQuality.Name = "txt_ResortQuality";
			this.txt_ResortQuality.Size = new System.Drawing.Size(230, 49);
			this.txt_ResortQuality.StartIndex = 0;
			this.txt_ResortQuality.TabIndex = 60;
			// 
			// txt_ResortContactNumber
			// 
			this.txt_ResortContactNumber.AnimateReadOnly = false;
			this.txt_ResortContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_ResortContactNumber.Depth = 0;
			this.txt_ResortContactNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txt_ResortContactNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_ResortContactNumber.Hint = "Resort Contact Number";
			this.txt_ResortContactNumber.LeadingIcon = null;
			this.txt_ResortContactNumber.Location = new System.Drawing.Point(528, 146);
			this.txt_ResortContactNumber.MaxLength = 50;
			this.txt_ResortContactNumber.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_ResortContactNumber.Multiline = false;
			this.txt_ResortContactNumber.Name = "txt_ResortContactNumber";
			this.txt_ResortContactNumber.Size = new System.Drawing.Size(230, 50);
			this.txt_ResortContactNumber.TabIndex = 62;
			this.txt_ResortContactNumber.Text = "";
			this.txt_ResortContactNumber.TrailingIcon = null;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label9.Location = new System.Drawing.Point(524, 121);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 21);
			this.label9.TabIndex = 61;
			this.label9.Text = "Contact Number";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label10.Location = new System.Drawing.Point(831, 122);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(118, 21);
			this.label10.TabIndex = 64;
			this.label10.Text = "Resort Image";
			// 
			// resortImage
			// 
			this.resortImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.resortImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.resortImage.Location = new System.Drawing.Point(828, 146);
			this.resortImage.Name = "resortImage";
			this.resortImage.Size = new System.Drawing.Size(124, 124);
			this.resortImage.TabIndex = 63;
			this.resortImage.TabStop = false;
			this.resortImage.Click += new System.EventHandler(this.resortImage_Click);
			// 
			// AddResort
			// 
			this.AddResort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AddResort.BackColor = System.Drawing.Color.Brown;
			this.AddResort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.AddResort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddResort.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddResort.Location = new System.Drawing.Point(545, 225);
			this.AddResort.Name = "AddResort";
			this.AddResort.Size = new System.Drawing.Size(200, 36);
			this.AddResort.TabIndex = 65;
			this.AddResort.Text = "Add Resort";
			this.AddResort.UseVisualStyleBackColor = false;
			this.AddResort.Click += new System.EventHandler(this.AddResort_Click);
			// 
			// UpdateResort
			// 
			this.UpdateResort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.UpdateResort.BackColor = System.Drawing.Color.Brown;
			this.UpdateResort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.UpdateResort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.UpdateResort.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateResort.Location = new System.Drawing.Point(290, 225);
			this.UpdateResort.Name = "UpdateResort";
			this.UpdateResort.Size = new System.Drawing.Size(200, 36);
			this.UpdateResort.TabIndex = 66;
			this.UpdateResort.Text = "Update Resort";
			this.UpdateResort.UseVisualStyleBackColor = false;
			// 
			// guna2CircleButton1
			// 
			this.guna2CircleButton1.BorderColor = System.Drawing.Color.Moccasin;
			this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2CircleButton1.FillColor = System.Drawing.Color.Moccasin;
			this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
			this.guna2CircleButton1.Image = global::CoXBan_tOUR.Properties.Resources.refresh;
			this.guna2CircleButton1.ImageSize = new System.Drawing.Size(30, 30);
			this.guna2CircleButton1.Location = new System.Drawing.Point(24, 290);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.PressedColor = System.Drawing.Color.Moccasin;
			this.guna2CircleButton1.ShadowDecoration.Color = System.Drawing.Color.Moccasin;
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.Size = new System.Drawing.Size(37, 30);
			this.guna2CircleButton1.TabIndex = 69;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
			// 
			// vehicleSearch
			// 
			this.vehicleSearch.BorderColor = System.Drawing.Color.Moccasin;
			this.vehicleSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.vehicleSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.vehicleSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.vehicleSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.vehicleSearch.FillColor = System.Drawing.Color.Moccasin;
			this.vehicleSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.vehicleSearch.ForeColor = System.Drawing.Color.White;
			this.vehicleSearch.Image = global::CoXBan_tOUR.Properties.Resources.transparency;
			this.vehicleSearch.ImageSize = new System.Drawing.Size(30, 30);
			this.vehicleSearch.Location = new System.Drawing.Point(962, 290);
			this.vehicleSearch.Name = "vehicleSearch";
			this.vehicleSearch.PressedColor = System.Drawing.Color.Moccasin;
			this.vehicleSearch.ShadowDecoration.Color = System.Drawing.Color.Moccasin;
			this.vehicleSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.vehicleSearch.Size = new System.Drawing.Size(37, 30);
			this.vehicleSearch.TabIndex = 68;
			this.vehicleSearch.Click += new System.EventHandler(this.vehicleSearch_Click);
			// 
			// txt_VehicleSearch
			// 
			this.txt_VehicleSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_VehicleSearch.BorderRadius = 1;
			this.txt_VehicleSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.txt_VehicleSearch.BorderThickness = 2;
			this.txt_VehicleSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_VehicleSearch.DefaultText = "";
			this.txt_VehicleSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_VehicleSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_VehicleSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_VehicleSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_VehicleSearch.FillColor = System.Drawing.Color.Moccasin;
			this.txt_VehicleSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_VehicleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_VehicleSearch.ForeColor = System.Drawing.Color.Black;
			this.txt_VehicleSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_VehicleSearch.Location = new System.Drawing.Point(754, 285);
			this.txt_VehicleSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.txt_VehicleSearch.Name = "txt_VehicleSearch";
			this.txt_VehicleSearch.PasswordChar = '\0';
			this.txt_VehicleSearch.PlaceholderText = "";
			this.txt_VehicleSearch.SelectedText = "";
			this.txt_VehicleSearch.Size = new System.Drawing.Size(200, 36);
			this.txt_VehicleSearch.TabIndex = 67;
			this.txt_VehicleSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_VehicleSearch.TextChanged += new System.EventHandler(this.txt_VehicleSearch_TextChanged);
			// 
			// allResortList
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.allResortList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.allResortList.BackgroundColor = System.Drawing.Color.Moccasin;
			this.allResortList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.allResortList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allResortList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.allResortList.ColumnHeadersHeight = 28;
			this.allResortList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.allResortList.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.allResortList.DefaultCellStyle = dataGridViewCellStyle3;
			this.allResortList.EnableHeadersVisualStyles = true;
			this.allResortList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allResortList.Location = new System.Drawing.Point(24, 328);
			this.allResortList.Name = "allResortList";
			this.allResortList.ReadOnly = true;
			this.allResortList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.allResortList.RowHeadersVisible = false;
			this.allResortList.RowHeadersWidth = 40;
			this.allResortList.RowTemplate.Height = 28;
			this.allResortList.RowTemplate.ReadOnly = true;
			this.allResortList.Size = new System.Drawing.Size(984, 335);
			this.allResortList.TabIndex = 70;
			this.allResortList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.allResortList.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.allResortList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.allResortList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.allResortList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.allResortList.ThemeStyle.BackColor = System.Drawing.Color.Moccasin;
			this.allResortList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allResortList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.allResortList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
			this.allResortList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allResortList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.allResortList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.allResortList.ThemeStyle.HeaderStyle.Height = 28;
			this.allResortList.ThemeStyle.ReadOnly = true;
			this.allResortList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.allResortList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.allResortList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allResortList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.allResortList.ThemeStyle.RowsStyle.Height = 28;
			this.allResortList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.allResortList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// resortcategory
			// 
			this.resortcategory.BackColor = System.Drawing.Color.Moccasin;
			this.resortcategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.resortcategory.BorderRadius = 8;
			this.resortcategory.BorderThickness = 0;
			this.resortcategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.resortcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.resortcategory.DropDownHeight = 150;
			this.resortcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.resortcategory.DropDownWidth = 120;
			this.resortcategory.FillColor = System.Drawing.Color.Moccasin;
			this.resortcategory.FocusedColor = System.Drawing.Color.Empty;
			this.resortcategory.FocusedState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resortcategory.FocusedState.ForeColor = System.Drawing.Color.Black;
			this.resortcategory.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resortcategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.resortcategory.HoverState.FillColor = System.Drawing.Color.Brown;
			this.resortcategory.HoverState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.resortcategory.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.resortcategory.IntegralHeight = false;
			this.resortcategory.ItemHeight = 28;
			this.resortcategory.Location = new System.Drawing.Point(520, 287);
			this.resortcategory.MaxDropDownItems = 5;
			this.resortcategory.Name = "resortcategory";
			this.resortcategory.ShadowDecoration.Color = System.Drawing.Color.Gray;
			this.resortcategory.Size = new System.Drawing.Size(219, 34);
			this.resortcategory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.resortcategory.TabIndex = 71;
			this.resortcategory.SelectedIndexChanged += new System.EventHandler(this.resortcategory_SelectedIndexChanged);
			// 
			// ResortController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.Controls.Add(this.resortcategory);
			this.Controls.Add(this.allResortList);
			this.Controls.Add(this.guna2CircleButton1);
			this.Controls.Add(this.vehicleSearch);
			this.Controls.Add(this.txt_VehicleSearch);
			this.Controls.Add(this.UpdateResort);
			this.Controls.Add(this.AddResort);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.resortImage);
			this.Controls.Add(this.txt_ResortContactNumber);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txt_ResortQuality);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_ResortDescription);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_ResortLocation);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_TotalRoom);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txt_ResortDIstrict);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_resortName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_resortCategoryName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "ResortController";
			this.Size = new System.Drawing.Size(1032, 678);
			((System.ComponentModel.ISupportInitialize)(this.resortImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.allResortList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private MaterialSkin.Controls.MaterialComboBox txt_resortCategoryName;
		private System.Windows.Forms.Label label4;
		private MaterialSkin.Controls.MaterialTextBox txt_resortName;
		private System.Windows.Forms.Label label6;
		private MaterialSkin.Controls.MaterialComboBox txt_ResortDIstrict;
		private System.Windows.Forms.Label label8;
		private MaterialSkin.Controls.MaterialTextBox txt_TotalRoom;
		private System.Windows.Forms.Label label3;
		private MaterialSkin.Controls.MaterialTextBox txt_ResortLocation;
		private MaterialSkin.Controls.MaterialTextBox txt_ResortDescription;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private MaterialSkin.Controls.MaterialComboBox txt_ResortQuality;
		private MaterialSkin.Controls.MaterialTextBox txt_ResortContactNumber;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox resortImage;
		private System.Windows.Forms.Button AddResort;
		private System.Windows.Forms.Button UpdateResort;
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
		private Guna.UI2.WinForms.Guna2CircleButton vehicleSearch;
		private Guna.UI2.WinForms.Guna2TextBox txt_VehicleSearch;
		private Guna.UI2.WinForms.Guna2DataGridView allResortList;
		private Guna.UI2.WinForms.Guna2ComboBox resortcategory;
	}
}
