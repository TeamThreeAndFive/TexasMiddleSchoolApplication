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
using System.Data;

namespace WindowsFormsApp1
{
    public partial class frmTeacherGradebook : Form
    {
        public frmTeacherGradebook()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuTeacher menu = new frmMenuTeacher();
            menu.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Submit Grade Changes Button
            // Update Selected Assignment's Grade
            string[] assignment = lbxAssignments.SelectedItem.ToString().Split(' ');
            string assignmentID = assignment[0];
            string assignmentName = assignment[1];
            String fullName = lbxStudents.SelectedItem.ToString();
            string[] names = fullName.Split(' ');
            string firstName = names[1];
            string lastName = names[0].Replace(",", "");
            string grade = tbxChangeGrade.Text.ToString();
            string employeeID = frmMenuLogin.currentUser.getEmployeeID();
            string query = "UPDATE group3fa212330.Grades  " +
                "SET Grade = @Grade FROM group3fa212330.Grades as g " +
                "JOIN group3fa212330.Students as s " +
                "ON g.StudentID = s.StudentID " +
                "WHERE g.AssignmentID = @AssignmentID " +
                "AND s.FirstName = @FirstName AND s.LastName = @LastName";
            SqlCommand dbCommand = new SqlCommand(query, ProgOps.dbConnection);
            dbCommand.Parameters.AddWithValue("@AssignmentID", assignmentID);
            dbCommand.Parameters.AddWithValue("@LastName", lastName);
            dbCommand.Parameters.AddWithValue("@FirstName", firstName);

            // Update query
            dbCommand.Parameters.AddWithValue("@Grade", tbxChangeGrade.Text.ToString()); 

            // Code to save present 
            if (dbCommand.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("Error occured while saving the selection.", "Saving to database...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Selection Saved.", "Saving to database...", MessageBoxButtons.OK);
            }

            dbCommand.Dispose();
            tbxChangeGrade.Clear();
            tbxGrade.Clear();

        }



        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherAttendance attendance = new frmTeacherAttendance();
            attendance.Show();
            this.Hide();
        }

        private void seatingChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherSeatingChart sc = new frmTeacherSeatingChart();
            sc.Show();
            this.Hide();
        }

        private void gradebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherGradebook gradebook = new frmTeacherGradebook();
            gradebook.Show();
            this.Hide();
        }

        private void frmTeacherGradebook_Load(object sender, EventArgs e)
        {
            try
            {

                // Display Students In Current Teacher's Class
                SqlCommand dbCommand = new SqlCommand("SELECT * FROM group3fa212330.Students AS s " +
                    "JOIN group3fa212330.Attendance AS a ON s.StudentID = a.StudentID " +
                    "JOIN group3fa212330.Courses AS c ON a.CourseID = c.CourseID " +
                    "JOIN group3fa212330.CoursesEmployees AS ce ON a.CourseID = ce.CourseID WHERE ce.EmployeeID = " +
                frmMenuLogin.currentUser.getEmployeeID(), ProgOps.dbConnection);
                SqlDataAdapter daStudents = new SqlDataAdapter();

                // creating new user data table and filling the information
                DataTable studentsTable = new DataTable();
                daStudents.SelectCommand = dbCommand;
                daStudents.Fill(studentsTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daStudents.Dispose();

                for (int i = 0; i < studentsTable.Rows.Count; i++)
                {
                    lbxStudents.Items.Add(studentsTable.Rows[i]["LastName"].ToString() + ", " + studentsTable.Rows[i]["FirstName"].ToString());
                }

            }
            catch
            {

            }
        }


        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuTeacher menu = new frmMenuTeacher();
            menu.Show();
        }

        private void lbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxAssignments.Items.Clear();
            // Display Selected Student's Assignments

            String fullName = lbxStudents.SelectedItem.ToString();
            string[] names = fullName.Split(' ');
            string firstName = names[1];
            string lastName = names[0].Replace(",", "");
            SqlCommand dbCmd = new SqlCommand("SELECT a.Name, a.AssignmentID FROM group3fa212330.Assignments as a " +
                "JOIN group3fa212330.Grades as g ON g.AssignmentID = a.AssignmentID " +
                "JOIN group3fa212330.Students as s ON g.StudentID = s.StudentID " +
                "WHERE s.FirstName = @FirstName AND s.LastName = @LastName", ProgOps.dbConnection);
            dbCmd.Parameters.AddWithValue("@LastName", lastName);
            dbCmd.Parameters.AddWithValue("@FirstName", firstName);
            dbCmd.Parameters.AddWithValue("@SelectedItem", lbxStudents.SelectedItem.ToString());
            SqlDataAdapter daAssignments = new SqlDataAdapter();

            // creating new user data table and filling the information
            DataTable AssignmentsTable = new DataTable();
            daAssignments.SelectCommand = dbCmd;
            daAssignments.Fill(AssignmentsTable);

            // Dispose unnecessary data
            dbCmd.Dispose();
            daAssignments.Dispose();

            for (int i = 0; i < AssignmentsTable.Rows.Count; i++)
            {
                lbxAssignments.Items.Add((AssignmentsTable.Rows[i]["AssignmentID"].ToString() + " " + AssignmentsTable.Rows[i]["Name"].ToString()));
            }
        }

        private void lbxAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display Student's Grades
            tbxGrade.Clear();
            // Display Selected Student's Assignments
            string[] assignment = lbxAssignments.SelectedItem.ToString().Split(' ');
            string assignmentID = assignment[0];
            String fullName = lbxStudents.SelectedItem.ToString();
            string[] names = fullName.Split(' ');
            string firstName = names[1];
            string lastName = names[0].Replace(",", "");
            String Assignment = lbxAssignments.SelectedItem.ToString();
            SqlCommand dbCmd = new SqlCommand("SELECT Grade FROM group3fa212330.Grades as g " +
                "JOIN group3fa212330.Students AS s ON g.StudentID = s.StudentID " +
                "WHERE AssignmentID = @AssignmentID AND s.FirstName = @FirstName  " +
                "AND s.LastName = @LastName", ProgOps.dbConnection);
            dbCmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
            dbCmd.Parameters.AddWithValue("@LastName", lastName);
            dbCmd.Parameters.AddWithValue("@FirstName", firstName);
            SqlDataAdapter daGrades = new SqlDataAdapter();

            // creating new user data table and filling the information
            DataTable GradesTable = new DataTable();
            daGrades.SelectCommand = dbCmd;
            daGrades.Fill(GradesTable);

            // Dispose unnecessary data
            dbCmd.Dispose();
            daGrades.Dispose();

            for (int i = 0; i < GradesTable.Rows.Count; i++)
            {
                tbxGrade.Text = ((GradesTable.Rows[i]["Grade"].ToString()));
            }
        }

        private void lbxGrades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
