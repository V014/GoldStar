using System;
using System.Windows.Forms;

namespace GoldStar
{
    
    public partial class Admin : Form
    {
        Connection con = new Connection();
        public Admin()
        {
            InitializeComponent();
            lbl_title.Text = "Welcome!";
            loadHome();
            
        }
        public void loadBookings()
        {
            this.panel_main.Controls.Clear();
            Booking booking = new Booking();
            this.panel_main.Controls.Add(booking);
            booking.Dock = DockStyle.Fill;
            booking.Show();
            string queryBookings = "SELECT * FROM booking";
            con.LoadData(queryBookings, booking.data_bookings);
        }
        private void loadReviews()
        {
            this.panel_main.Controls.Clear();
            Reviews reviews = new Reviews();
            this.panel_main.Controls.Add(reviews);
            reviews.Dock = DockStyle.Fill;
            reviews.Show();
            string queryReviews = "SELECT * FROM review";
            con.LoadData(queryReviews, reviews.data_reviews);
        }
        private void loadCustomers()
        {
            this.panel_main.Controls.Clear();
            Customers customer = new Customers();
            this.panel_main.Controls.Add(customer);
            customer.Dock = DockStyle.Fill;
            customer.Show();
            string queryCustomers = "SELECT * FROM contact";
            con.LoadData(queryCustomers, customer.data_customers);
            customer.data_customers.Columns[0].Visible = false;
        }
        private void loadRooms()
        {
            this.panel_main.Controls.Clear();
            Room room = new Room();
            this.panel_main.Controls.Add(room);
            room.Dock = DockStyle.Fill;
            room.Show();
            string queryRooms = "SELECT * FROM room";
            con.LoadData(queryRooms, room.data_room);
            room.data_room.Columns[0].Visible = false;
        }
        private void loadServices()
        {
            this.panel_main.Controls.Clear();
            Services services = new Services();
            this.panel_main.Controls.Add(services);
            services.Dock = DockStyle.Fill;
            services.Show();
            string queryServices = "SELECT * FROM services";
            con.LoadData(queryServices, services.data_services);
            services.data_services.Columns[0].Visible = false;
        }
        private void loadHome()
        {
            AdminWelcome welcome = new AdminWelcome();
            this.panel_main.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;
            welcome.Show();
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            AdminWelcome welcome = new AdminWelcome();
            this.panel_main.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;
            welcome.Show();
            lbl_title.Text = "Home";
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            loadBookings();
            lbl_title.Text = "Bookings";
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            loadReviews();
            lbl_title.Text = "Reviews";
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            loadCustomers();
            lbl_title.Text = "Customers";
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            loadRooms();
            lbl_title.Text = "Rooms";
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            loadServices();
            lbl_title.Text = "Services";
        }

        private void btn_signOut_Click(object sender, EventArgs e)
        {
            var con = new Connection();
            var querySignout = $"UPDATE user SET 'status' = 'offline' WHERE id = {Utils.GetUserID()}";
            con.ExecuteQuery(querySignout);
            var login = new Login();
            this.Hide();
            login.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            string query = "UPDATE user SET status = 'offline' WHERE status = 'online'";
            con.ExecuteQuery(query);
            Application.Exit();
        }

    }
}
