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
    public partial class UC_AddRoom : UserControl
    {
        Function fn = new Function();
        string query;

        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//used to add customer(register)button
        {
            if (texRoomNo.Text != null && txtType.Text != null && txtStatus != null && txtPrice != null)
            {
                string roomNo = texRoomNo.Text;
                string roomtype = txtType.Text;
                string Roomstatus = txtStatus.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                query = "insert into rooms (roomno,roomtype,roomStatus,price) values ('" + roomNo + "','" + roomtype + "','" + Roomstatus + "'," + price + ")";
                fn.setData(query, "room added");
                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
                MessageBox.Show("please fill all the fields!", "warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        public void clearAll()
        {
            texRoomNo.Clear();
            txtType.SelectedIndex = -1;
            txtStatus.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
           DataSet ds=fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
