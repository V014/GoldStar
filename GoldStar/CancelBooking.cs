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
    public partial class CancelBooking : Form
    {
        public CancelBooking()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var con = new Connection();
            String deleteBookingQuery = $"DELETE FROM booking WHERE id = {Utils.BookingID} AND checkout IS NULL";
            con.ExecuteQuery(deleteBookingQuery);
            this.Close();
=======

>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
        }
    }
}
