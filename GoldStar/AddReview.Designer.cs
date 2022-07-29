namespace GoldStar
{
    partial class AddReview
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
            this.btn_comment = new System.Windows.Forms.Button();
            this.txt_rating = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_comment = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_comment
            // 
            this.btn_comment.BackColor = System.Drawing.Color.Khaki;
            this.btn_comment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_comment.FlatAppearance.BorderSize = 0;
            this.btn_comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comment.ForeColor = System.Drawing.Color.Black;
            this.btn_comment.Location = new System.Drawing.Point(0, 238);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(249, 57);
            this.btn_comment.TabIndex = 30;
            this.btn_comment.Text = "Comment";
            this.btn_comment.UseVisualStyleBackColor = false;
            this.btn_comment.Click += new System.EventHandler(this.btn_comment_Click);
            // 
            // txt_rating
            // 
            this.txt_rating.BackColor = System.Drawing.Color.White;
            this.txt_rating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rating.FormattingEnabled = true;
            this.txt_rating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.txt_rating.Location = new System.Drawing.Point(24, 183);
            this.txt_rating.Name = "txt_rating";
            this.txt_rating.Size = new System.Drawing.Size(198, 28);
            this.txt_rating.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Rating";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Comment";
            // 
            // txt_comment
            // 
            this.txt_comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_comment.Location = new System.Drawing.Point(21, 48);
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(201, 96);
            this.txt_comment.TabIndex = 33;
            this.txt_comment.Text = "";
            // 
            // AddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 295);
            this.Controls.Add(this.txt_comment);
            this.Controls.Add(this.btn_comment);
            this.Controls.Add(this.txt_rating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "AddReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_comment;
        private System.Windows.Forms.ComboBox txt_rating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_comment;
    }
}