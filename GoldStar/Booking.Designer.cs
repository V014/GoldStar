namespace GoldStar
{
    partial class Booking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_bookings = new System.Windows.Forms.DataGridView();
            this.panel_transactions = new System.Windows.Forms.Panel();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.panel_buttons = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
=======
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_bookings)).BeginInit();
            this.panel_transactions.SuspendLayout();
            this.panel_controls.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_bookings
            // 
            this.data_bookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_bookings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_bookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_bookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_bookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_bookings.Location = new System.Drawing.Point(0, 0);
            this.data_bookings.Name = "data_bookings";
            this.data_bookings.Size = new System.Drawing.Size(525, 483);
            this.data_bookings.TabIndex = 0;
            this.data_bookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_bookings_CellClick);
            // 
            // panel_transactions
            // 
            this.panel_transactions.Controls.Add(this.data_bookings);
            this.panel_transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_transactions.Location = new System.Drawing.Point(0, 0);
            this.panel_transactions.Name = "panel_transactions";
            this.panel_transactions.Size = new System.Drawing.Size(525, 483);
            this.panel_transactions.TabIndex = 2;
            // 
            // panel_controls
            // 
            this.panel_controls.Controls.Add(this.panel_buttons);
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_controls.Location = new System.Drawing.Point(0, 483);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(525, 48);
            this.panel_controls.TabIndex = 3;
            // 
            // panel_buttons
            // 
<<<<<<< HEAD
            this.panel_buttons.Controls.Add(this.btn_checkout);
            this.panel_buttons.Controls.Add(this.btn_accept);
=======
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.panel_buttons.Controls.Add(this.btn_cancel);
            this.panel_buttons.Controls.Add(this.btn_edit);
            this.panel_buttons.Controls.Add(this.btn_book);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Right;
<<<<<<< HEAD
            this.panel_buttons.Location = new System.Drawing.Point(3, 0);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(522, 48);
            this.panel_buttons.TabIndex = 0;
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.Khaki;
            this.btn_checkout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_checkout.FlatAppearance.BorderSize = 0;
            this.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.ForeColor = System.Drawing.Color.Black;
            this.btn_checkout.Location = new System.Drawing.Point(410, 0);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(110, 48);
            this.btn_checkout.TabIndex = 6;
            this.btn_checkout.Text = "Check out";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.Khaki;
            this.btn_accept.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_accept.FlatAppearance.BorderSize = 0;
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.ForeColor = System.Drawing.Color.Black;
            this.btn_accept.Location = new System.Drawing.Point(300, 0);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(110, 48);
            this.btn_accept.TabIndex = 5;
            this.btn_accept.Text = "Accept Bookng";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
=======
            this.panel_buttons.Location = new System.Drawing.Point(90, 0);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(435, 48);
            this.panel_buttons.TabIndex = 0;
            // 
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Khaki;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.btn_cancel.Location = new System.Drawing.Point(190, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 48);
=======
            this.btn_cancel.Location = new System.Drawing.Point(288, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(144, 48);
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel Bookng";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Khaki;
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.btn_edit.Location = new System.Drawing.Point(95, 0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(95, 48);
=======
            this.btn_edit.Location = new System.Drawing.Point(144, 0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(144, 48);
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit Booking";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_book
            // 
            this.btn_book.BackColor = System.Drawing.Color.Khaki;
            this.btn_book.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_book.FlatAppearance.BorderSize = 0;
            this.btn_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.ForeColor = System.Drawing.Color.Black;
            this.btn_book.Location = new System.Drawing.Point(0, 0);
            this.btn_book.Name = "btn_book";
<<<<<<< HEAD
            this.btn_book.Size = new System.Drawing.Size(95, 48);
=======
            this.btn_book.Size = new System.Drawing.Size(144, 48);
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.btn_book.TabIndex = 2;
            this.btn_book.Text = "Book Room";
            this.btn_book.UseVisualStyleBackColor = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_transactions);
            this.Controls.Add(this.panel_controls);
            this.Name = "Booking";
            this.Size = new System.Drawing.Size(525, 531);
            ((System.ComponentModel.ISupportInitialize)(this.data_bookings)).EndInit();
            this.panel_transactions.ResumeLayout(false);
            this.panel_controls.ResumeLayout(false);
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data_bookings;
        private System.Windows.Forms.Panel panel_transactions;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_edit;
<<<<<<< HEAD
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_accept;
=======
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
    }
}
