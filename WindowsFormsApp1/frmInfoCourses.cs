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
    public partial class frmInfoCourses : Form
    {

        // Last form means
        // What form was before this form.
        // This will help to display appropriate value's on to the screen
        private string _lastForm;

        public frmInfoCourses(string lastForm)
        {
            InitializeComponent();
            this._lastForm = lastForm;
        }


        // List to see the course information
        public static List<Course> courseList = new List<Course>();

        // this will help to show pre-filed Edit courses form
        // -1 is default, that means user has not selected anything.
        public static int selectedCourseID = -1;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Edit Button
            var frm = new frmEditCourses();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add Button
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete Button
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Undo Button
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear Button
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save Button
        }

        private void frmInfoCourses_Load(object sender, EventArgs e)
        {
   
           ShowCourses();

        }

        public void ShowCourses()
        {
            // This function will show or update all courses in the list box

            // get the information from the database
            try
            {

                SqlCommand cmd;

                // check which form was the last form
                if (_lastForm == "ADMIN")
                {
                    // if, it was ADMIN, show all data to admin
                    cmd = new SqlCommand("SELECT * FROM group3fa212330.Courses ORDER BY CourseID", ProgOps.dbConnection);
                }
                else
                {
                    // show only data the use has access to

                    // NEEDED WORK ON HERE -----------------------------------------------------------------------

                    cmd = new SqlCommand("SELECT * FROM group3fa212330.Courses ORDER BY CourseID", ProgOps.dbConnection);
                }

               
                SqlDataAdapter coursesAdapter = new SqlDataAdapter();
                DataTable coursesTable = new DataTable();

                coursesAdapter.SelectCommand = cmd;
                coursesAdapter.Fill(coursesTable);

                // Dispose unnecessary data
                coursesAdapter.Dispose();
                cmd.Dispose();

                // Before starting loop, Make sure the course list and list box is empty
                // If not than it will add duplicate values
                courseList.Clear();
                lbxCourses.Items.Clear();

                // show to the list box and also add to the course List
                for (int i = 0; i < coursesTable.Rows.Count; i++)
                {

                    // add item to the course List
                    courseList.Add(new Course { 
                    
                        id = Int32.Parse(coursesTable.Rows[i]["CourseID"].ToString()),
                        name = coursesTable.Rows[i]["Name"].ToString(),
                        startDate = coursesTable.Rows[i]["StartDate"].ToString(),
                        endDate = coursesTable.Rows[i]["EndDate"].ToString(),
                        meetingDays = coursesTable.Rows[i]["MeetingDays"].ToString(),
                        meetingTime = coursesTable.Rows[i]["MeetingTime"].ToString(),
                        room = coursesTable.Rows[i]["Room"].ToString(),

                    });

                    // Now show information to the List box
                    lbxCourses.Items.Add(courseList[i].id.ToString() + ". " +
                        courseList[i].name);

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occur while receiving course information. \n\nSee Error below:\n" 
                    + ex.Message.ToString(), "Data receiving error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void lbxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If user select any index we will enable exit button
            btnEdit.Enabled = true;

            // check id user actually selected anything
            
            if (lbxCourses.SelectedIndex >= 0)
            {
                // get selected course id and set the course id
                selectedCourseID = Int32.Parse(lbxCourses.SelectedItem.ToString()[0].ToString()) - 1;
            }
            else
            {
                btnEdit.Enabled = false;
            }



        }
    }
}
