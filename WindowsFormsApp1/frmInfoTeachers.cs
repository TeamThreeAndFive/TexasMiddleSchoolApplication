using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class frmInfoTeachers : Form
    {
        public static int editID; //variable to use to carry studentID to edit form
        const String _CONNECTION_STRING =
            "Server=cstnt.tstc.edu;" +
            "Database=inew2330sp22;" +
            "User Id=group3fa212330;" +
            "password=3926456";

        // Database connection
        public static SqlConnection dbConnection = new SqlConnection(_CONNECTION_STRING);
        // Data tables
        public static DataTable teachersTable;
        String query;
        public frmInfoTeachers()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back Button
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                editID = (int)teachersTable.Rows[lbxTeachers.SelectedIndex]["EmployeeID"];
                var editTeacherForm = new frmEditTeachers();
                editTeacherForm.ShowDialog();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a teacher to edit.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add Button
            editID = 0;
            frmEditTeachers edit = new frmEditTeachers();
            edit.ShowDialog();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete Button
            try
            {

                //run query to delete student
                editID = (int)teachersTable.Rows[lbxTeachers.SelectedIndex]["EmployeeID"];
                if (editID == 0)
                {
                    MessageBox.Show("Please select a teachers to delete", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "DELETE FROM group3fa212330.Employees WHERE EmployeeID=" + editID;
                    SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                    SqlDataAdapter daStudent = new SqlDataAdapter();

                    // creating new user data table and filling the information
                    teachersTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(teachersTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();

                    //reload listbox
                    lbxTeachers.Items.Clear();
                    // EST command and data adapter
                    query = "SELECT LastName+', '+FirstName AS 'Teacher' FROM group3fa212330.Employees WHERE Role='Teacher'";
                    dbCommand = new SqlCommand(query, dbConnection);
                    daStudent = new SqlDataAdapter();

                    teachersTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(teachersTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();

                    for (int i = 0; i < teachersTable.Rows.Count-1; i++)
                    {
                        lbxTeachers.Items.Add(teachersTable.Rows[i]["Teacher"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select teacher you want to remove.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save Button
            if(editID==0)
            {

            }
            else
            {
                MessageBox.Show("Changes have been successfully saved.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmInfoTeachers_Load(object sender, EventArgs e)
        {
            try
            {
                //clear lbx
                lbxTeachers.Items.Clear();
                // EST command and data adapter
                query = "SELECT EmployeeID, LastName+', '+FirstName AS 'Teacher' FROM group3fa212330.Employees WHERE Role='Teacher'";
                SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                SqlDataAdapter daTeacher = new SqlDataAdapter();

                // creating new user data table and filling the information
                teachersTable = new DataTable();
                daTeacher.SelectCommand = dbCommand;
                daTeacher.Fill(teachersTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daTeacher.Dispose();

                for (int i = 0; i < teachersTable.Rows.Count-1; i++)
                {
                    lbxTeachers.Items.Add(teachersTable.Rows[i]["Teacher"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
