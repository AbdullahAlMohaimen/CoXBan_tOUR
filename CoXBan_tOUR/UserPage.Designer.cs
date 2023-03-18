namespace CoXBan_tOUR
{
	partial class UserPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_Date = new System.Windows.Forms.Label();
			this.userCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.Minimize = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SeaGreen;
			this.panel1.Controls.Add(this.Minimize);
			this.panel1.Controls.Add(this.txt_Date);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.Exit);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1054, 32);
			this.panel1.TabIndex = 0;
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
			// userCombobox
			// 
			this.userCombobox.BackColor = System.Drawing.Color.NavajoWhite;
			this.userCombobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.userCombobox.BorderRadius = 8;
			this.userCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.userCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.userCombobox.DropDownHeight = 150;
			this.userCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.userCombobox.DropDownWidth = 120;
			this.userCombobox.FillColor = System.Drawing.Color.NavajoWhite;
			this.userCombobox.FocusedColor = System.Drawing.Color.Empty;
			this.userCombobox.FocusedState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userCombobox.FocusedState.ForeColor = System.Drawing.Color.Black;
			this.userCombobox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.userCombobox.HoverState.FillColor = System.Drawing.Color.Brown;
			this.userCombobox.HoverState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.userCombobox.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.userCombobox.IntegralHeight = false;
			this.userCombobox.ItemHeight = 28;
			this.userCombobox.Location = new System.Drawing.Point(4, 38);
			this.userCombobox.MaxDropDownItems = 5;
			this.userCombobox.Name = "userCombobox";
			this.userCombobox.ShadowDecoration.Color = System.Drawing.Color.Gray;
			this.userCombobox.Size = new System.Drawing.Size(220, 34);
			this.userCombobox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.userCombobox.TabIndex = 4;
			this.userCombobox.SelectedIndexChanged += new System.EventHandler(this.userCombobox_SelectedIndexChanged);
			// 
			// Minimize
			// 
			this.Minimize.BackColor = System.Drawing.Color.SeaGreen;
			this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
			this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Minimize.FlatAppearance.BorderSize = 0;
			this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Minimize.Location = new System.Drawing.Point(992, 4);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(24, 24);
			this.Minimize.TabIndex = 9;
			this.Minimize.UseVisualStyleBackColor = false;
			this.Minimize.Click += new System.EventHandler(this.button2_Click);
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
			this.Exit.Location = new System.Drawing.Point(1025, 4);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(24, 24);
			this.Exit.TabIndex = 3;
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// UserPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1054, 584);
			this.ControlBox = false;
			this.Controls.Add(this.userCombobox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UserPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.UserPage_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Label txt_Date;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Minimize;
		private Guna.UI2.WinForms.Guna2ComboBox userCombobox;
	}
}