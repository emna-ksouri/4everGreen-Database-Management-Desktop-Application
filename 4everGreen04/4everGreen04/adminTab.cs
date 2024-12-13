using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Linq;

namespace _4everGreen04
{
    public partial class adminTab : Form
    {
        // Get the connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        private string role;
        public adminTab()
        {
            InitializeComponent();
        }
        public adminTab(string userRole)
        {
            InitializeComponent();
            role = userRole; // user role
        }
        private void adminTab_Load(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
           
            string query = "SELECT * FROM admin";

            // Create a DataTable to hold the results
            DataTable dataTable = new DataTable();

            // connection string
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Create a MySqlCommand
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Fill the DataTable with the results
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        // Fill the DataTable 
                        adapter.Fill(dataTable);
                    }

                    // Close the connection
                    connection.Close();
                }
            }

            // Display the results in a DataGridView 
            dataGridView1.DataSource = dataTable;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            // Get the values 
            string username = userNameBox.Text;
            string password = passwordBox.Text;
            string fonction = fonctionBox.Text;

            //Check if the username already exists
            string checkQuery = "SELECT COUNT(*) FROM admin WHERE username = @Username";

            // Define the INSERT 
            string insertQuery = "INSERT INTO admin (username, password, fonction) VALUES (@Username, @Password, @Fonction)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            // Username already exists
                            MessageBox.Show("Username already exists. Please choose a different username.");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return;
                    }
                }

                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Username", username);
                    insertCommand.Parameters.AddWithValue("@Password", password);
                    insertCommand.Parameters.AddWithValue("@Fonction", fonction);

                    try
                    {
                        // Execute the INSERT query
                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Admin added successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            // Call buttonSelect_Click to refresh the DataGridView
            buttonSelect_Click(sender, e); 
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Get the values 
            string username = userNameBox.Text;
            string password = passwordBox.Text;
            string fonction = fonctionBox.Text;

            // UPDATE 
            string query = "UPDATE admin SET password = @Password, fonction = @Fonction WHERE username = @Username";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Fonction", fonction);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the UPDATE 
                        command.ExecuteNonQuery();

                        MessageBox.Show("Admin updated successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            // Refresh the DataGridView
            buttonSelect_Click(sender, e); 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Get username 
            string username = userNameBox.Text;

            // DELETE 
            string query = "DELETE FROM admin WHERE username = @Username";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Admin deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            //Refresh the DataGridView
            buttonSelect_Click(sender, e);
        }
         
    // users access
        private void UsersTab_Click(object sender, EventArgs e)
        {
            userTab UserTab = new userTab(role);
            UserTab.Show();
        }

        private void plantTab_Click(object sender, EventArgs e)
        {
            plants Communities = new plants(role);
            Communities.Show();
        }

        private void PostsTab_Click(object sender, EventArgs e)
        {
            posts Posts = new posts(role);
            Posts.Show();
        }

        private void interactionPostTab_Click(object sender, EventArgs e)
        {
            interactions Interactions = new interactions(role);
            Interactions.Show();
        }

        private void GreenSpaceTab_Click(object sender, EventArgs e)
        {
            greenSpaceTab GreenSpaceTab = new greenSpaceTab(role);
            GreenSpaceTab.Show();
        }

        private void GreenSpaceMembersTab_Click(object sender, EventArgs e)
        {
            greenSpaceMembers GreenSpaceMembers = new greenSpaceMembers(role);
            GreenSpaceMembers.Show();
        }

        private void PlantsTasksTab_Click(object sender, EventArgs e)
        {
            tasksTab TasksTab = new tasksTab(role);
            TasksTab.Show();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
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
         private void label3_Click(object sender, EventArgs e)
         {
             //empty
         }
    }
}

