using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldStar
{
    public partial class Booking : UserControl
    {
        Connection con = new Connection();
        public Booking()
        {
            InitializeComponent();
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            AddReservation reservation = new AddReservation();
            reservation.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditReservation edit = new EditReservation();
            edit.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            CancelBooking cancel = new CancelBooking();
            cancel.Show();
        }

        private void data_bookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = data_bookings.Rows[e.RowIndex];
                Utils.BookingID = int.Parse(row.Cells[0].Value.ToString());
            } catch (Exception) {}
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            var con = new Connection();
            var isAcceptedQuery = $"SELECT accepted FROM booking WHERE id = '{Utils.BookingID}'";
            var result = con.ReadString(isAcceptedQuery);

            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Booking already accepted");
            } else
            {
                var acceptBookingQuery = $"UPDATE booking SET accepted = 'Yes' WHERE id = '{Utils.BookingID}'";
                con.ExecuteQuery(acceptBookingQuery);
                MessageBox.Show("Booking accepted successfully");
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            var con = new Connection();
            // Check if the booking that has been selected has not been checked out of
            var checkoutStatusQuery = $"SELECT checkout FROM booking WHERE id = '{Utils.BookingID}' AND checkout = 'successful'";
            var result = con.ReadString(checkoutStatusQuery);

            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Checkout already completed");
            }
            else
            {
                var checkoutQuery = $"UPDATE booking SET checkout = 'successful' WHERE id = '{Utils.BookingID}'";
                con.ExecuteQuery(checkoutQuery);
                AddReview addReview = new AddReview();
                addReview.Show();
            }
        }
    }
}
