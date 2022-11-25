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
            var con = new Connection();
            String deleteBookingQuery = $"DELETE FROM booking WHERE id = {Utils.BookingID} AND checkout IS NULL";
            con.ExecuteQuery(deleteBookingQuery);
            this.Close();
        }
    }
}
