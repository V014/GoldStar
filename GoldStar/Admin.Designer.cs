namespace GoldStar
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_services = new System.Windows.Forms.Button();
            this.btn_rooms = new System.Windows.Forms.Button();
            this.btn_signOut = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_review = new System.Windows.Forms.Button();
            this.btn_booking = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_nav.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Khaki;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Black;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(200, 52);
            this.btn_home.TabIndex = 5;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(200, 60);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(525, 471);
            this.panel_main.TabIndex = 3;
            // 
            // panel_nav
            // 
            this.panel_nav.Controls.Add(this.btn_services);
            this.panel_nav.Controls.Add(this.btn_rooms);
            this.panel_nav.Controls.Add(this.btn_signOut);
            this.panel_nav.Controls.Add(this.btn_customers);
            this.panel_nav.Controls.Add(this.btn_review);
            this.panel_nav.Controls.Add(this.btn_booking);
            this.panel_nav.Controls.Add(this.btn_home);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(200, 531);
            this.panel_nav.TabIndex = 2;
            // 
            // btn_services
            // 
            this.btn_services.BackColor = System.Drawing.Color.Khaki;
            this.btn_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_services.FlatAppearance.BorderSize = 0;
            this.btn_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_services.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_services.ForeColor = System.Drawing.Color.Black;
            this.btn_services.Location = new System.Drawing.Point(0, 260);
            this.btn_services.Name = "btn_services";
            this.btn_services.Size = new System.Drawing.Size(200, 52);
            this.btn_services.TabIndex = 11;
            this.btn_services.Text = "Services";
            this.btn_services.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_services.UseVisualStyleBackColor = false;
            this.btn_services.Click += new System.EventHandler(this.btn_services_Click);
            // 
            // btn_rooms
            // 
            this.btn_rooms.BackColor = System.Drawing.Color.Khaki;
            this.btn_rooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rooms.FlatAppearance.BorderSize = 0;
            this.btn_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rooms.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rooms.ForeColor = System.Drawing.Color.Black;
            this.btn_rooms.Location = new System.Drawing.Point(0, 208);
            this.btn_rooms.Name = "btn_rooms";
            this.btn_rooms.Size = new System.Drawing.Size(200, 52);
            this.btn_rooms.TabIndex = 10;
            this.btn_rooms.Text = "Rooms";
            this.btn_rooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rooms.UseVisualStyleBackColor = false;
            this.btn_rooms.Click += new System.EventHandler(this.btn_rooms_Click);
            // 
            // btn_signOut
            // 
            this.btn_signOut.BackColor = System.Drawing.Color.Khaki;
            this.btn_signOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_signOut.FlatAppearance.BorderSize = 0;
            this.btn_signOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signOut.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signOut.ForeColor = System.Drawing.Color.Black;
            this.btn_signOut.Location = new System.Drawing.Point(0, 479);
            this.btn_signOut.Name = "btn_signOut";
            this.btn_signOut.Size = new System.Drawing.Size(200, 52);
            this.btn_signOut.TabIndex = 9;
            this.btn_signOut.Text = "Sign out";
            this.btn_signOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signOut.UseVisualStyleBackColor = false;
            this.btn_signOut.Click += new System.EventHandler(this.btn_signOut_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.Color.Khaki;
            this.btn_customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customers.FlatAppearance.BorderSize = 0;
            this.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.Color.Black;
            this.btn_customers.Location = new System.Drawing.Point(0, 156);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(200, 52);
            this.btn_customers.TabIndex = 8;
            this.btn_customers.Text = "Customers";
            this.btn_customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.UseVisualStyleBackColor = false;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_review
            // 
            this.btn_review.BackColor = System.Drawing.Color.Khaki;
            this.btn_review.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_review.FlatAppearance.BorderSize = 0;
            this.btn_review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_review.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_review.ForeColor = System.Drawing.Color.Black;
            this.btn_review.Location = new System.Drawing.Point(0, 104);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(200, 52);
            this.btn_review.TabIndex = 7;
            this.btn_review.Text = "Reviews";
            this.btn_review.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_review.UseVisualStyleBackColor = false;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // btn_booking
            // 
            this.btn_booking.BackColor = System.Drawing.Color.Khaki;
            this.btn_booking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_booking.FlatAppearance.BorderSize = 0;
            this.btn_booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_booking.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_booking.ForeColor = System.Drawing.Color.Black;
            this.btn_booking.Location = new System.Drawing.Point(0, 52);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(200, 52);
            this.btn_booking.TabIndex = 6;
            this.btn_booking.Text = "Bookings";
            this.btn_booking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_booking.UseVisualStyleBackColor = false;
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Khaki;
            this.panel_top.Controls.Add(this.lbl_title);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(200, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(525, 60);
            this.panel_top.TabIndex = 4;
            // 
            // lbl_title
            // 
            this.lbl_title.AllowDrop = true;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(16, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 29);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Page Title";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 531);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_nav);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.panel_nav.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_services;
        private System.Windows.Forms.Button btn_rooms;
        private System.Windows.Forms.Button btn_signOut;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_review;
        private System.Windows.Forms.Button btn_booking;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_title;
    }
}