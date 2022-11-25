using System;
using System.Windows.Forms;

namespace GoldStar
{
    public partial class BookRoom : Form
    {
        Connection con = new Connection();
        string date = DateTime.Now.ToString("g");
        public BookRoom()
        {
            InitializeComponent();
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            var customerID = txt_customerID.Text;
            var roomType = txt_roomType.Text;
            var beds = txt_beds.Text;
            var services = txt_services.Text;

            DateTime startDate = DateTime.Parse(dateStart.Text);
            String start = Utils.FormatDateTime(startDate);

            DateTime endDate = DateTime.Parse(dateEnd.Text);
            String end = Utils.FormatDateTime(endDate);

            var id = Utils.GetUserID();
            string queryEntry = $"SELECT Room_Number FROM booking WHERE user_id = {id}";
            string room = con.ReadString(queryEntry);

            if (room != "")
            {
                MessageBox.Show($"Reservation in room {room} between dates {start} to {end}");
            }
            else 
            {
                try
                {
                    string queryBookng = $"INSERT INTO booking VALUES(NULL, {customerID}, NULL, '{start}', '{end}', '{roomType}', {beds}, '{date}')";
                    con.ExecuteQuery(queryBookng);
                    MessageBox.Show("Reservation recieved, the room number will appear when a room is booked");
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to book room!");
                }
                
            }
        }
    }
}
