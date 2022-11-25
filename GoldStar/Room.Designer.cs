namespace GoldStar
{
    partial class Room
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
            this.data_room = new System.Windows.Forms.DataGridView();
            this.panel_transactions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.data_room)).BeginInit();
            this.panel_transactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_room
            // 
            this.data_room.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_room.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_room.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_room.Location = new System.Drawing.Point(0, 0);
            this.data_room.Margin = new System.Windows.Forms.Padding(4);
            this.data_room.Name = "data_room";
            this.data_room.Size = new System.Drawing.Size(700, 654);
            this.data_room.TabIndex = 0;
            // 
            // panel_transactions
            // 
            this.panel_transactions.Controls.Add(this.data_room);
            this.panel_transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_transactions.Location = new System.Drawing.Point(0, 0);
            this.panel_transactions.Margin = new System.Windows.Forms.Padding(4);
            this.panel_transactions.Name = "panel_transactions";
            this.panel_transactions.Size = new System.Drawing.Size(700, 654);
            this.panel_transactions.TabIndex = 6;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_transactions);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(700, 654);
            ((System.ComponentModel.ISupportInitialize)(this.data_room)).EndInit();
            this.panel_transactions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data_room;
        private System.Windows.Forms.Panel panel_transactions;
    }
}
