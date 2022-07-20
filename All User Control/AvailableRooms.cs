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
    public partial class AvailableRooms : UserControl
    {
        Function fn = new Function();
        string query;
        public AvailableRooms()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            query = "select rooms.roomno,rooms.roomtype,rooms.RoomStatus,rooms.price from rooms where rooms.booked='no' and RoomStatus='Available'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
