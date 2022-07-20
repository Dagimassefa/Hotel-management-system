using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxId();
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            if (txtname.Text !="" && txtphone.Text != "" && txtgender.Text != "" && txtemail.Text != "" && txtusername.Text != "" && txtpassword.Text != "")
            {
                string name = txtname.Text;
                Int64 phone = Int64.Parse(txtphone.Text);
                string gender = txtgender.Text;
                string email = txtemail.Text;
                string username = txtusername.Text;
                string pass = txtpassword.Text;
              
                query = "insert into employee(ename,phone,gender,email,username,pass) values('"+name+"','"+phone+"','"+gender+"','"+email+"','"+username+"','"+pass+"')";
                fn.setData(query, "Employee has been registered successfully");
                clearAll();
            }
            else
            {
                MessageBox.Show("please fill all the fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void getMaxId()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSet.Text = (num + 1).ToString();
            }
        }
        public void clearAll()
        {
            txtname.Clear();
            txtpassword.Clear();
            txtemail.Clear();
            txtgender.SelectedIndex = -1;
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "") {
               if( MessageBox.Show("ARE YOU SURE YOU WANT TO REMOVE THIS EMPLOYEE", "CONFIRMATOION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid='" + txtId.Text + "'";
                    fn.setData(query, "employee has been successfully removed");
                    tabControl1_SelectedIndexChanged(this, null);
                }
                
            }
           
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
