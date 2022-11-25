using System;
using System.Windows.Forms;

namespace GoldStar
{
    public partial class Login : Form
    {
        Connection con = new Connection();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // collect role, id, username and password
            string username = txt_username.Text;
            string password = txt_password.Text;
            string id = con.ReadString($"SELECT id FROM user WHERE username = '{username}' AND password = '{password}'");
            string role = con.ReadString($"SELECT role FROM user WHERE id = {id}");
            try
            {
                if (role == "Customer")
                {
                    con.ExecuteQuery($"UPDATE user SET status = 'online' WHERE id = {id}");
                    this.Hide();
                    Home home = new Home();
                    home.Show();
                }
                else if (role == "Admin")
                {
                    con.ExecuteQuery($"UPDATE user SET status = 'online' WHERE id = {id}");
                    this.Hide();
                    Admin adminHome = new Admin();
                    adminHome.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Application error!", "Assistant");
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string id = con.ReadString($"SELECT id FROM user WHERE username = '{username}' AND password = '{password}'");

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("This User already exists in our system, please pick another name!", "Assistant");
            }
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password field is Empty!", "Assistant");
            }
            else
            {
                try
                {
                    con.ExecuteQuery($"INSERT INTO user VALUES(NULL, '{username}', 'Customer', '{password}', 'offline')");
                    MessageBox.Show("User successfully created! try to login to confirm", "Assistant");
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to create user!", "Assistant");
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
