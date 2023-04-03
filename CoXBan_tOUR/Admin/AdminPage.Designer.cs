namespace CoXBan_tOUR
{
	partial class AdminPage
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
			this.panel1 = new System.Windows.Forms.Panel();
			this.adminCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.Minimize = new System.Windows.Forms.Button();
			this.txt_Date = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
			this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SeaGreen;
			this.panel1.Controls.Add(this.adminCombobox);
			this.panel1.Controls.Add(this.Minimize);
			this.panel1.Controls.Add(this.txt_Date);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.Exit);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1100, 32);
			this.panel1.TabIndex = 1;
			// 
			// adminCombobox
			// 
			this.adminCombobox.BackColor = System.Drawing.Color.Moccasin;
			this.adminCombobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.adminCombobox.BorderRadius = 8;
			this.adminCombobox.BorderThickness = 0;
			this.adminCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.adminCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.adminCombobox.DropDownHeight = 150;
			this.adminCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.adminCombobox.DropDownWidth = 120;
			this.adminCombobox.FillColor = System.Drawing.Color.SeaGreen;
			this.adminCombobox.FocusedColor = System.Drawing.Color.Empty;
			this.adminCombobox.FocusedState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminCombobox.FocusedState.ForeColor = System.Drawing.Color.Black;
			this.adminCombobox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.adminCombobox.HoverState.FillColor = System.Drawing.Color.Brown;
			this.adminCombobox.HoverState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.adminCombobox.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.adminCombobox.IntegralHeight = false;
			this.adminCombobox.ItemHeight = 28;
			this.adminCombobox.Location = new System.Drawing.Point(159, 0);
			this.adminCombobox.MaxDropDownItems = 5;
			this.adminCombobox.Name = "adminCombobox";
			this.adminCombobox.ShadowDecoration.Color = System.Drawing.Color.Gray;
			this.adminCombobox.Size = new System.Drawing.Size(220, 34);
			this.adminCombobox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.adminCombobox.TabIndex = 5;
			this.adminCombobox.SelectedIndexChanged += new System.EventHandler(this.userCombobox_SelectedIndexChanged);
			// 
			// Minimize
			// 
			this.Minimize.BackColor = System.Drawing.Color.SeaGreen;
			this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
			this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Minimize.FlatAppearance.BorderSize = 0;
			this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Minimize.Location = new System.Drawing.Point(1034, 4);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(24, 24);
			this.Minimize.TabIndex = 9;
			this.Minimize.UseVisualStyleBackColor = false;
			this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
			// 
			// txt_Date
			// 
			this.txt_Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txt_Date.Location = new System.Drawing.Point(35, 4);
			this.txt_Date.Name = "txt_Date";
			this.txt_Date.Size = new System.Drawing.Size(100, 23);
			this.txt_Date.TabIndex = 8;
			this.txt_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SeaGreen;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 24);
			this.button1.TabIndex = 7;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.SeaGreen;
			this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
			this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Exit.FlatAppearance.BorderSize = 0;
			this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Exit.Location = new System.Drawing.Point(1068, 4);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(24, 24);
			this.Exit.TabIndex = 3;
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// guna2ShadowPanel1
			// 
			this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Moccasin;
			this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Moccasin;
			this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 32);
			this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
			this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
			this.guna2ShadowPanel1.Size = new System.Drawing.Size(200, 553);
			this.guna2ShadowPanel1.TabIndex = 3;
			// 
			// AdminPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1098, 584);
			this.ControlBox = false;
			this.Controls.Add(this.guna2ShadowPanel1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AdminPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.AdminPage_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Minimize;
		private System.Windows.Forms.Label txt_Date;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Exit;
		private Guna.UI2.WinForms.Guna2ComboBox adminCombobox;
		private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
	}
}