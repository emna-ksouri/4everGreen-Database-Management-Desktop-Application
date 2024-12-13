using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4everGreen04
{
    public partial class welcomeForm : Form
    {

        // store user role
        private string userRole;

        public welcomeForm()
        {
            InitializeComponent();
        }

        //  role parameter constructor 
        public welcomeForm(string role)
        {
            InitializeComponent();
            userRole = role; //  user role
        }
      

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            // empty
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.Trim().ToLower();

            switch (searchTerm)
            {
                case "admin":
                    if (userRole == "super_admin" )
                    {
                        adminTab adminTabForm = new adminTab(userRole);
                        adminTabForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("You don't have access to the admin table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "users":
                    if (userRole == "super_admin" || userRole == "communities_admin")
                    {
                        userTab UserTab = new userTab(userRole);
                        UserTab.Show();
                    }
                    else
                    {
                        MessageBox.Show("You don't have access to the Users table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "plants":
                    if( userRole == "super_admin" ||userRole == "greenSpace_admin")
                    {
                        plants Communities = new plants(userRole);
                        Communities.Show();
                    }
                    else
                    {
                        MessageBox.Show("You don't have access to the community table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "post":
                    if (userRole == "super_admin" || userRole == "communities_admin")
                    {
                        posts Posts = new posts(userRole);
                        Posts.Show();
                    }
                    else
                    {
                        MessageBox.Show("You don't have access to the post table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "interactions":
                    if (userRole == "super_admin" || userRole == "communities_admin")
                    {
                        interactions Interactions = new interactions(userRole);
                        Interactions.Show();
                    }
                    else
                    {
                        MessageBox.Show("You don't have access to the interactions table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "green space":
                    if (userRole == "super_admin" || userRole == "greenSpace_admin")
                    {
                        greenSpaceTab GreenSpaceTab = new greenSpaceTab(userRole);
                        GreenSpaceTab.Show();
                    }
                    else
                    {
                        MessageBox.Show("You don't have access to the green space table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "green space members":
                    if (userRole == "super_admin" || userRole == "greenSpace_admin")
                    {
                        greenSpaceMembers GreenSpaceMembers = new greenSpaceMembers(userRole);
                        GreenSpaceMembers.Show();
                    }
                    else
                    {
                        MessageBox.Show("You don't have access to the green space member table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "plant tasks":
                    if (userRole == "super_admin" || userRole == "greenSpace_admin")
                    {
                        tasksTab TasksTab = new tasksTab(userRole);
                        TasksTab.Show();
                    }
                    else
                    {
                        MessageBox.Show("You don't have access to the plant task table.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    MessageBox.Show("Table not found. Please enter a valid table name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
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
