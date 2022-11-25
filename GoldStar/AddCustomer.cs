using System;
using System.Windows.Forms;

namespace GoldStar
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var con = new Connection();

            string firstname = txt_fname.Text;
            string lastname = txt_lname.Text;
            string roomNumber = txt_roomNumber.Text;

            DateTime fromDate = DateTime.Parse(txt_dob.Text);
            string from = Utils.FormatDateTime(fromDate);

            DateTime toDate = DateTime.Parse(dateTimePicker1.Text);
            string to = Utils.FormatDateTime(toDate);

            string phoneNumber = txt_phoneNumber.Text;
            string address = txt_address.Text;
            string password = txt_password.Text;
            string username = txt_username.Text;

            var queryCreateUser = $"INSERT INTO user (username, role, password) VALUES ('{username}', 'Customer', '{password}')";
            con.ExecuteQuery(queryCreateUser);

            var queryUserID = $"SELECT id FROM user WHERE username = '{username}'";
            var userID = "";
            userID = con.ReadString(queryUserID);

            var queryCreateContact = $"INSERT INTO contact (user_id, phone_number, firstname, lastname, address) VALUES ('{userID}', '{phoneNumber}', '{firstname}', '{lastname}', '{address}')";
            con.ExecuteQuery(queryCreateContact);

            var queryCreateBooking = $"INSERT INTO booking (user_id, room_number, start_date, end_date) VALUES ('{userID}', '{roomNumber}', '{from}', '{to}')";
            con.ExecuteQuery(queryCreateBooking);
            
            this.Close();
        }
    }
}
