using System;
using System.Windows.Forms;

namespace GoldStar
{
    public partial class EditBooking : Form
    {
        Connection con = new Connection();
        public EditBooking()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var type = txt_roomType.Text;
            var beds = txt_beds;
            var services = txt_services;
            var to = txt_to;
            var from = txt_from;
            string id = Utils.GetUserID();
            string queryUpdate = $"UPDATE booking SET RoomType = '{type}', beds = {beds}, start_date = {from}, end_date {to} WHERE id = {id}";
        }
    }
}
