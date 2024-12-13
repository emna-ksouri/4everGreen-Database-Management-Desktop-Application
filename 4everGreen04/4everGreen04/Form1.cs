using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace _4everGreen04
{
    public partial class logIn : Form
    {
        // Get the connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public logIn()
        {
            InitializeComponent();
        }

        
        private void logIn_Load(object sender, EventArgs e)
        {
            // Empty event handler
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Empty event handler
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            // Empty event handler
        }
        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string pass = password.Text;

            // Query to fetch username, password, and role from the database
            string query = "SELECT username, password, fonction FROM admin WHERE username = @Username AND password = @Password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", pass);

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the stored password and role from the database
                                string storedPassword = reader.GetString("password");
                                string role = reader.GetString("fonction");

                                // Check if the provided password matches the stored password
                                if (pass == storedPassword)
                                {
                                    // Passwords match, login successful
                                    MessageBox.Show("Login successful. Role: " + role);

                                    // Close the current login form
                                    this.Hide();

                                    // Open the welcome form
                                    userTab UserTab = new userTab(role);
                                    tasksTab TasksTab = new tasksTab(role);
                                    posts Post = new posts(role);
                                    plants Plants = new plants(role);
                                    interactions Interactions = new interactions(role);
                                    greenSpaceTab GreenSpaceTab = new greenSpaceTab(role);
                                    greenSpaceMembers GreenSpaceMembers = new greenSpaceMembers(role);
                                    adminTab AdminTab = new adminTab(role);


                                    welcomeForm welcome = new welcomeForm(role);
                                    welcome.ShowDialog();
                                }
                                else
                                {
                                    // Passwords don't match, login failed
                                    MessageBox.Show("Invalid username or password.");
                                }
                            }
                            else
                            {
                                // No matching username found in the database
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }


        private void buttonCloseForm_Click(object sender, EventArgs e)
        {   
                // Close the current login form
                this.Close();
            
        }
    }
}
