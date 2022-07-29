using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldStar
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
            txt_fname.Text = Utils.GetField("contact", "firstname", $"user_id = '{Utils.GetUserID()}'");
            txt_lname.Text = Utils.GetField("contact", "lastname", $"user_id = '{Utils.GetUserID()}'");
            txt_phoneNumber.Text = Utils.GetField("contact", "phone_number", $"user_id = '{Utils.GetUserID()}'");
            txt_address.Text = Utils.GetField("contact", "address", $"user_id = '{Utils.GetUserID()}'");
        }

        private void btn_update_profile_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new Connection();
                String firstname = txt_fname.Text;
                String lastname = txt_lname.Text;
                String phoneNumber = txt_phoneNumber.Text;
                String address = txt_address.Text;

                // If the user already has contact details perform update otherwise insert it
                String contactID = Utils.GetField("contact", "id", $"user_id = '{Utils.GetUserID()}'");

                if (string.IsNullOrEmpty(contactID))
                {
                    String createProfileQuery = $"INSERT INTO contact (user_id, firstname, lastname, address, phone_number) VALUES ('{Utils.GetUserID()}', '{firstname}', '{lastname}', '{address}', '{phoneNumber}')";
                    conn.ExecuteQuery(createProfileQuery);
                } else
                {
                    String updateProfileQuery = $"UPDATE contact SET firstname = '{firstname}', lastname = '{lastname}', address = '{address}', phone_number = '{phoneNumber}' WHERE id = '{contactID}'";
                    conn.ExecuteQuery(updateProfileQuery);
                }
                
                MessageBox.Show("Profile updated successfully");   
            } catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
