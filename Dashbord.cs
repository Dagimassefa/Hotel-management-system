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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerDetail1.Visible = true;
            customerDetail1.BringToFront();
            Movingpanel.Left = btnCoustomerDetail.Left + 18;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCourseRegistration_Click(object sender, EventArgs e)
        {
            Movingpanel.Left = btnCourseRegistration.Left+18;
            uC_customer1.Visible = true;
            uC_customer1.BringToFront();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Movingpanel.Left = btnAddRoom.Left + 18;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }


        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Movingpanel.Left = btnEmployee.Left + 18;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_customer1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void uc_Customer_CheckOut1_Load(object sender, EventArgs e)
        {
            uc_Customer_CheckOut1.Visible = true;
            uc_Customer_CheckOut1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Movingpanel.Left = btnCheckOut.Left + 18;
            uc_Customer_CheckOut1.Visible = true;
            uc_Customer_CheckOut1.BringToFront();
        }

        private void uc_Customer_CheckOut1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
