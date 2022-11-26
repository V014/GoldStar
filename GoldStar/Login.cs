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
<<<<<<< HEAD
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
=======
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

>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
                    this.Hide();
                    Home home = new Home();
                    home.Show();
                }
                else if (role == "Admin")
                {
<<<<<<< HEAD
                    con.ExecuteQuery($"UPDATE user SET status = 'online' WHERE id = {id}");
=======
                    string queryStatus = $"UPDATE user SET status = 'online' WHERE id = {id}";
                    con.ExecuteQuery(queryStatus);

>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
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
<<<<<<< HEAD
                MessageBox.Show("Application error!", "Assistant");
            }
=======

            }
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
<<<<<<< HEAD
            string id = con.ReadString($"SELECT id FROM user WHERE username = '{username}' AND password = '{password}'");

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("This User already exists in our system, please pick another name!", "Assistant");
            }
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password field is Empty!", "Assistant");
=======

            string queryCredencials = $"SELECT id FROM user WHERE username = '{username}' AND password = '{password}'";
            string id = con.ReadString(queryCredencials);

            if (id != "")
            {
                MessageBox.Show("This User already exists in our system, please pick another name.");
            }
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username/Password is Empty");
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
            }
            else
            {
                try
                {
<<<<<<< HEAD
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
=======
                    string queryUser = $"INSERT INTO user VALUES(NULL, '{username}', 'Customer', '{password}', 'offline')";
                    con.ExecuteQuery(queryUser);
                    MessageBox.Show("User successfully created! try to login to confirm");
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to create user");
                }

                
            }
>>>>>>> 6056bbfb3fae6ec85f1cb3070822cffa4eedf062
        }
    }
}
