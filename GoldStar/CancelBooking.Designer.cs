namespace GoldStar
{
    partial class CancelBooking
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
            this.btn_add = new System.Windows.Forms.Button();
<<<<<<< HEAD
=======
            this.txt_customerID = new System.Windows.Forms.TextBox();
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Khaki;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(0, 90);
            this.btn_add.Name = "btn_add";
<<<<<<< HEAD
            this.btn_add.Size = new System.Drawing.Size(279, 57);
=======
            this.btn_add.Size = new System.Drawing.Size(262, 57);
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.btn_add.TabIndex = 37;
            this.btn_add.Text = "Cancel Booking";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
<<<<<<< HEAD
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Are you sure you want to cancel booking?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
=======
            // txt_customerID
            // 
            this.txt_customerID.BackColor = System.Drawing.Color.White;
            this.txt_customerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerID.Location = new System.Drawing.Point(26, 38);
            this.txt_customerID.Multiline = true;
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.Size = new System.Drawing.Size(216, 29);
            this.txt_customerID.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Customer ID";
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            // 
            // CancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(279, 147);
            this.Controls.Add(this.btn_add);
=======
            this.ClientSize = new System.Drawing.Size(262, 147);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_customerID);
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
<<<<<<< HEAD
=======
        private System.Windows.Forms.TextBox txt_customerID;
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
        private System.Windows.Forms.Label label1;
    }
}