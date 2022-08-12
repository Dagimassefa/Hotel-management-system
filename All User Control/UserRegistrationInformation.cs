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
    public partial class UserRegistrationInformation : UserControl
    {
        Function fn = new Function();
        string query;
        public UserRegistrationInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "select customer.Cid,customer.Identification_Number,customer.First_name,customer.phone_number,customer.nationality,customer.gender,customer.Address,customer.Last_name,customer.check_in,customer.check_out,rooms.roomno,rooms.roomtype,rooms.RoomStatus,rooms.price from customer inner join rooms on customer.roomId=rooms.roomId where First_name='" + txtUUsername.Text + "' and Identification_Number='" + textBox1.Text + "'";
                DataSet ds = fn.getData(query);
           dataGridView1.DataSource = ds.Tables[0];
            txtUUsername.Text = "";
            
        }

        private void UserRegistrationInformation_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string newname = txtNewname.Text;
            string newadress = txtnewaddress.Text;
            Int64 phone = Int64.Parse(txtnewphone.Text);
            query = "update customer set First_name='" + newname + "',Address='"+newadress+ "',phone_number='"+phone+ "'where Identification_Number='" + textBox1.Text + "' ";
            fn.setData(query, "Your Information Had Been Changed Successfully;");
            txtNewname.Text = "";
            txtnewaddress.Text = "";
            txtnewphone.Text = "";
            
        }
    }
}
