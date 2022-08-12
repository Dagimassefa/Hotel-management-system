using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.All_User_Control
{
    public partial class UC_customer : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_customer()
        {
            InitializeComponent();
        }
        public void setComboBox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            texRoomNo.Items.Clear();
            txtprice.Clear();
            query = "select roomno from rooms where booked='no'";
            setComboBox(query, texRoomNo);
        }
        int rid;
        private void texRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomId from rooms where roomno='" + texRoomNo.Text + "'";
            DataSet ds = fn.getData(query);
            txtprice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnAllocateRoom_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtFname.Text != "" && txtPhone.Text != "" && txtNationality.Text != "" && txtgender.Text != "" && txtaddress.Text != "" &&
                txtLname.Text != "" && txtcheckIn.Text != "" && txtType.Text != "" && txtStatus.Text != "" && texRoomNo.Text != "" && txtprice.Text != "")
            {
                string id = txtId.Text;
                string fname = txtFname.Text;
                Int64 phone = Int64.Parse(txtPhone.Text);
                string nationality = txtNationality.Text;
                string gender = txtgender.Text;
                string address = txtaddress.Text;
                string lname = txtLname.Text;
                string checkin = txtcheckIn.Text;
                query = "insert into customer(Identification_Number,First_name,phone_number,nationality,gender,Address,Last_name,check_in,roomId) values('" + id + "','" + fname + "'," + phone + ",'" + nationality + "','" + gender + "','" + address + "','" + lname + "','" + checkin + "'," + rid + ") update rooms set booked='YES' where roomno='" + texRoomNo.Text + "'";
                fn.setData(query, "Room Number" + texRoomNo.Text + "Allocation Successful!");
                clearAll();
            }
            else
                MessageBox.Show("All items are mandatory!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void clearAll()
        {
            txtId.Clear();
            txtFname.Clear();
            txtPhone.Clear();
            txtNationality.Clear();
            txtgender.SelectedIndex = -1;
            txtaddress.Clear();
            txtLname.Clear();
            txtcheckIn.ResetText();
            txtStatus.SelectedIndex = -1;
            txtType.SelectedIndex = -1;
            texRoomNo.Items.Clear();
            txtprice.Clear();

        }


        private void UC_customer_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
