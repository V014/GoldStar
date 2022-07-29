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
            string username = txt_username.Text;
            string password = txt_password.Text;

            con.ExecuteQuery("UPDATE user SET status = 'offline'");
            string queryCredentials = $"SELECT id FROM user WHERE username = '{username}' AND password = '{password}'";
            string id = con.ReadString(queryCredentials); 

            try
            {
                string queryRole = $"SELECT role FROM user WHERE id = {id}";
                string role = con.ReadString(queryRole);
                if (role == "Customer")
                {
                    string queryStatus = $"UPDATE user SET status = 'online' WHERE id = {id}";
                    con.ExecuteQuery(queryStatus);

                    this.Hide();
                    Home home = new Home();
                    home.Show();
                }
                else if (role == "Admin")
                {
                    string queryStatus = $"UPDATE user SET status = 'online' WHERE id = {id}";
                    con.ExecuteQuery(queryStatus);

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

            }
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            string queryCredencials = $"SELECT id FROM user WHERE username = '{username}' AND password = '{password}'";
            string id = con.ReadString(queryCredencials);

            if (id != "")
            {
                MessageBox.Show("This User already exists in our system, please pick another name.");
            }
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username/Password is Empty");
            }
            else
            {
                try
                {
                    string queryUser = $"INSERT INTO user VALUES(NULL, '{username}', 'Customer', '{password}', 'offline')";
                    con.ExecuteQuery(queryUser);
                    MessageBox.Show("User successfully created! try to login to confirm");
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to create user");
                }

                
            }
        }
    }
}
