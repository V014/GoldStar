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
            //TODO: How to either convert sender object to previous control to extract the booking the user has selected or
            // through the event
            var id = Utils.GetUserID();
            var comment = txt_comment.Text;
            var rating = txt_rating.Text;
        }
    }
}
