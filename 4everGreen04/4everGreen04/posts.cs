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
using System.Xml.Linq;

namespace _4everGreen04
{
    public partial class posts : Form
    {
        // Connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        // user role
        private string role;
        public posts()
        {
            InitializeComponent();
        }

        //role parameter constructor
        public posts(string userRole)
        {
            InitializeComponent();
            role = userRole; // user role
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
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
        
        //Plants tabb access
        private void PlantsTab_Click(object sender, EventArgs e)
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
        private void greenSpaceTab_Click(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "communities_admin")
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
                greenSpaceMembers GreenSpaceTab = new greenSpaceMembers(role);
                GreenSpaceTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the green space Members table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
       
        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        private void posts_Load(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM greenspace";
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
        private void buttonInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                int greenSpaceID = Convert.ToInt32(boxPostId.Text);
                int userID = Convert.ToInt32(boxUserId.Text);
                string postText = boxPostText.Text;

                string query = "INSERT INTO greenspace (greenSpaceID, UserID, postText) VALUES (@GreenSpaceID, @UserID, @postText)";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GreenSpaceID", greenSpaceID);
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@postText", postText);

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
                int greenSpaceID = Convert.ToInt32(boxPostId.Text);
                int userID = Convert.ToInt32(boxUserId.Text);
                string postText = boxPostText.Text;

                string query = "UPDATE greenspace SET UserID = @UserID, postText = @postText WHERE greenSpaceID = @GreenSpaceID";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GreenSpaceID", greenSpaceID);
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@postText", postText);

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
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int greenSpaceID = Convert.ToInt32(boxPostId.Text);

                string query = "DELETE FROM greenspace WHERE greenSpaceID = @GreenSpaceID";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GreenSpaceID", greenSpaceID);

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

       
    }
}
