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
            DataGridViewRow row = data_bookings.Rows[e.RowIndex];
            Utils.BookingID = int.Parse(row.Cells[0].Value.ToString());
        }
    }
}
