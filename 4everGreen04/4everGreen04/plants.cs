using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4everGreen04
{
    public partial class plants : Form
    {
        // Get the connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        // variable to store user role
        private string role;
        public plants()
        {
            InitializeComponent();
        }

        //role parameter constructor
        public plants(string userRole)
        {
            InitializeComponent();
            role = userRole; // user role
        }


        private void communities_Load(object sender, EventArgs e)
        {

        }
        //access to tabs

        //admin tabb access
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

        //user tabb access
        private void UsersTab_Click_1(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "communitiesadmin")
            {
                userTab UserTab = new userTab(role);
                UserTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the admin table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

    

        //greenSpace tabb access
     
        private void greenSpaceTab_Click_1(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "greenSpace_admin")
            {
                greenSpaceTab GreenSpaceTab = new greenSpaceTab(role);
                GreenSpaceTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the green space table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // interactionPos tabb access
        private void interactionPostTab_Click_1(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "communities_admin")
            {
                interactions Interactions = new interactions(role);
                Interactions.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the interactions table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // GreenSpaceMembers tabb access
        private void GreenSpaceMembersTab_Click_1(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "greenSpace_admin")
            {
                greenSpaceMembers GreenSpaceTabMem = new greenSpaceMembers(role);
                GreenSpaceTabMem.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the green space Members.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // PlantsTasks tabb access
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
        //posts tab access
        private void PostsTab_Click(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "greenSpace_admin")
            {
                posts postTab = new posts(role);
                postTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the plant task table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                // Define the SQL query
                string query = "SELECT * FROM plants";

                // Create a DataTable to hold the results
                DataTable dataTable = new DataTable();

                // Create a MySqlConnection 
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Open the connection
                        connection.Open();

                        
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            // Fill the DataTable with the results 
                            adapter.Fill(dataTable);
                        }

                        // Close the connection
                        connection.Close();
                    }
                }

                // Display the results in a DataGridView 
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelCompleted_Click(object sender, EventArgs e)
        {
            // empty
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from textboxes
                string greenSpaceID = idBox.Text;
                string name = nameBox.Text;
                string type = typeBox.Text;

                //  INSERT query
                string query = "INSERT INTO plants (greenSpaceID, name, type) VALUES (@GreenSpaceID, @Name, @Type)";

                // Create a MySqlConnection 
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Create a MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@GreenSpaceID", greenSpaceID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Type", type);

                        // Open connection
                        connection.Open();

                        // Execute INSERT query
                        command.ExecuteNonQuery();

                        // Close connection
                        connection.Close();
                    }
                }

                MessageBox.Show("Plant added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //DataGridView Refresh 
                buttonSelect_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from textboxes
                int plantID = Convert.ToInt32(idBox.Text);
                string name = nameBox.Text;
                string type = typeBox.Text;

                // Define the UPDATE query
                string query = "UPDATE plants SET name = @Name, type = @Type WHERE plantID = @PlantID";

                // Create a MySqlConnection 
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Update
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Type", type);
                        command.Parameters.AddWithValue("@PlantID", plantID);

                        // Open the connection
                        connection.Open();

                        // Execute the UPDATE query
                        command.ExecuteNonQuery();

                        // Close the connection
                        connection.Close();
                    }
                }

                MessageBox.Show("Plant updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                buttonSelect_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the value of plantID to delete
                int plantID = Convert.ToInt32(idBox.Text);

                // Define the DELETE query
                string query = "DELETE FROM plants WHERE plantID = @PlantID";

                // Create a MySqlConnection using the connection string
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Create a MySqlCommand with the DELETE query and the connection
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@PlantID", plantID);

                        // Open connection
                        connection.Open();

                        // Execute the DELETE
                        command.ExecuteNonQuery();

                        // Close connection
                        connection.Close();
                    }
                }

                MessageBox.Show("Plant deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                buttonSelect_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
