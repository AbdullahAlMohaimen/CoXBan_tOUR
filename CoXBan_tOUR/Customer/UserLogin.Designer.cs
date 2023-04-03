namespace CoXBan_tOUR
{
	partial class UserLoginPage
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_Date = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.Minimize = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
			this.title = new System.Windows.Forms.Label();
			this.txt_Email = new MaterialSkin.Controls.MaterialMaskedTextBox();
			this.txt_Password = new MaterialSkin.Controls.MaterialMaskedTextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.ForgetPassword = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.UserCreateAccount = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.goToAdminPage = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
			this.panel1.Controls.Add(this.txt_Date);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.Minimize);
			this.panel1.Controls.Add(this.Exit);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(362, 32);
			this.panel1.TabIndex = 3;
			// 
			// txt_Date
			// 
			this.txt_Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Date.ForeColor = System.Drawing.Color.Maroon;
			this.txt_Date.Location = new System.Drawing.Point(36, 4);
			this.txt_Date.Name = "txt_Date";
			this.txt_Date.Size = new System.Drawing.Size(100, 23);
			this.txt_Date.TabIndex = 6;
			this.txt_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.NavajoWhite;
			this.button1.BackgroundImage = global::CoXBan_tOUR.Properties.Resources.calendarA;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 24);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Minimize
			// 
			this.Minimize.BackColor = System.Drawing.Color.NavajoWhite;
			this.Minimize.BackgroundImage = global::CoXBan_tOUR.Properties.Resources.minus;
			this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Minimize.FlatAppearance.BorderSize = 0;
			this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Minimize.Location = new System.Drawing.Point(302, 4);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(24, 24);
			this.Minimize.TabIndex = 3;
			this.Minimize.UseVisualStyleBackColor = false;
			this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.NavajoWhite;
			this.Exit.BackgroundImage = global::CoXBan_tOUR.Properties.Resources.close;
			this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Exit.FlatAppearance.BorderSize = 0;
			this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Exit.Location = new System.Drawing.Point(334, 3);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(24, 24);
			this.Exit.TabIndex = 2;
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// title
			// 
			this.title.Font = new System.Drawing.Font("Jokerman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.ForeColor = System.Drawing.Color.Maroon;
			this.title.Location = new System.Drawing.Point(0, 154);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(362, 52);
			this.title.TabIndex = 7;
			this.title.Text = "coXBan-tOuR";
			this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_Email
			// 
			this.txt_Email.AllowPromptAsInput = true;
			this.txt_Email.AnimateReadOnly = false;
			this.txt_Email.AsciiOnly = false;
			this.txt_Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.txt_Email.BeepOnError = false;
			this.txt_Email.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
			this.txt_Email.Depth = 0;
			this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.txt_Email.HidePromptOnLeave = false;
			this.txt_Email.HideSelection = true;
			this.txt_Email.Hint = "Enter Your Email";
			this.txt_Email.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
			this.txt_Email.LeadingIcon = null;
			this.txt_Email.Location = new System.Drawing.Point(39, 261);
			this.txt_Email.Mask = "";
			this.txt_Email.MaxLength = 32767;
			this.txt_Email.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.PasswordChar = '\0';
			this.txt_Email.PrefixSuffixText = null;
			this.txt_Email.PromptChar = '_';
			this.txt_Email.ReadOnly = false;
			this.txt_Email.RejectInputOnFirstFailure = false;
			this.txt_Email.ResetOnPrompt = true;
			this.txt_Email.ResetOnSpace = true;
			this.txt_Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_Email.SelectedText = "";
			this.txt_Email.SelectionLength = 0;
			this.txt_Email.SelectionStart = 0;
			this.txt_Email.ShortcutsEnabled = true;
			this.txt_Email.Size = new System.Drawing.Size(284, 48);
			this.txt_Email.SkipLiterals = true;
			this.txt_Email.TabIndex = 13;
			this.txt_Email.TabStop = false;
			this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txt_Email.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
			this.txt_Email.TrailingIcon = null;
			this.txt_Email.UseSystemPasswordChar = false;
			this.txt_Email.ValidatingType = null;
			// 
			// txt_Password
			// 
			this.txt_Password.AllowPromptAsInput = true;
			this.txt_Password.AnimateReadOnly = false;
			this.txt_Password.AsciiOnly = false;
			this.txt_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.txt_Password.BeepOnError = false;
			this.txt_Password.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
			this.txt_Password.Depth = 0;
			this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Password.HidePromptOnLeave = false;
			this.txt_Password.HideSelection = true;
			this.txt_Password.Hint = "Enter Your Password";
			this.txt_Password.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
			this.txt_Password.LeadingIcon = null;
			this.txt_Password.Location = new System.Drawing.Point(39, 345);
			this.txt_Password.Mask = "";
			this.txt_Password.MaxLength = 32767;
			this.txt_Password.MouseState = MaterialSkin.MouseState.OUT;
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.PasswordChar = '*';
			this.txt_Password.PrefixSuffixText = null;
			this.txt_Password.PromptChar = '_';
			this.txt_Password.ReadOnly = false;
			this.txt_Password.RejectInputOnFirstFailure = false;
			this.txt_Password.ResetOnPrompt = true;
			this.txt_Password.ResetOnSpace = true;
			this.txt_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_Password.SelectedText = "";
			this.txt_Password.SelectionLength = 0;
			this.txt_Password.SelectionStart = 0;
			this.txt_Password.ShortcutsEnabled = true;
			this.txt_Password.Size = new System.Drawing.Size(284, 48);
			this.txt_Password.SkipLiterals = true;
			this.txt_Password.TabIndex = 15;
			this.txt_Password.TabStop = false;
			this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txt_Password.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
			this.txt_Password.TrailingIcon = null;
			this.txt_Password.UseSystemPasswordChar = false;
			this.txt_Password.ValidatingType = null;
			// 
			// LoginButton
			// 
			this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.LoginButton.BackColor = System.Drawing.Color.Brown;
			this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.LoginButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
			this.LoginButton.Location = new System.Drawing.Point(206, 412);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(118, 32);
			this.LoginButton.TabIndex = 16;
			this.LoginButton.Text = "Login";
			this.LoginButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.LoginButton.UseVisualStyleBackColor = false;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// ForgetPassword
			// 
			this.ForgetPassword.BackColor = System.Drawing.Color.Moccasin;
			this.ForgetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ForgetPassword.FlatAppearance.BorderSize = 0;
			this.ForgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ForgetPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForgetPassword.ForeColor = System.Drawing.Color.Maroon;
			this.ForgetPassword.Location = new System.Drawing.Point(38, 412);
			this.ForgetPassword.Name = "ForgetPassword";
			this.ForgetPassword.Size = new System.Drawing.Size(162, 32);
			this.ForgetPassword.TabIndex = 17;
			this.ForgetPassword.Text = "Forget Password?";
			this.ForgetPassword.UseVisualStyleBackColor = false;
			this.ForgetPassword.Click += new System.EventHandler(this.ForgetPassword_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Maroon;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new System.Drawing.Point(62, 461);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(237, 18);
			this.label3.TabIndex = 18;
			this.label3.Text = "Don\'t Have an Account? Please";
			// 
			// UserCreateAccount
			// 
			this.UserCreateAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.UserCreateAccount.BackColor = System.Drawing.Color.Brown;
			this.UserCreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.UserCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.UserCreateAccount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
			this.UserCreateAccount.Location = new System.Drawing.Point(39, 494);
			this.UserCreateAccount.Name = "UserCreateAccount";
			this.UserCreateAccount.Size = new System.Drawing.Size(284, 32);
			this.UserCreateAccount.TabIndex = 19;
			this.UserCreateAccount.Text = "Create an Account";
			this.UserCreateAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.UserCreateAccount.UseVisualStyleBackColor = false;
			this.UserCreateAccount.Click += new System.EventHandler(this.UserCreateAccount_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Maroon;
			this.label2.Image = global::CoXBan_tOUR.Properties.Resources.secure;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(34, 317);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "     Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Maroon;
			this.label1.Image = global::CoXBan_tOUR.Properties.Resources.gmail;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(34, 233);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "     Email";
			// 
			// goToAdminPage
			// 
			this.goToAdminPage.Image = global::CoXBan_tOUR.Properties.Resources.mountains__1_;
			this.goToAdminPage.Location = new System.Drawing.Point(117, 35);
			this.goToAdminPage.Name = "goToAdminPage";
			this.goToAdminPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.goToAdminPage.Size = new System.Drawing.Size(137, 119);
			this.goToAdminPage.TabIndex = 4;
			this.goToAdminPage.UseMnemonic = false;
			this.goToAdminPage.Click += new System.EventHandler(this.goToAdminPage_Click);
			// 
			// UserLoginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(362, 588);
			this.ControlBox = false;
			this.Controls.Add(this.UserCreateAccount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ForgetPassword);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_Email);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.title);
			this.Controls.Add(this.goToAdminPage);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "UserLoginPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.UserLoginPage_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Minimize;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label goToAdminPage;
		private System.Windows.Forms.Label txt_Date;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label label1;
		private MaterialSkin.Controls.MaterialMaskedTextBox txt_Email;
		private MaterialSkin.Controls.MaterialMaskedTextBox txt_Password;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Button ForgetPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button UserCreateAccount;
	}
}