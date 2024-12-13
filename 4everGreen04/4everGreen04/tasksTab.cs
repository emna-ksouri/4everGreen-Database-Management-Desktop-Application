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
    public partial class tasksTab : Form
    {
        // Connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        //  user role
        private string role;
        public tasksTab()
        {
            InitializeComponent();
        }

        //role parameter constructor
        public tasksTab(string userRole)
        {
            InitializeComponent();
            role = userRole; // user role
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
            if (role == "super_admin" || role == "communities_admin")
            {
                userTab UserTab = new userTab(role);
                UserTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the admin table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void plantTab_Click(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "communities_admin")
            {
                plants Communities = new plants(role);
                Communities.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the plants table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //greenSpace tabb access
    
        private void greenSpace_Click_1(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "greenSpace_admin")
            {
                greenSpaceTab greenTab = new greenSpaceTab(role);
                greenTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the plant task table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                greenSpaceMembers GreenSpaceTab = new greenSpaceMembers(role);
                GreenSpaceTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the green space Members table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("You don't have access to the posts table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }


        // Select operation
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM plantstasks";
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Insert operation
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int taskID = Convert.ToInt32(boxTaskId.Text);
                int greenSpaceID = Convert.ToInt32(boxGreenSpaceId.Text);
                string taskName = boxTaskName.Text;
                int plantID = Convert.ToInt32(boxPlantId.Text);
                string description = boxDescription.Text;
                string dueDate = boxDueDate.Text;
                int completed = Convert.ToInt32(boxCompleted.Text);

                string query = "INSERT INTO plantstasks (TaskID, GreenSpaceID, TaskName, PlantID, Description, DueDate, Completed) VALUES (@TaskID, @GreenSpaceID, @TaskName, @PlantID, @Description, @DueDate, @Completed)";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TaskID", taskID);
                        command.Parameters.AddWithValue("@GreenSpaceID", greenSpaceID);
                        command.Parameters.AddWithValue("@TaskName", taskName);
                        command.Parameters.AddWithValue("@PlantID", plantID);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@DueDate", dueDate);
                        command.Parameters.AddWithValue("@Completed", completed);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonSelect_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update operation
        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                int taskID = Convert.ToInt32(boxTaskId.Text);
                int greenSpaceID = Convert.ToInt32(boxGreenSpaceId.Text);
                string taskName = boxTaskName.Text;
                int plantID = Convert.ToInt32(boxPlantId.Text);
                string description = boxDescription.Text;
                string dueDate = boxDueDate.Text;
                int completed = Convert.ToInt32(boxCompleted.Text);

                string query = "UPDATE plantstasks SET GreenSpaceID = @GreenSpaceID, TaskName = @TaskName, PlantID = @PlantID, Description = @Description, DueDate = @DueDate, Completed = @Completed WHERE TaskID = @TaskID";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TaskID", taskID);
                        command.Parameters.AddWithValue("@GreenSpaceID", greenSpaceID);
                        command.Parameters.AddWithValue("@TaskName", taskName);
                        command.Parameters.AddWithValue("@PlantID", plantID);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@DueDate", dueDate);
                        command.Parameters.AddWithValue("@Completed", completed);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonSelect_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete operation
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int taskID = Convert.ToInt32(boxTaskId.Text);

                string query = "DELETE FROM plantstasks WHERE TaskID = @TaskID";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TaskID", taskID);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void tasksTab_Load(object sender, EventArgs e)
        {
            //empty
        }


    }
}