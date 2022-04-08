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
    public partial class frmInfoStudents : Form
    {
        public static int editID; //variable to use to carry studentID to edit form
        const String _CONNECTION_STRING =
            "Server=cstnt.tstc.edu;" +
            "Database=inew2330sp22;" +
            "User Id=group3fa212330;" +
            "password=3926456";

        // Database connection
        public static SqlConnection dbConnection = new SqlConnection(_CONNECTION_STRING);
        public static int studentCount;
        // Data tables
        public static DataTable studentsTable;
        String query;

        public frmInfoStudents()
        {
            InitializeComponent();

        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                editID = (int)studentsTable.Rows[lbxStudents.SelectedIndex]["StudentID"];
                MessageBox.Show(editID.ToString());
                var editStudentForm = new frmEditStudents();
                editStudentForm.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a student to edit.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            editID = 0;
            // Add Button
            frmEditStudents edit = new frmEditStudents();
            edit.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete Button
            try
            {
                //run query to delete student
                editID = (int)studentsTable.Rows[lbxStudents.SelectedIndex]["StudentID"];
                if (editID == 0)
                {
                    MessageBox.Show("Please select a student to delete", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "DELETE FROM group3fa212330.Attendance WHERE StudentID=" + editID;
                    SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                    SqlDataAdapter daStudent = new SqlDataAdapter();

                    // creating new user data table and filling the information
                    studentsTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(studentsTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();
                    query = "DELETE FROM group3fa212330.Students WHERE StudentID=" + editID;
                    dbCommand = new SqlCommand(query, dbConnection);
                    daStudent = new SqlDataAdapter();

                    // creating new user data table and filling the information
                    studentsTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(studentsTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();

                    //reload listbox
                    lbxStudents.Items.Clear();
                    // EST command and data adapter
                    query = "SELECT LastName+', '+FirstName AS 'Student' FROM group3fa212330.Students ORDER BY LastName";
                    dbCommand = new SqlCommand(query, dbConnection);
                    daStudent = new SqlDataAdapter();

                    // creating new user data table and filling the information
                    studentsTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(studentsTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();

                    for (int i = 0; i < studentsTable.Rows.Count; i++)
                    {
                        lbxStudents.Items.Add(studentsTable.Rows[i]["Student"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Deleting Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       

        private void frmInfoStudents_Load(object sender, EventArgs e)
        {

            try
            {
                //clear lbx
                lbxStudents.Items.Clear();
                // EST command and data adapter
                query = "SELECT StudentID, LastName+', '+FirstName AS 'Student' FROM group3fa212330.Students ORDER BY StudentID";
                SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                SqlDataAdapter daStudent = new SqlDataAdapter();

                // creating new user data table and filling the information
                studentsTable = new DataTable();
                daStudent.SelectCommand = dbCommand;
                daStudent.Fill(studentsTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daStudent.Dispose();

                for (int i = 0; i < studentsTable.Rows.Count; i++)
                {
                    lbxStudents.Items.Add(studentsTable.Rows[i]["Student"].ToString());
                }
                studentCount = lbxStudents.Items.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(editID !=0)
            {
                MessageBox.Show("Changes have been successfully saved.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
