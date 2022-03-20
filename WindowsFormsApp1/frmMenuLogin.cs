using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public partial class frmMenuLogin : Form
    {

        // Initialize new employee -- as current user
        Employee currentUser;

        public frmMenuLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (cbxKeepLoggedIn.Checked)
            {
                /// This check if user want to keep logged in
                /// If user want to keep logged in then

                // Set UserName and Password in properties setting
                Properties.Settings.Default.UserName = tbxUsername.Text;
                Properties.Settings.Default.Password = tbxPassword.Text;
                Properties.Settings.Default.Save();

            }

            if (!cbxKeepLoggedIn.Checked)
            {
                /// This check if user want to keep logged in
                /// If user do not want to keep logged in then

                // Set UserName and Password to empty string in properties setting
                // This will remove any existing value from userName and password
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

            // check if user has provided some email and password
            if (tbxUsername.Text == string.Empty || tbxPassword.Text == string.Empty)
            {
                // if its empty
                MessageBox.Show("Username or Password can not be empty, Username and Password is required to login.", "Empty filed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Lets authenticate the user
                if (Authentication.Authenticate(tbxUsername.Text, tbxPassword.Text) == true)
                {
                    // if user exists, assign global current user to the ProgOps currentEmployee
                    currentUser = ProgOps.currentEmployee;

                    // finally show the menu, based on the role type
                    if (currentUser.getRole() == "Academic Officer")
                    {
                        frmMenuAcademicOfficer academicOfficerMenu = new frmMenuAcademicOfficer();
                        academicOfficerMenu.Show();
                    }
                    else if (currentUser.getRole() == "Teacher")
                    {
                        frmMenuTeacher teacherMenu = new frmMenuTeacher();
                        teacherMenu.Show();
                    }
                    else
                    {
                        frmMenuAdministrator adminMenu = new frmMenuAdministrator();
                        adminMenu.Show();
                    }

                }

            }
        }


        private void frmMenuLogin_Load(object sender, EventArgs e)
        {

            // open Database connections.
            ProgOps.OpenDatabseConnection();

            ///
            /// First check if user already have checked keep logged in
            /// 
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                // This body only runs if Properties has any value
                // for userName and password

                // Show userName and password
                tbxUsername.Text = Properties.Settings.Default.UserName;
                tbxPassword.Text = Properties.Settings.Default.Password;
            }
            
        }


        private void frmMenuLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // when form closes we close database and dispose data.
            ProgOps.CloseDatabaseConnection();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close Application
            Application.Exit();
        }

        private void llblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword forgotPasswordForm = new frmForgotPassword();
            forgotPasswordForm.Show();
        }
    }
}
