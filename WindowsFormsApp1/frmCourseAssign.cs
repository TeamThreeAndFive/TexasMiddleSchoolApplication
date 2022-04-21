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
    public partial class frmCourseAssign : Form
    {

        // List of courses
        List<Course> courseList = new List<Course>();
        List<Course> assignedCourseList = new List<Course>();
        List<Employee> teacherList = new List<Employee>();

        public frmCourseAssign()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCourseAssign_Load(object sender, EventArgs e)
        {
            // On from load
            // Display List of teachers
            DisplayAllTeachers();
        }


        private void lbxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On Course Selected Item change
            // Display available courses.
            
            DisplayAssignedCourses(Int32.Parse(teacherList[lbxTeachers.SelectedIndex].employeeID));

            // check if course teacher have any course
            

            DisplayAvailableCourses();
        

        }

        /// <summary>
        /// Display already assigned courses to the teacher
        /// </summary>
        /// <param name="selectedTeacherID"></param>
        private void DisplayAssignedCourses(int selectedTeacherID)
        {

            try
            {

                // clear list of course
                assignedCourseList.Clear();
                lbxAssignedCourses.Items.Clear();

                String query = "SELECT DISTINCT C.CourseID , C.Name  FROM group3fa212330.Courses AS C " +
                    "JOIN group3fa212330.CoursesEmployees AS CE " +
                    "ON CE.CourseID = C.CourseID " +
                    $"WHERE CE.EmployeeID = {selectedTeacherID} " +
                    $"ORDER BY Name;";

                // Database set up
                var command = new SqlCommand(query, ProgOps.dbConnection);
                var adapter = new SqlDataAdapter();
                var courseTable = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(courseTable);

                adapter.Dispose();

                // Add courses to courseList
                for (int i = 0; i < courseTable.Rows.Count; i++)
                {
                    assignedCourseList.Add(new Course
                    {
                        id = Int32.Parse(courseTable.Rows[i]["CourseID"].ToString()),
                        name = courseTable.Rows[i]["Name"].ToString()
                    });

                    // Display it to the list box
                    lbxAssignedCourses.Items.Add(assignedCourseList[i].name);
                }

                // Dispose data 
                courseTable.Dispose();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to display available the courses in the List box and add Courses to the courseList
        /// </summary>
        private void DisplayAvailableCourses()
        {

            try
            {

                // clear list of course
                courseList.Clear();
                lbxCourses.Items.Clear();

                string query = "";

                // if no course is assigned to the teacher yet
                if (assignedCourseList.Count <= 0)
                {
                    // Display all courses
                    query = "SELECT CourseID, Name FROM group3fa212330.Courses ORDER BY Name";
                }
                else
                {

                    // get only course which available to assign
                    query = "SELECT CourseID, Name FROM group3fa212330.Courses " +
                    "WHERE CourseID != " + assignedCourseList[0].id;

                    for (int x=1; x<assignedCourseList.Count; x++)
                    {
                        query += " AND CourseID != " + assignedCourseList[x].id;
                    }
                    query += " ORDER BY Name";
                }

                

                // Database set up
                var command = new SqlCommand(query, ProgOps.dbConnection);
                var adapter = new SqlDataAdapter();
                var courseTable = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(courseTable);

                adapter.Dispose();

                // Add courses to courseList
                for (int i=0; i<courseTable.Rows.Count;i++)
                {
                    courseList.Add(new Course { 
                        id = Int32.Parse(courseTable.Rows[i]["CourseID"].ToString()),
                        name = courseTable.Rows[i]["Name"].ToString()
                    });

                    // Display it to the list box
                    lbxCourses.Items.Add(courseList[i].name);
                }

                // Dispose data 
                courseTable.Dispose();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Function to display teacher
        /// </summary>
        private void DisplayAllTeachers()
        {

            try
            {

                lbxTeachers.Items.Clear();
                teacherList.Clear();

                string query = "SELECT * FROM group3fa212330.Employees " +
                    "WHERE Role = 'Teacher' " +
                    "ORDER BY LastName, FirstName";

                // Database set up
                var command = new SqlCommand(query, ProgOps.dbConnection);
                var adapter = new SqlDataAdapter();
                var teachersTable = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(teachersTable);

                adapter.Dispose();

                // Add courses to courseList
                for (int i = 0; i < teachersTable.Rows.Count; i++)
                {
                    teacherList.Add(new Employee
                    {
                        employeeID = teachersTable.Rows[i]["EmployeeID"].ToString(),
                        frist_name = teachersTable.Rows[i]["FirstName"].ToString(),
                        last_name = teachersTable.Rows[i]["LastName"].ToString(),

                    });

                    // Display it to the list box
                    lbxTeachers.Items.Add(teacherList[i].last_name + ", " + teacherList[i].frist_name);
                }

                // Dispose data 
                teachersTable.Dispose();
                command.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }


        private void pbxAddButton_Click(object sender, EventArgs e)
        {
            if (lbxCourses.SelectedIndex < 0)
            {
                MessageBox.Show("Please select course you want to add, then press add.", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to assign {lbxCourses.SelectedItem.ToString()} course to {lbxTeachers.SelectedItem.ToString()}?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                {
                    // Save changes
                    AddTeacherToCourse(courseList[lbxCourses.SelectedIndex].id, Int32.Parse(teacherList[lbxTeachers.SelectedIndex].employeeID));

                    // update assigned courses
                   
                    DisplayAssignedCourses(Int32.Parse(teacherList[lbxTeachers.SelectedIndex].employeeID));
                    DisplayAvailableCourses();

                }
                
            }
           
        }

        private void AddTeacherToCourse(int selectedCourseID, int selectedTeacherID)
        {
            try
            {

                String query = "INSERT INTO group3fa212330.CoursesEmployees " +
                    "VALUES (@EmployeeID, @CourseID)";

                // Database set up
                var command = new SqlCommand(query, ProgOps.dbConnection);

                command.Parameters.AddWithValue("@EmployeeID", selectedTeacherID);
                command.Parameters.AddWithValue("@CourseID", selectedCourseID);


                if(command.ExecuteNonQuery() <= 0)
                {
                    MessageBox.Show("Unable to assign course to the selected teacher. please try again.", "Unsaved Changes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureRemoveButton_Click(object sender, EventArgs e)
        {
            if (lbxAssignedCourses.SelectedIndex < 0 || lbxTeachers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select course and teacher from the list box you want to remove, then press remove button.", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to remove {lbxTeachers.SelectedItem.ToString()} from the {lbxAssignedCourses.SelectedItem.ToString()} course?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Save changes
                    RemoveTeacherFromCourse(assignedCourseList[lbxAssignedCourses.SelectedIndex].id, Int32.Parse(teacherList[lbxTeachers.SelectedIndex].employeeID));

                    // update assigned courses

                    DisplayAssignedCourses(Int32.Parse(teacherList[lbxTeachers.SelectedIndex].employeeID));
                    DisplayAvailableCourses();

                }

            }
        }

        private void RemoveTeacherFromCourse(int selectedCourseID, int selectedTeacherID)
        {
            try
            {

                String query = "DELETE FROM group3fa212330.CoursesEmployees " +
                    "WHERE CourseID = @CourseID AND EmployeeID = @EmployeeID;";

                // Database set up
                var command = new SqlCommand(query, ProgOps.dbConnection);

                command.Parameters.AddWithValue("@EmployeeID", selectedTeacherID);
                command.Parameters.AddWithValue("@CourseID", selectedCourseID);


                if (command.ExecuteNonQuery() <= 0)
                {
                    MessageBox.Show("Unable to remove teacher from the course. please try again.", "Unsaved Changes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxAddButton_MouseEnter(object sender, EventArgs e)
        {
            pbxAddButton.BackColor = Color.LawnGreen;
        }

        private void pbxAddButton_MouseLeave(object sender, EventArgs e)
        {
            pbxAddButton.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void pictureRemoveButton_MouseEnter(object sender, EventArgs e)
        {
            pictureRemoveButton.BackColor = Color.Red;
        }

        private void pictureRemoveButton_MouseLeave(object sender, EventArgs e)
        {
            pictureRemoveButton.BackColor = Color.Tomato;

        }
    }
}
