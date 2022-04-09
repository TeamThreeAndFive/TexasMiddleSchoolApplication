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
    public partial class frmTeacherSeatingChart : Form
    {
        public frmTeacherSeatingChart()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuTeacher menu = new frmMenuTeacher();
            menu.Show();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {


            string courseName = cbxCourse.Text.ToString();
            //Shuffle Seating Arrangement 
            string query = "UPDATE group3fa212330.Attendance SET SeatNumber = ABS(CHECKSUM(NewId())) % 20 FROM group3fa212330.Attendance as a JOIN group3fa212330.Courses AS c ON c.CourseID = a.CourseID WHERE c.Name = @courseName";
            SqlCommand dbCommand = new SqlCommand(query, ProgOps.dbConnection);
            dbCommand.Parameters.AddWithValue("@CourseName", courseName);
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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save Seating Arrangement
        }



        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherAttendance attendance = new frmTeacherAttendance();
            attendance.Show();
            this.Hide();
        }

        private void gradebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherGradebook gb = new frmTeacherGradebook();
            gb.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuTeacher menu = new frmMenuTeacher();
            menu.Show();
        }

        private void frmTeacherSeatingChart_Load(object sender, EventArgs e)
        {
            // Display Courses

            string employeeID = frmMenuLogin.currentUser.getEmployeeID();
            SqlCommand dbCmd = new SqlCommand("SELECT * FROM group3fa212330.Courses AS c " +
                "JOIN group3fa212330.CoursesEmployees AS ce " +
                "ON c.CourseID = ce.CourseID WHERE ce.EmployeeID = " + employeeID, ProgOps.dbConnection);
            SqlDataAdapter daCourses = new SqlDataAdapter();

            // creating new user data table and filling the information
            DataTable CoursesTable = new DataTable();
            daCourses.SelectCommand = dbCmd;
            daCourses.Fill(CoursesTable);

            // Dispose unnecessary data
            dbCmd.Dispose();
            daCourses.Dispose();

            for (int i = 0; i < CoursesTable.Rows.Count; i++)
            {
                cbxCourse.Text = ((CoursesTable.Rows[i]["Name"].ToString()));
            }
            OnCourseChange();

        }
        public void OnCourseChange()
        {
            // Displays all students related to the course selected 
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
                lbxStudents.Items.Add(studentsTable.Rows[i]["SeatNumber"].ToString() + " " + studentsTable.Rows[i]["LastName"].ToString() + ", " + studentsTable.Rows[i]["FirstName"].ToString());
            }
        }

        private void cbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Displays all students related to the course selected 
            OnCourseChange();
        }

    }
}

