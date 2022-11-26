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
<<<<<<< HEAD
            var con = new Connection();
            var comment = txt_comment.Text;
            var rating = txt_rating.Text;
            var createReviewQuery = $"INSERT INTO review (booking_id, comment, rating) VALUES ('{Utils.BookingID}', '{comment}', '{rating}')";
            con.ExecuteQuery(createReviewQuery);
            MessageBox.Show("Review successfully created");
            this.Close();
=======
            //TODO: How to either convert sender object to previous control to extract the booking the user has selected or
            // through the event
            var id = Utils.GetUserID();
            var comment = txt_comment.Text;
            var rating = txt_rating.Text;
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
        }
    }
}
