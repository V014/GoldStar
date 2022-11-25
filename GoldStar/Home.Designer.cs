namespace GoldStar
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_review = new System.Windows.Forms.Button();
            this.btn_booking = new System.Windows.Forms.Button();
            this.btn_signOut = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_sub = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_nav.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_nav
            // 
            this.panel_nav.Controls.Add(this.btn_profile);
            this.panel_nav.Controls.Add(this.btn_review);
            this.panel_nav.Controls.Add(this.btn_booking);
            this.panel_nav.Controls.Add(this.btn_signOut);
            this.panel_nav.Controls.Add(this.btn_home);
            this.panel_nav.Controls.Add(this.btn_back);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(55, 531);
            this.panel_nav.TabIndex = 0;
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.Location = new System.Drawing.Point(0, 208);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(55, 52);
            this.btn_profile.TabIndex = 10;
            this.btn_profile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_review
            // 
            this.btn_review.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_review.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_review.FlatAppearance.BorderSize = 0;
            this.btn_review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_review.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_review.ForeColor = System.Drawing.Color.White;
            this.btn_review.Image = ((System.Drawing.Image)(resources.GetObject("btn_review.Image")));
            this.btn_review.Location = new System.Drawing.Point(0, 156);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(55, 52);
            this.btn_review.TabIndex = 7;
            this.btn_review.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_review.UseVisualStyleBackColor = false;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // btn_booking
            // 
            this.btn_booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_booking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_booking.FlatAppearance.BorderSize = 0;
            this.btn_booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_booking.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_booking.ForeColor = System.Drawing.Color.White;
            this.btn_booking.Image = ((System.Drawing.Image)(resources.GetObject("btn_booking.Image")));
            this.btn_booking.Location = new System.Drawing.Point(0, 104);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(55, 52);
            this.btn_booking.TabIndex = 6;
            this.btn_booking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_booking.UseVisualStyleBackColor = false;
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // btn_signOut
            // 
            this.btn_signOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_signOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_signOut.FlatAppearance.BorderSize = 0;
            this.btn_signOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signOut.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.btn_signOut.ForeColor = System.Drawing.Color.White;
            this.btn_signOut.Location = new System.Drawing.Point(0, 479);
            this.btn_signOut.Name = "btn_signOut";
            this.btn_signOut.Size = new System.Drawing.Size(55, 52);
            this.btn_signOut.TabIndex = 9;
            this.btn_signOut.Text = "Exit";
            this.btn_signOut.UseVisualStyleBackColor = false;
            this.btn_signOut.Click += new System.EventHandler(this.btn_signOut_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(0, 52);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(55, 52);
            this.btn_home.TabIndex = 5;
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(55, 52);
            this.btn_back.TabIndex = 11;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // panel_main
            // 
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(55, 156);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(10);
            this.panel_main.Size = new System.Drawing.Size(860, 375);
            this.panel_main.TabIndex = 1;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel_top.Controls.Add(this.lbl_id);
            this.panel_top.Controls.Add(this.lbl_sub);
            this.panel_top.Controls.Add(this.lbl_title);
            this.panel_top.Controls.Add(this.pictureBox1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(55, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(860, 156);
            this.panel_top.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AllowDrop = true;
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(191, 104);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 17);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // lbl_sub
            // 
            this.lbl_sub.AllowDrop = true;
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_sub.ForeColor = System.Drawing.Color.White;
            this.lbl_sub.Location = new System.Drawing.Point(191, 62);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(59, 17);
            this.lbl_sub.TabIndex = 0;
            this.lbl_sub.Text = "Sub title";
            // 
            // lbl_title
            // 
            this.lbl_title.AllowDrop = true;
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(189, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(121, 29);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Page Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(915, 531);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_nav);
            this.Name = "Home";
            this.ShowIcon = false;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.panel_nav.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_signOut;
        private System.Windows.Forms.Button btn_review;
        private System.Windows.Forms.Button btn_booking;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}