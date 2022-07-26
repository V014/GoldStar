﻿using System;
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
<<<<<<< HEAD
        StyleDataGrid style = new StyleDataGrid();

=======
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
        public Home()
        {
            InitializeComponent();

<<<<<<< HEAD
            lbl_title.Text = "Welcome, " + loadUsername();
            lbl_sub.Text = "These are the services we offer here at GoldStar";
            lbl_id.Text = "Guest ID: " + Utils.GetUserID();
=======
            lbl_title.Text = "Welcome, These are our services";
            lbl_username.Text = loadUsername();
            lbl_id.Text = Utils.GetUserID();
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062

            Welcome welcome = new Welcome();
            this.panel_main.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;
<<<<<<< HEAD
            
            con.LoadData("SELECT * FROM services", welcome.data_services);
            style.style(welcome.data_services);

=======

            string queryServices = "SELECT * FROM services";
            con.LoadData(queryServices, welcome.data_services);
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
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
<<<<<<< HEAD
            string queryReviews = "SELECT * FROM review";
=======
            string queryReviews = $"SELECT u.username, r.comment, r.rating, rm.room_no FROM review AS r INNER JOIN booking AS b ON b.id = r.booking_id INNER JOIN user AS u ON b.user_id = u.id INNER JOIN room AS rm ON rm.id = b.room_number";
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            con.LoadData(queryReviews, review.data_reviews);
        }
        public string loadUsername()
        {
<<<<<<< HEAD
            string name = con.ReadString($"SELECT username FROM user WHERE id = {Utils.GetUserID()}");
=======
            var con = new Connection();
            var querySignout = $"SELECT username FROM user WHERE id = {Utils.GetUserID()}";
            string name = con.ReadString(querySignout);
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            return name;
        }
        public void shutdown()
        {
<<<<<<< HEAD
            string id = Utils.GetUserID();
            con.ExecuteQuery($"UPDATE user SET 'status' = 'offline' WHERE id = {id}");
        }
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.ExecuteQuery("UPDATE user SET status = 'offline'");
            Application.Exit();
=======
            var con = new Connection();
            string id = Utils.GetUserID();
            var querySignout = $"UPDATE user SET 'status' = 'offline' WHERE id = {id}";
            con.ExecuteQuery(querySignout);
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
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
<<<<<<< HEAD
=======
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Clicking the sign out button safely exits the session, please use it to be sure of your privacy");
            Application.Exit();
        }
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
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
<<<<<<< HEAD
=======

>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
        private void btn_profile_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            Profile profile = new Profile();
            this.panel_main.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
        }
    }
}
