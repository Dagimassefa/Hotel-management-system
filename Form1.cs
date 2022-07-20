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
    public partial class Form1 : Form
    {
        Function fn = new Function();
        string query;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select username,pass from employee where username='" + txtUsername.Text + "' and pass='" + txtPassword.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count!=0)
            {
                labelError.Visible = false;
               Dashbord dash = new Dashbord();
                this.Hide();
                dash.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Login user_login = new User_Login();
            this.Hide();
            user_login.Show();


        }
    }
}
