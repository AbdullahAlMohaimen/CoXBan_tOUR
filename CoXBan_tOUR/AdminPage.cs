using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoXBan_tOUR
{
	public partial class AdminPage : Form
	{
		string connectionString = "Data Source=DESKTOP-3K3POSS\\SQLEXPRESS;Initial Catalog=CoxBan_Tour;Persist Security Info=True;User ID=sa;Password=123456";
		public AdminPage()
		{
			InitializeComponent();
		}


		//Collect Login Email
		public string AdminEmail;
		public string SetAdminEmail
		{
			get { return AdminEmail; }
			set { AdminEmail = value; }
		}

		private void AdminPage_Load(object sender, EventArgs e)
		{

		}
	}
}
