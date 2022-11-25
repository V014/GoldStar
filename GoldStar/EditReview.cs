using System;
using System.Windows.Forms;

namespace GoldStar
{
    public partial class EditReview : Form
    {
        public EditReview()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string comment = txt_comment.Text;
            string rating = txt_rating.Text;
            string id = Utils.GetUserID();


        }
    }
}
