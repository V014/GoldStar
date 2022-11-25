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
    public partial class Home : Form
    {
        Connection con = new Connection();
        StyleDataGrid style = new StyleDataGrid();

        public Home()
        {
            InitializeComponent();

            lbl_title.Text = "Welcome, " + loadUsername();
            lbl_sub.Text = "These are the services we offer here at GoldStar";
            lbl_id.Text = "Guest ID: " + Utils.GetUserID();

            Welcome welcome = new Welcome();
            this.panel_main.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;
            
            con.LoadData("SELECT * FROM services", welcome.data_services);
            style.style(welcome.data_services);

            welcome.data_services.Columns[0].Visible = false;
            welcome.Show();  
        }
        public void loadbookings()
        {
            this.panel_main.Controls.Clear();
            Booking booking = new Booking();
            this.panel_main.Controls.Add(booking);
            booking.Dock = DockStyle.Fill;
            booking.Show();
            string id = Utils.GetUserID();
            string queryBookings = $"SELECT * FROM booking WHERE user_id = '{id}'";
            con.LoadData(queryBookings, booking.data_bookings);
            booking.data_bookings.Columns[0].Visible = false;
        }
        public void loadReviews()
        {
            this.panel_main.Controls.Clear();
            Reviews review = new Reviews();
            this.panel_main.Controls.Add(review);
            review.Dock = DockStyle.Fill;
            review.Show();
            string id = Utils.GetUserID();
            string queryReviews = "SELECT * FROM review";
            con.LoadData(queryReviews, review.data_reviews);
        }
        public string loadUsername()
        {
            string name = con.ReadString($"SELECT username FROM user WHERE id = {Utils.GetUserID()}");
            return name;
        }
        public void shutdown()
        {
            string id = Utils.GetUserID();
            con.ExecuteQuery($"UPDATE user SET 'status' = 'offline' WHERE id = {id}");
        }
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.ExecuteQuery("UPDATE user SET status = 'offline'");
            Application.Exit();
        }
        private void btn_booking_Click(object sender, EventArgs e)
        {
            loadbookings();
            lbl_title.Text = "Bookings";
        }
        private void btn_signOut_Click(object sender, EventArgs e)
        {
            shutdown();
            var login = new Login();
            this.Hide();
            login.Show();
        }
        private void btn_review_Click(object sender, EventArgs e)
        {
            loadReviews();
            lbl_title.Text = "Reviews";
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            lbl_title.Text = "Welcome, These are our services";
            Welcome welcome = new Welcome();
            this.panel_main.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;
            string queryServices = "SELECT * FROM services";
            con.LoadData(queryServices, welcome.data_services);
            welcome.data_services.Columns[0].Visible = false;
            welcome.Show();
        }
        private void btn_profile_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            Profile profile = new Profile();
            this.panel_main.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
        }
    }
}
