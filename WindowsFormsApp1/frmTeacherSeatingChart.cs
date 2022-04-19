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
            string courseID = cbxCourse.ValueMember.ToString();
            //Shuffle Seating Arrangement 
            string query = "UPDATE a                                                           " +
            "SET SeatNumber = x.SeatNum                                         " +
            "FROM group3fa212330.Attendance as a                                " +
            "JOIN                                                               " +
            "(                                                                  " +
            "	SELECT StudentID, ROW_NUMBER() OVER(ORDER BY NEWID()) SeatNum   " +
            "	FROM group3fa212330.Attendance                                  " +
            "	WHERE CourseID = @courseID                                      " +
            ") x ON a.StudentID = x.StudentID                                   " +
            " WHERE a.CourseID = @courseID                                       ";
            SqlCommand dbCommand = new SqlCommand(query, ProgOps.dbConnection);
            dbCommand.Parameters.AddWithValue("@courseID", courseID);
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

            if (CoursesTable != null)
            {
                cbxCourse.DataSource = CoursesTable;
                cbxCourse.DisplayMember = "Name";
                cbxCourse.ValueMember = "CourseID";
                cbxCourse.Refresh();
            }
        }

        public void OnCourseChange(string courseID)
        {
            lbxStudents.Items.Clear();
            // Displays all students related to the course selected 
            // Display Students In Current Teacher's Class
            SqlCommand dbCommand = new SqlCommand("SELECT a.SeatNumber, s.FirstName, s.LastName " +
                "FROM group3fa212330.Students AS s " +
                "JOIN group3fa212330.Attendance AS a " +
                "ON s.StudentID = a.StudentID " +
                "JOIN group3fa212330.Courses AS c " +
                "ON a.CourseID = c.CourseID " +
                "JOIN group3fa212330.CoursesEmployees AS ce " +
                "ON a.CourseID = ce.CourseID " +
                "WHERE c.CourseID = " + courseID +
                " AND ce.EmployeeID = " +
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
            ComboBox cb = (ComboBox)sender;

            if(cb.SelectedValue != null)
            {
                string courseID = "0";

                if (cb.SelectedValue.GetType() == typeof(DataRowView))
                    courseID = ((DataRowView)cb.SelectedValue).Row["CourseID"].ToString();
                else if (cb.SelectedValue.GetType() == typeof(string))
                    courseID = cb.SelectedValue.ToString();

                OnCourseChange(courseID);
            }
        }
    }
}

