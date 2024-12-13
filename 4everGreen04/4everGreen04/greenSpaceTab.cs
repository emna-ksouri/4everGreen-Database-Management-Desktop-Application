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
    public partial class greenSpaceTab : Form
    {

        // Get the connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        //  user role
        private string role;
        public greenSpaceTab()
        {
            InitializeComponent();
        }

        //role parameter constructor
        public greenSpaceTab(string userRole)
        {
            InitializeComponent();
            role = userRole; // user role
        }

        //access to tabs

        //admin tabb access
        private void AdminsTab_Click(object sender, EventArgs e)
        {
            if (role == "super_admin")
            {
                adminTab AdminTab = new adminTab();
                AdminTab.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the admin table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //user tabb access
        private void UsersTab_Click(object sender, EventArgs e)
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
                plants Plant = new plants(role);
                Plant.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the community table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //posts tab
        private void PostsTab_Click(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "communities_admin")
            {
                posts Post = new posts(role);
                Post.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the Posts table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // interactionPos tabb access
        private void interactionPostTab_Click(object sender, EventArgs e)
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
        private void GreenSpaceMembersTab_Click(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "greenSpace_admin")
            {
                greenSpaceMembers GreenSpaceMembers = new greenSpaceMembers(role);
                GreenSpaceMembers.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the green space table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // PlantsTasks tabb access
        private void PlantsTasksTab_Click(object sender, EventArgs e)
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

        private void greenSpaceTab_Load(object sender, EventArgs e)
        {

        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }
        // Select operation
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
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int greenSpaceID = Convert.ToInt32(boxGreenSpaceID.Text);
                int userID = Convert.ToInt32(boxUserId.Text);
                string name = boxName.Text;
                string description = boxDescription.Text;

                string query = "INSERT INTO greenspace (greenSpaceID, UserID, name, description) VALUES (@GreenSpaceID, @UserID, @Name, @Description)";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GreenSpaceID", greenSpaceID);
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Description", description);

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
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int greenSpaceID = Convert.ToInt32(boxGreenSpaceID.Text);
                int userID = Convert.ToInt32(boxUserId.Text);
                string name = boxName.Text;
                string description = boxDescription.Text;

                string query = "UPDATE greenspace SET UserID = @UserID, name = @Name, description = @Description WHERE greenSpaceID = @GreenSpaceID";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@GreenSpaceID", greenSpaceID);

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
                int greenSpaceID = Convert.ToInt32(boxGreenSpaceID.Text);

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

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            //empty
        }
    }
}

