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
    public partial class DashboardUser : Form
    {
        public DashboardUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCourseRegistration_Click(object sender, EventArgs e)
        {
            userRegistrationInformation1.Visible = true;
            userRegistrationInformation1.BringToFront();
           
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            availableRooms1.Visible = true;
            availableRooms1.BringToFront();
        }

        private void btnCoustomerDetail_Click(object sender, EventArgs e)
        {
            aboutTheHotel1.Visible = true;
            aboutTheHotel1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                User_Login user = new User_Login();
                user.Show();
            }
        }
    }
}
