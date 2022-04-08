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
            
            String fullName = lbxStudents.SelectedItem.ToString();
            string[] names = fullName.Split(' ');
            string firstName = names[1];
            string lastName = names[0].Replace(",", ""); 
            string query = "UPDATE group3fa212330.Attendance SET Attendance = @Attendance " +
                "FROM group3fa212330.Attendance AS a JOIN group3fa212330.Students AS s " +
                "ON a.StudentID = s.StudentID WHERE LastName = @LastName AND FirstName = @FirstName; ";
            SqlCommand dbCommand = new SqlCommand(query, ProgOps.dbConnection) ;
            dbCommand.Parameters.AddWithValue("@LastName", lastName);
            dbCommand.Parameters.AddWithValue("@FirstName", firstName);

            //Save Button
            if (rbPresent.Checked)
            {
                // Update query
                dbCommand.Parameters.AddWithValue("@Attendance", "P");

                // Code to save present 
            }
            else if(rbLate.Checked)
            {
                // Late
                // Update query
                dbCommand.Parameters.AddWithValue("@Attendance", "L");
            }
            else if(rbAbsent.Checked)
            {
                // Absent
                // Update query
                dbCommand.Parameters.AddWithValue("@Attendance", "A");
            }
            dbCommand.Parameters.AddWithValue("@SelectedItem", lbxStudents.SelectedItem.ToString());
            if(dbCommand.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("Error occured while saving the selection,  ", "Saving to database...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Selection Saved.", "Saving to database...", MessageBoxButtons.OK);
            }

            dbCommand.Dispose();

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

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuTeacher menu = new frmMenuTeacher();
            menu.Show();
        }

        private void frmTeacherAttendance_Load(object sender, EventArgs e)
        {

            try
            {
                SqlCommand dbCommand = new SqlCommand("SELECT c.Name FROM group3fa212330.Courses AS c " +
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

                for (int i = 0; i < coursesTable.Rows.Count; i++)
                {
                    cbxCourse.Items.Add((coursesTable.Rows[i]["Name"].ToString()));
                }
            }
            catch
            {

            }
        }

        private void cbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // English I
            if (cbxCourse.Text == "English I")
            {
                lbxStudents.Items.Clear();
                // Call Method
                EnglishI();
            }
            // Algebra 
            else if (cbxCourse.Text == "Algebra I")
            {
                lbxStudents.Items.Clear();
                // Call Method
                AlgebraI();
            }
            // General Science
            else if (cbxCourse.Text == "General Science")
            {
                lbxStudents.Items.Clear();
                // Call Method
                GeneralScience();
            }
            // Geometry
            else if (cbxCourse.Text == "Geometry")
            {
                lbxStudents.Items.Clear();
                // Call Method
                Geometry();
            }
            // Social Studies
            else if (cbxCourse.Text == "Social Studies")
            {
                lbxStudents.Items.Clear();
                // Call Method 
                SocialStudies();
            }
            // Physical Education
            else if (cbxCourse.Text == "Physical Education")
            {
                lbxStudents.Items.Clear();
                // Call Method 
                PhysicalEducation();
            }

        }

        public void EnglishI()
        {
                try
                {
                    SqlCommand dbCommand = new SqlCommand("SELECT * FROM group3fa212330.Students AS s JOIN group3fa212330.Attendance AS a ON s.StudentID = a.StudentID JOIN group3fa212330.Courses AS c ON a.CourseID = c.CourseID JOIN group3fa212330.CoursesEmployees AS ce ON a.CourseID = ce.CourseID WHERE ce.EmployeeID = " + frmMenuLogin.currentUser.getEmployeeID(), ProgOps.dbConnection);
                    SqlDataAdapter daStudent = new SqlDataAdapter();

                    // creating new user data table and filling the information
                    DataTable studentsTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(studentsTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();

                    for (int i = 0; i < studentsTable.Rows.Count; i++)
                    {
                        // Displays Student's LastName , FirstName inside of lbxStudents
                        lbxStudents.Items.Add((studentsTable.Rows[i]["LastName"].ToString() + ", " + studentsTable.Rows[i]["FirstName"].ToString()));
                    }
                }
                catch
                {

                }
        }

        public void AlgebraI()
        {
                try
                {
                SqlCommand dbCommand = new SqlCommand("SELECT * FROM group3fa212330.Students AS s JOIN group3fa212330.Attendance AS a ON s.StudentID = a.StudentID JOIN group3fa212330.Courses AS c ON a.CourseID = c.CourseID JOIN group3fa212330.CoursesEmployees AS ce ON a.CourseID = ce.CourseID WHERE ce.EmployeeID = " + frmMenuLogin.currentUser.getEmployeeID(), ProgOps.dbConnection);
                SqlDataAdapter daStudent = new SqlDataAdapter();

                    // creating new user data table and filling the information
                    DataTable studentsTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(studentsTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();

                    for (int i = 0; i < studentsTable.Rows.Count; i++)
                    {
                        // Displays Student's LastName , FirstName inside of lbxStudents
                        lbxStudents.Items.Add((studentsTable.Rows[i]["LastName"].ToString() + ", " + studentsTable.Rows[i]["FirstName"].ToString()));
                    }
                }
                catch
                {

                }
        }

        public void GeneralScience()
        {
                try
                {
                SqlCommand dbCommand = new SqlCommand("SELECT * FROM group3fa212330.Students AS s JOIN group3fa212330.Attendance AS a ON s.StudentID = a.StudentID JOIN group3fa212330.Courses AS c ON a.CourseID = c.CourseID JOIN group3fa212330.CoursesEmployees AS ce ON a.CourseID = ce.CourseID WHERE ce.EmployeeID = " + frmMenuLogin.currentUser.getEmployeeID(), ProgOps.dbConnection);
                SqlDataAdapter daStudent = new SqlDataAdapter();

                    // creating new user data table and filling the information
                    DataTable studentsTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(studentsTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();

                    for (int i = 0; i < studentsTable.Rows.Count; i++)
                    {
                        // Displays Student's LastName , FirstName inside of lbxStudents
                        lbxStudents.Items.Add((studentsTable.Rows[i]["LastName"].ToString() + ", " + studentsTable.Rows[i]["FirstName"].ToString()));
                    }
                }
                catch
                {

                }
        }

        public void Geometry()
        {
                try
                {
                SqlCommand dbCommand = new SqlCommand("SELECT * FROM group3fa212330.Students AS s JOIN group3fa212330.Attendance AS a ON s.StudentID = a.StudentID JOIN group3fa212330.Courses AS c ON a.CourseID = c.CourseID JOIN group3fa212330.CoursesEmployees AS ce ON a.CourseID = ce.CourseID WHERE ce.EmployeeID = " + frmMenuLogin.currentUser.getEmployeeID(), ProgOps.dbConnection);
                SqlDataAdapter daStudent = new SqlDataAdapter();

                    // creating new user data table and filling the information
                    DataTable studentsTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(studentsTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();

                    for (int i = 0; i < studentsTable.Rows.Count; i++)
                    {
                        // Displays Student's LastName , FirstName inside of lbxStudents
                        lbxStudents.Items.Add((studentsTable.Rows[i]["LastName"].ToString() + ", " + studentsTable.Rows[i]["FirstName"].ToString()));
                    }
                }
                catch
                {

                }
        }

        public void SocialStudies()
        {
                try
                {
                SqlCommand dbCommand = new SqlCommand("SELECT * FROM group3fa212330.Students AS s JOIN group3fa212330.Attendance AS a ON s.StudentID = a.StudentID JOIN group3fa212330.Courses AS c ON a.CourseID = c.CourseID JOIN group3fa212330.CoursesEmployees AS ce ON a.CourseID = ce.CourseID WHERE ce.EmployeeID = " + frmMenuLogin.currentUser.getEmployeeID(), ProgOps.dbConnection);
                SqlDataAdapter daStudent = new SqlDataAdapter();

                    // creating new user data table and filling the information
                    DataTable studentsTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(studentsTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();

                    for (int i = 0; i < studentsTable.Rows.Count; i++)
                    {
                        // Displays Student's LastName , FirstName inside of lbxStudents
                        lbxStudents.Items.Add((studentsTable.Rows[i]["LastName"].ToString() + ", " + studentsTable.Rows[i]["FirstName"].ToString()));
                    }
                }
                catch
                {

                }
        }

        public void PhysicalEducation()
        {
            try
            {
                SqlCommand dbCommand = new SqlCommand("SELECT * FROM group3fa212330.Students AS s JOIN group3fa212330.Attendance AS a ON s.StudentID = a.StudentID JOIN group3fa212330.Courses AS c ON a.CourseID = c.CourseID JOIN group3fa212330.CoursesEmployees AS ce ON a.CourseID = ce.CourseID WHERE ce.EmployeeID = " + frmMenuLogin.currentUser.getEmployeeID(), ProgOps.dbConnection);
                SqlDataAdapter daStudent = new SqlDataAdapter();

                // creating new user data table and filling the information
                DataTable studentsTable = new DataTable();
                daStudent.SelectCommand = dbCommand;
                daStudent.Fill(studentsTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daStudent.Dispose();

                for (int i = 0; i < studentsTable.Rows.Count; i++)
                {
                    // Displays Student's LastName , FirstName inside of lbxStudents
                    lbxStudents.Items.Add((studentsTable.Rows[i]["LastName"].ToString() + ", " + studentsTable.Rows[i]["FirstName"].ToString()));
                }
            }
            catch
            {

            }
        }

    }
}
