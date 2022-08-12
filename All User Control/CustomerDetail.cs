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
    public partial class CustomerDetail : UserControl
    {
        Function fn = new Function();
        string query;
        public CustomerDetail()
        {
            InitializeComponent();
        }

        private void txtsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtsearchby.SelectedIndex == 0)
            {
                query = "select customer.Cid,customer.Identification_Number,customer.First_name,customer.phone_number,customer.nationality,customer.gender,customer.Address,customer.Last_name,customer.check_in,customer.check_out,rooms.roomno,rooms.roomtype,rooms.RoomStatus,rooms.price from customer inner join rooms on customer.roomId=rooms.roomId";
               DataSet ds= fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 1)
            {
                query = "select customer.Cid,customer.Identification_Number,customer.First_name,customer.phone_number,customer.nationality,customer.gender,customer.Address,customer.Last_name,customer.check_in,customer.check_out,rooms.roomno,rooms.roomtype,rooms.RoomStatus,rooms.price from customer inner join rooms on customer.roomId=rooms.roomId where check_out='No'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 2)
            {
                query = "select customer.Cid,customer.Identification_Number,customer.First_name,customer.phone_number,customer.nationality,customer.gender,customer.Address,customer.Last_name,customer.check_in,customer.check_out,rooms.roomno,rooms.roomtype,rooms.RoomStatus,rooms.price from customer inner join rooms on customer.roomId=rooms.roomId where check_out='Yes'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 3)
            {
                query = "select * from rooms";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 4)
            {
                query = "select * from rooms where RoomStatus='reserved'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 5)
            {
                query = "select * from rooms where roomtype='single' and RoomStatus='avialable'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 6)
            {
                query = "select * from rooms where roomtype='single' and RoomStatus='reserved'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 7)
            {
                query = "select * from rooms where roomtype='Double' and RoomStatus='avialable'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 8)
            {
                query = "select * from rooms where roomtype='Double' and RoomStatus='reserved'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 9)
            {
                query = "select * from rooms where roomtype='Family' and RoomStatus='avialable'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 10)
            {
                query = "select * from rooms where roomtype='Family' and RoomStatus='reserved'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void CustomerDetail_Leave(object sender, EventArgs e)
        {
            txtsearchby.SelectedIndex = -1;
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
