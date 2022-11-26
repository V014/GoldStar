using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldStar
{
    public partial class EditReservation : Form
    {
        public EditReservation()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var con = new Connection();
            String roomNo = txt_roomNumber.Text;
            int total = Utils.GetRoomPrice(roomNo);
<<<<<<< HEAD

            DateTime fromDate = DateTime.Parse(txt_startDate.Text);
            string from = Utils.FormatDateTime(fromDate);

            DateTime toDate = DateTime.Parse(txt_endDate.Text);
            string to = Utils.FormatDateTime(toDate);
            var range = toDate.Subtract(fromDate);
=======
            String from = Utils.FormatDateTime(DateTime.Parse(txt_startDate.Text));
            String to = Utils.FormatDateTime(DateTime.Parse(txt_endDate.Text));
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062

            foreach (var service in txt_services.CheckedItems)
            {
                var serviceType = service.ToString();
                var serviceID = Utils.GetServiceId(serviceType, con);
                var serviceQuery = $"INSERT INTO booking_services (booking_id, service_id) VALUES ('{Utils.BookingID}', '{serviceID}')";
                total += Utils.GetServicePrice(serviceID);
                con.ExecuteQuery(serviceQuery);
            }

<<<<<<< HEAD
            total = total * range.Days;
=======
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            var query = $"UPDATE booking SET room_number = '{roomNo}', cost = '{total}', start_date = '{from}', end_date = '{to}' WHERE id = {Utils.BookingID}";
            con.ExecuteQuery(query);
            this.Close();
        }
    }
}
