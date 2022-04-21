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
    public partial class frmTeacherAttendance : Form
    {
        public frmTeacherAttendance()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuTeacher menu = new frmMenuTeacher();
            menu.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Previous Button
            if (lbxStudents.SelectedIndex > 0)
            {
                lbxStudents.SelectedIndex = lbxStudents.SelectedIndex - 1;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Next Button
            if (lbxStudents.SelectedIndex < lbxStudents.Items.Count - 1)
            {
                lbxStudents.SelectedIndex = lbxStudents.SelectedIndex + 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // CourseID is just displaying "CourseID" as its
            // value instead of the actual ID number
            String fullName = lbxStudents.SelectedItem.ToString();
            string[] names = fullName.Split(' ');
            string firstName = names[2];
            string lastName = names[1].Replace(",", "");
            string query = "UPDATE group3fa212330.Attendance SET Attendance = @Attendance " +
                "FROM group3fa212330.Attendance AS a JOIN group3fa212330.Students AS s " +
                "ON a.StudentID = s.StudentID WHERE LastName = @LastName AND FirstName = @FirstName; ";
            SqlCommand dbCommand = new SqlCommand(query, ProgOps.dbConnection) ;
            dbCommand.Parameters.AddWithValue("@LastName", lastName);
            dbCommand.Parameters.AddWithValue("@FirstName", firstName);

            //Save Button
            if (rbPresent.Checked)
            {               
                // Code to save present 
                dbCommand.Parameters.AddWithValue("@Attendance", "P");


            }
            else if(rbLate.Checked)
            {
                // Late
                dbCommand.Parameters.AddWithValue("@Attendance", "L");
            }
            else if(rbAbsent.Checked)
            {
                // Absent
                dbCommand.Parameters.AddWithValue("@Attendance", "A");
            }
            //dbCommand.Parameters.AddWithValue("@CourseID", lbxStudents.SelectedItem.ToString());
            if(dbCommand.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("Error occured while saving the selection.  ", "Saving to database...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Selection Saved.", "Saving to database...", MessageBoxButtons.OK);
            }
            
            dbCommand.Dispose();
            //OnCourseChange(cbxCourse.ValueMember.ToString());

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

        private void frmTeacherAttendance_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand dbCommand = new SqlCommand("SELECT c.Name, c.CourseID FROM group3fa212330.Courses AS c " +
                    "JOIN group3fa212330.CoursesEmployees AS ce ON c.CourseID = ce.CourseID WHERE ce.EmployeeID = " +
                frmMenuLogin.currentUser.getEmployeeID(), ProgOps.dbConnection);
                SqlDataAdapter daCourses = new SqlDataAdapter();

                // creating new user data table and filling the information
                DataTable coursesTable = new DataTable();
                daCourses.SelectCommand = dbCommand;
                daCourses.Fill(coursesTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daCourses.Dispose();

                if (coursesTable != null)
                {
                    cbxCourse.DataSource = coursesTable;
                    cbxCourse.DisplayMember = "Name";
                    cbxCourse.ValueMember = "CourseID";
                    cbxCourse.Refresh();
                }
            }
            catch
            {

            }
        }

        private void cbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Displays all students related to the course selected 
            ComboBox cb = (ComboBox)sender;

            // Doing this because SelectedValue changes from datarowview to string after first click
            if (cb.SelectedValue != null)
            {
                string courseID = "0";

                if (cb.SelectedValue.GetType() == typeof(DataRowView))
                    courseID = ((DataRowView)cb.SelectedValue).Row["CourseID"].ToString();
                else if (cb.SelectedValue.GetType() == typeof(string))
                    courseID = cb.SelectedValue.ToString();

                OnCourseChange(courseID);
            }
        }
        public void OnCourseChange(string courseID)
        {
            lbxStudents.Items.Clear();
            // Displays all students related to the course selected 
            // Display Students In Current Teacher's Class
            SqlCommand dbCommand = new SqlCommand("SELECT a.StudentID, s.FirstName, s.LastName, a.Attendance " +
                "FROM group3fa212330.Students AS s " +
                "JOIN group3fa212330.Attendance AS a " +
                "ON s.StudentID = a.StudentID " +
                "WHERE a.CourseID = " + courseID, ProgOps.dbConnection);
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
                lbxStudents.Items.Add(studentsTable.Rows[i]["StudentID"].ToString() + " " + studentsTable.Rows[i]["LastName"].ToString() + ", " + studentsTable.Rows[i]["FirstName"].ToString() + " " + studentsTable.Rows[i]["Attendance"].ToString());
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherHelp help = new frmTeacherHelp();
                help.Show();
        }
    }
}
