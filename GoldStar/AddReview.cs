using System;
using System.Windows.Forms;

namespace GoldStar
{
    public partial class AddReview : Form
    {
        public AddReview()
        {
            InitializeComponent();
        }

        private void btn_comment_Click(object sender, EventArgs e)
        {
            var con = new Connection();
            var comment = txt_comment.Text;
            var rating = txt_rating.Text;
            var createReviewQuery = $"INSERT INTO review (booking_id, comment, rating) VALUES ('{Utils.BookingID}', '{comment}', '{rating}')";
            con.ExecuteQuery(createReviewQuery);
            MessageBox.Show("Review successfully created");
            this.Close();
        }
    }
}
