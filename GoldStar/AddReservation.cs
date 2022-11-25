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
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var conn = new Connection();

            var userID = Utils.GetUserID();
            var roomType = txt_roomType.Text;
            var beds = txt_beds.Text;

            DateTime fromDate = DateTime.Parse(txt_start_date.Text);
            String from = Utils.FormatDateTime(fromDate);

            DateTime toDate = DateTime.Parse(txt_end_date.Text);
            String to = Utils.FormatDateTime(toDate);

            String booking = DateTime.Now.ToShortDateString();
            
            var bookingQuery = $"INSERT INTO booking (user_id, start_date, end_date, type, beds, date) VALUES ('{userID}', '{from}', '{to}', '{roomType},', '{beds}', '{booking}')";
            conn.ExecuteQuery(bookingQuery);
            var bookingID = conn.ReadString("SELECT id FROM booking ORDER BY id DESC LIMIT 1");

            foreach (var service in txt_services.CheckedItems)
            {
                var serviceType = service.ToString();
                var serviceID = Utils.GetServiceId(serviceType, conn);
                var serviceQuery = $"INSERT INTO booking_services (booking_id, service_id) VALUES ('{bookingID}', '{serviceID}')";
                conn.ExecuteQuery(serviceQuery);
            }
            // closes the form
            this.Close();
        }
    }
}
