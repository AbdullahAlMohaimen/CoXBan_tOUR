using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoXBan_tOUR
{
	public partial class UserProfile : Form
	{
		public UserProfile()
		{
			InitializeComponent();
		}

		public string userName;
		public string SetName
		{
			get { return userName; }
			set { userName = value; }
		}

		private void Minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void UserProfile_Load(object sender, EventArgs e)
		{
			//CURRENT DATE
			DateTime dateTime = DateTime.UtcNow.Date;
			txt_Date.Text = dateTime.ToString("dd - MM - yyyy");

			txt_Name.Text = userName;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
