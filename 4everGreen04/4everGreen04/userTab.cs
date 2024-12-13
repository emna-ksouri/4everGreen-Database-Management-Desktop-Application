using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _4everGreen04
{
    public partial class userTab : Form
    {
        // Get the connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        // Store user role
        private string role;

        public userTab()
        {
            InitializeComponent();
        }

        //role parameter constructor
        public userTab(string userRole)
        {
            InitializeComponent();
            role = userRole; // user role
            
        }

        private void userTab_Load(object sender, EventArgs e)
        {
            // Empty event handler
        }

        //TableS access

        // Admin tab access
   
        private void AdminsTab_Click_1(object sender, EventArgs e)
        {
            if (role == "super_admin")
            {
               
                adminTab AdminTab = new adminTab(role);
                AdminTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the admin table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Plant tab access
        private void plantTab_Click(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "communitiesadmin")
            {
                plants Communities = new plants(role);
                Communities.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the plants table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PostsTab_Click(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "communitiesadmin")
            {
                posts Post = new posts(role);
                Post.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the Posts table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // GreenSpace tab access
    
        private void GreenSpaceTab_Click_1(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "communitiesadmin")
            {

                greenSpaceTab GreenSpaceTab = new greenSpaceTab(role);
                GreenSpaceTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the green space table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // InteractionPost tab access
        private void interactionPostTab_Click_1(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "communitiesadmin")
            {
                interactions Interactions = new interactions(role);
                Interactions.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the interactions table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // GreenSpaceMembers tab access
        private void GreenSpaceMembersTab_Click(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "greenSpace_admin")
            {
                greenSpaceMembers GreenSpaceTab = new greenSpaceMembers(role);
                GreenSpaceTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the green space Members table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // PlantsTasks tab access
        private void PlantsTasksTab_Click_1(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "greenSpace_admin")
            {
                tasksTab TasksTab = new tasksTab(role);
                TasksTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the plant task table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Closebutton
        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }


        //select
        private void buttonSelect_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users";
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    connection.Close();
                }
            }

            dataGridView1.DataSource = dataTable;
        }

        // Insert operation
        private void buttonInsert_Click_1(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(idBox.Text);
            string userName = userNameBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text;

            string query = "INSERT INTO users (UserID, UserName, Email, Password) VALUES (@UserID, @UserName, @Email, @Password)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MessageBox.Show($"User ID: {userID}, UserName: {userName}, Email: {email}, Password: {password}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            buttonSelect_Click_1(sender, e);
        }

        // Update Operation
        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(idBox.Text);
            string userName = userNameBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text;

            string query = "UPDATE users SET UserName = @UserName, Email = @Email, Password = @Password WHERE UserID = @UserID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            buttonSelect_Click_1(sender, e);
        }
        //delet operation
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(idBox.Text);

            string query = "DELETE FROM users WHERE UserID = @UserID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            buttonSelect_Click_1(sender, e);
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            // Create and show the login form
            logIn Form1 = new logIn();
            Form1.Show();

            // Close all other forms
            foreach (Form form in Application.OpenForms.Cast<Form>().ToArray())
            {
                if (form != Form1)
                {
                    form.Close();
                }

            }
        }

 

   
    }
}
