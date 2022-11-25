namespace GoldStar
{
    partial class MakeReservation
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
            this.txt_services = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_beds = new System.Windows.Forms.ComboBox();
            this.txt_roomType = new System.Windows.Forms.ComboBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.btn_book = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_services
            // 
            this.txt_services.BackColor = System.Drawing.SystemColors.Control;
            this.txt_services.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_services.FormattingEnabled = true;
            this.txt_services.Items.AddRange(new object[] {
            "Laundry",
            "Breakfast",
            "WiFi"});
            this.txt_services.Location = new System.Drawing.Point(23, 175);
            this.txt_services.Name = "txt_services";
            this.txt_services.Size = new System.Drawing.Size(198, 60);
            this.txt_services.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Services";
            // 
            // txt_beds
            // 
            this.txt_beds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_beds.FormattingEnabled = true;
            this.txt_beds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.txt_beds.Location = new System.Drawing.Point(23, 107);
            this.txt_beds.Name = "txt_beds";
            this.txt_beds.Size = new System.Drawing.Size(231, 32);
            this.txt_beds.TabIndex = 51;
            // 
            // txt_roomType
            // 
            this.txt_roomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_roomType.FormattingEnabled = true;
            this.txt_roomType.Items.AddRange(new object[] {
            "Normal",
            "Executive"});
            this.txt_roomType.Location = new System.Drawing.Point(23, 43);
            this.txt_roomType.Name = "txt_roomType";
            this.txt_roomType.Size = new System.Drawing.Size(231, 32);
            this.txt_roomType.TabIndex = 52;
            // 
            // dateEnd
            // 
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(146, 255);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(108, 20);
            this.dateEnd.TabIndex = 49;
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Location = new System.Drawing.Point(20, 255);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(108, 20);
            this.dateStart.TabIndex = 50;
            // 
            // btn_book
            // 
            this.btn_book.BackColor = System.Drawing.Color.Khaki;
            this.btn_book.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_book.FlatAppearance.BorderSize = 0;
            this.btn_book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.ForeColor = System.Drawing.Color.Black;
            this.btn_book.Location = new System.Drawing.Point(0, 315);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(270, 46);
            this.btn_book.TabIndex = 43;
            this.btn_book.Text = "Book Room";
            this.btn_book.UseVisualStyleBackColor = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Beds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(143, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Start Date";
            // 
            // MakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 361);
            this.Controls.Add(this.txt_services);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_beds);
            this.Controls.Add(this.txt_roomType);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "MakeReservation";
            this.Text = "Make Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox txt_services;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_beds;
        private System.Windows.Forms.ComboBox txt_roomType;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}