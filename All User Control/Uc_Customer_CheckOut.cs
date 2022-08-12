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
    public partial class Uc_Customer_CheckOut : UserControl
    {
        Function fn = new Function();
        string query;
        public Uc_Customer_CheckOut()
        {
            InitializeComponent();
        }

        private void Uc_Customer_CheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.Cid,customer.Identification_Number,customer.First_name,customer.phone_number,customer.nationality,customer.gender,customer.Address,customer.Last_name,customer.check_in,rooms.roomno,rooms.roomtype,rooms.RoomStatus,rooms.price from customer inner join rooms on customer.roomId=rooms.roomId where check_out='No'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.Cid,customer.Identification_Number,customer.First_name,customer.phone_number,customer.nationality,customer.gender,customer.Address,customer.Last_name,customer.check_in,rooms.roomno,rooms.roomtype,rooms.RoomStatus,rooms.price from customer inner join rooms on customer.roomId=rooms.roomId where First_name like '" + txtName.Text + "%' and check_out='No'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (txtCname.Text != null)
            {
                if (MessageBox.Show("Are you sure?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string cdate = txtCheckOutDate.Text;
                    query = "update customer set check_out='YES',check_out_temp='" + cdate + "' where Cid=" + id + " update rooms set booked='No' where roomno='" + txtRoom.Text + "' ";
                    fn.setData(query, "Check out Successfully;");
                    Uc_Customer_CheckOut_Load(this, null);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("no customer selected", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtCname.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();

        }

        private void Uc_Customer_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
