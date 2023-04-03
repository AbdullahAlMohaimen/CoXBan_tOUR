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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CategoryImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.ImageUploadButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.CategoryImage)).BeginInit();
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
			this.label1.Location = new System.Drawing.Point(20, 20);
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
			this.label2.Location = new System.Drawing.Point(21, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Category Name";
			// 
			// materialTextBox1
			// 
			this.materialTextBox1.AnimateReadOnly = false;
			this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.materialTextBox1.Depth = 0;
			this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialTextBox1.LeadingIcon = null;
			this.materialTextBox1.Location = new System.Drawing.Point(24, 98);
			this.materialTextBox1.MaxLength = 50;
			this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
			this.materialTextBox1.Multiline = false;
			this.materialTextBox1.Name = "materialTextBox1";
			this.materialTextBox1.Size = new System.Drawing.Size(300, 50);
			this.materialTextBox1.TabIndex = 8;
			this.materialTextBox1.Text = "";
			this.materialTextBox1.TrailingIcon = null;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(348, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 21);
			this.label3.TabIndex = 9;
			this.label3.Text = "Category Image";
			// 
			// CategoryImage
			// 
			this.CategoryImage.FillColor = System.Drawing.Color.Tan;
			this.CategoryImage.ImageRotate = 0F;
			this.CategoryImage.Location = new System.Drawing.Point(369, 98);
			this.CategoryImage.Name = "CategoryImage";
			this.CategoryImage.ShadowDecoration.BorderRadius = 10;
			this.CategoryImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.CategoryImage.Size = new System.Drawing.Size(90, 90);
			this.CategoryImage.TabIndex = 10;
			this.CategoryImage.TabStop = false;
			// 
			// ImageUploadButton
			// 
			this.ImageUploadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ImageUploadButton.BackColor = System.Drawing.Color.Brown;
			this.ImageUploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImageUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ImageUploadButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ImageUploadButton.Location = new System.Drawing.Point(366, 194);
			this.ImageUploadButton.Name = "ImageUploadButton";
			this.ImageUploadButton.Size = new System.Drawing.Size(104, 27);
			this.ImageUploadButton.TabIndex = 20;
			this.ImageUploadButton.Text = "Upload Image";
			this.ImageUploadButton.UseVisualStyleBackColor = false;
			this.ImageUploadButton.Click += new System.EventHandler(this.ImageUploadButton_Click);
			// 
			// CategoryController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.Controls.Add(this.ImageUploadButton);
			this.Controls.Add(this.CategoryImage);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.materialTextBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "CategoryController";
			this.Size = new System.Drawing.Size(886, 552);
			this.Load += new System.EventHandler(this.CategoryController_Load);
			((System.ComponentModel.ISupportInitialize)(this.CategoryImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2CirclePictureBox CategoryImage;
		private System.Windows.Forms.Button ImageUploadButton;
	}
}
