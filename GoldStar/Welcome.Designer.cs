namespace GoldStar
{
    partial class Welcome
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
            this.data_services = new System.Windows.Forms.DataGridView();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_services)).BeginInit();
            this.panel_controls.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_services
            // 
<<<<<<< HEAD
            this.data_services.AllowUserToAddRows = false;
            this.data_services.AllowUserToDeleteRows = false;
            this.data_services.AllowUserToResizeRows = false;
=======
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.data_services.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_services.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_services.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.data_services.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_services.Location = new System.Drawing.Point(0, 0);
            this.data_services.Name = "data_services";
            this.data_services.ReadOnly = true;
            this.data_services.Size = new System.Drawing.Size(525, 418);
=======
            this.data_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.data_services.Location = new System.Drawing.Point(0, 0);
            this.data_services.Name = "data_services";
            this.data_services.Size = new System.Drawing.Size(525, 333);
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.data_services.TabIndex = 1;
            // 
            // panel_controls
            // 
            this.panel_controls.Controls.Add(this.panel_buttons);
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_controls.Location = new System.Drawing.Point(0, 418);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_controls.Size = new System.Drawing.Size(525, 53);
            this.panel_controls.TabIndex = 2;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.btn_cancel);
            this.panel_buttons.Controls.Add(this.btn_edit);
            this.panel_buttons.Controls.Add(this.btn_book);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_buttons.Location = new System.Drawing.Point(92, 0);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(433, 53);
            this.panel_buttons.TabIndex = 0;
            // 
            // btn_cancel
            // 
<<<<<<< HEAD
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
=======
            this.btn_cancel.BackColor = System.Drawing.Color.Khaki;
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
=======
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.btn_cancel.Location = new System.Drawing.Point(288, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(144, 53);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel Bookng";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
<<<<<<< HEAD
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
=======
            this.btn_edit.BackColor = System.Drawing.Color.Khaki;
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btn_edit.ForeColor = System.Drawing.Color.White;
=======
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.btn_edit.Location = new System.Drawing.Point(144, 0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(144, 53);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Edit Booking";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_book
            // 
<<<<<<< HEAD
            this.btn_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
=======
            this.btn_book.BackColor = System.Drawing.Color.Khaki;
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.btn_book.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_book.FlatAppearance.BorderSize = 0;
            this.btn_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btn_book.ForeColor = System.Drawing.Color.White;
=======
            this.btn_book.ForeColor = System.Drawing.Color.Black;
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.btn_book.Location = new System.Drawing.Point(0, 0);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(144, 53);
            this.btn_book.TabIndex = 11;
            this.btn_book.Text = "Book Room";
            this.btn_book.UseVisualStyleBackColor = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.data_services);
            this.Controls.Add(this.panel_controls);
=======
            this.Controls.Add(this.panel_controls);
            this.Controls.Add(this.data_services);
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(525, 471);
            ((System.ComponentModel.ISupportInitialize)(this.data_services)).EndInit();
            this.panel_controls.ResumeLayout(false);
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView data_services;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_book;
    }
}
