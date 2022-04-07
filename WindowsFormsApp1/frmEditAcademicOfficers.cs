using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// connection imports
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmEditAcademicOfficers : Form
    {

        int selectedIndex = frmInfoAcademicOfficers.selectedIndex + 1;

        public frmEditAcademicOfficers()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            if (selectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure you want to save changes and update?", "Updating Database..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    updateChange();
            }
            else
            {
                AddNewEmployeeRow();
            }

           
        }

        
        private void AddNewEmployeeRow()
        {

            try
            {
                string qery =
                    "INSERT INTO group3fa212330.Employees " +
                    "VALUES (@firstName, @lastName, @email, @phone, @role, @Password, @EmployeeID)";

                SqlCommand cmd = new SqlCommand(qery, ProgOps.dbConnection);



                // get the all employee and check it has the same id as the tbx

                SqlCommand temp = new SqlCommand("SELECT EmployeeID From group3fa212330.Employees", ProgOps.dbConnection);
                SqlDataAdapter tempAdapter = new SqlDataAdapter();
                DataTable EmployeeIDsTable = new DataTable();

                tempAdapter.SelectCommand = temp;
                tempAdapter.Fill(EmployeeIDsTable);

                temp.Dispose();
                tempAdapter.Dispose();

                for (int x = 0; x < EmployeeIDsTable.Rows.Count; x++)
                {
                    if (EmployeeIDsTable.Rows[x]["EmployeeID"].ToString() == tbxEmployeeID.Text)
                    {
                        MessageBox.Show("Employee ID is occupied, please enter different Employee ID.", "Room Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxEmployeeID.Focus();
                        return;
                    }
                }
                    

                // see if room number is already exists

                for (int i = 0; i < frmInfoCourses.courseList.Count; i++)
                {
                    if (frmInfoAcademicOfficers.academicOfficersList[i].email == tbxEmail.Text)
                    {
                        MessageBox.Show("Email is occupied, please enter different Email.", "Room Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxEmail.Focus();
                        return;
                    }
                }

                // If room number is not occupied, insert new row
                cmd.Parameters.AddWithValue("@firstName", tbxFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", tbxLastName.Text);
                cmd.Parameters.AddWithValue("@email", tbxEmail.Text);
                cmd.Parameters.AddWithValue("@phone", tbxPhone.Text);
                cmd.Parameters.AddWithValue("@role", "Academic Officer");
                cmd.Parameters.AddWithValue("@Password", tbxPassword.Text);
                cmd.Parameters.AddWithValue("@employeeID", tbxEmployeeID.Text);

                // check if any row affected


                if (cmd.ExecuteNonQuery() <= 0)
                {
                    MessageBox.Show("Error occur while inserting to the database.", "Inserting Database..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Course successfully added!", "Inserting Database..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

               
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void updateChange()
        {
            try
            {

                string firstName = tbxFirstName.Text,
                    lastName = tbxLastName.Text,
                    email = tbxEmail.Text,
                    phone = tbxPhone.Text,
                    role = tbxRole.Text,
                    employeeID = tbxEmployeeID.Text;


                string qery = "UPDATE group3fa212330.Employees " +
                    "SET FirstName = @firstName, LastName = @lastName, Email = @email, Phone = @phone, Role = @role " +
                    "WHERE EmployeeID = @employeeID";


                SqlCommand cmd = new SqlCommand(qery, ProgOps.dbConnection);

                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@employeeID", employeeID);
        
                if (cmd.ExecuteNonQuery() <= 0)
                {
                    MessageBox.Show("Error occur while updating the database.", "Updating Database..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Changes successfully saved!", "Updating Database..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Updating Database..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void frmEditAcademicOfficers_Load(object sender, EventArgs e)
        {
            selectedIndex = frmInfoAcademicOfficers.selectedIndex;

            // check if user has selected anything
            if (frmInfoAcademicOfficers.selectedIndex != -1)
            {
                tbxEmployeeID.ReadOnly = true;
                tbxPassword.ReadOnly = true;

                // Show prefiled data
                tbxEmployeeID.Text = frmInfoAcademicOfficers.academicOfficersList[selectedIndex].employeeID;
                tbxEmail.Text = frmInfoAcademicOfficers.academicOfficersList[selectedIndex].email;
                tbxFirstName.Text = frmInfoAcademicOfficers.academicOfficersList[selectedIndex].getFirstName();
                tbxLastName.Text = frmInfoAcademicOfficers.academicOfficersList[selectedIndex].last_name;
                tbxPhone.Text = frmInfoAcademicOfficers.academicOfficersList[selectedIndex].phone;
                tbxPassword.Text = "**********";
                tbxRole.Text = frmInfoAcademicOfficers.academicOfficersList[selectedIndex].role;

            }
            else
            {
                tbxEmployeeID.ReadOnly = false;
                tbxPassword.ReadOnly = false;

            }
        }
    }
}
