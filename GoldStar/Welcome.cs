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
    public partial class Welcome : UserControl
    {
        public Welcome()
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
    }
}
