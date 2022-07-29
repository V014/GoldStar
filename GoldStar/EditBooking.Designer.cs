namespace GoldStar
{
    partial class EditBooking
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_beds = new System.Windows.Forms.ComboBox();
            this.txt_to = new System.Windows.Forms.DateTimePicker();
            this.txt_from = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_roomType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_services
            // 
            this.txt_services.BackColor = System.Drawing.SystemColors.Control;
            this.txt_services.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_services.FormattingEnabled = true;
            this.txt_services.Items.AddRange(new object[] {
            "Laundry",
            "Breakfast",
            "WiFi",
            "Buffet",
            "Conference Room"});
            this.txt_services.Location = new System.Drawing.Point(24, 165);
            this.txt_services.Name = "txt_services";
            this.txt_services.Size = new System.Drawing.Size(198, 75);
            this.txt_services.TabIndex = 2;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Khaki;
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(0, 315);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(243, 57);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit Reservation";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_beds
            // 
            this.txt_beds.BackColor = System.Drawing.Color.White;
            this.txt_beds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_beds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_beds.FormattingEnabled = true;
            this.txt_beds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.txt_beds.Location = new System.Drawing.Point(24, 102);
            this.txt_beds.Name = "txt_beds";
            this.txt_beds.Size = new System.Drawing.Size(198, 28);
            this.txt_beds.TabIndex = 1;
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(133, 279);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(89, 20);
            this.txt_to.TabIndex = 4;
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(24, 279);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(89, 20);
            this.txt_from.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 18);
            this.label9.TabIndex = 49;
            this.label9.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Services";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Beds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Room Type";
            // 
            // txt_roomType
            // 
            this.txt_roomType.BackColor = System.Drawing.Color.White;
            this.txt_roomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_roomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_roomType.FormattingEnabled = true;
            this.txt_roomType.Items.AddRange(new object[] {
            "Normal",
            "Executive"});
            this.txt_roomType.Location = new System.Drawing.Point(24, 37);
            this.txt_roomType.Name = "txt_roomType";
            this.txt_roomType.Size = new System.Drawing.Size(198, 28);
            this.txt_roomType.TabIndex = 0;
            // 
            // EditBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 372);
            this.Controls.Add(this.txt_roomType);
            this.Controls.Add(this.txt_services);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_beds);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "EditBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox txt_services;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox txt_beds;
        private System.Windows.Forms.DateTimePicker txt_to;
        private System.Windows.Forms.DateTimePicker txt_from;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_roomType;
    }
}