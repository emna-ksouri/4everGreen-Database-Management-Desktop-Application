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
    public partial class greenSpaceMembers : Form
    {
        // Get the connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;


        //  user role
        private string role;
        public greenSpaceMembers()
        {
            InitializeComponent();
        }

        //role parameter constructor
        public greenSpaceMembers(string userRole)
        {
            InitializeComponent();
            role = userRole; // user role
        }
       

        private void labelJoinDate_Load(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            //empty
        }


        //access to tabs

        //admin tabb access
        private void AdminsTab_Click_1(object sender, EventArgs e)
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

        //task tabb access
    
        private void PlantsTasksTab_Click(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "communities_admin")
            {
                tasksTab Task = new tasksTab(role);
                Task.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the Tasks table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("You don't have access to the interactions table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // interactions tabb access
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
    


        // Posts tabb access
        private void postsTab_Click_1(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "greenSpace_admin")
            {
                posts Posts = new posts(role);
                Posts.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the plant task table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //plants tab access
        private void plantsTab_Click(object sender, EventArgs e)
        {
            if (role == "super_admin" || role == "greenSpace_admin")
            {
                plants Plants = new plants(role);
                Plants.Show();
            }
            else
            {
                MessageBox.Show("You don't have access to the plant task table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            // Close the current login form
            this.Close();
        }

        // Select operation
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM greenspacemembers";
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
                int memberID = Convert.ToInt32(boxMemberId.Text);
                int userID = Convert.ToInt32(boxUserId.Text);
                int greenSpaceID = Convert.ToInt32(boxGreenSpaceId.Text);
                string role = boxRole.Text;
                string joinDate = boxJoinDate.Text;

                string query = "INSERT INTO greenspacemembers (MemberID, UserID, GreenSpaceID, Role, JoinDate) VALUES (@MemberID, @UserID, @GreenSpaceID, @Role, @JoinDate)";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberID);
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@GreenSpaceID", greenSpaceID);
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@JoinDate", joinDate);

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
                int memberID = Convert.ToInt32(boxMemberId.Text);
                int userID = Convert.ToInt32(boxUserId.Text);
                int greenSpaceID = Convert.ToInt32(boxGreenSpaceId.Text);
                string role = boxRole.Text;
                string joinDate = boxJoinDate.Text;

                string query = "UPDATE greenspacemembers SET UserID = @UserID, GreenSpaceID = @GreenSpaceID, Role = @Role, JoinDate = @JoinDate WHERE MemberID = @MemberID";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberID);
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@GreenSpaceID", greenSpaceID);
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@JoinDate", joinDate);

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
                int memberID = Convert.ToInt32(boxMemberId.Text);

                string query = "DELETE FROM greenspacemembers WHERE MemberID = @MemberID";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberID);

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

      
    }
}
