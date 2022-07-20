using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class User_Login : Form
    {
        Function fn = new Function();
        string query;
        public User_Login()
        {
            InitializeComponent();
        }

        private void btnULogin_Click_1(object sender, EventArgs e)
        {
            query = "select First_name,Identification_Number from customer where First_name='" + txtUUsername.Text + "' and Identification_Number='" + txtUPassword.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;
                DashboardUser dbu = new DashboardUser();
                this.Hide();
                dbu.Show();
            }
            else
            {
                labelError.Visible = true;
                txtUPassword.Clear();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
