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



        public frmInfoCourses()
        {
            InitializeComponent();
        }


        // List to see the course information
        public static List<Course> courseList = new List<Course>();

   
        public static int selectedIndex = -1;

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
            ShowCourses();
            selectedIndex = -1;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectedIndex = -1;
                
            var frm = new frmEditCourses();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            ShowCourses();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if user is sure want to delete
            if (MessageBox.Show("Are you sure you want to delete this?", "Updating Database..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                DeleteRow();

            ShowCourses();
            selectedIndex = -1;
            btnDelete.Enabled = false; 
            btnEdit.Enabled = false;

        }

        private void DeleteRow()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM group3fa212330.Courses " +
                    "WHERE CourseID = @courseID", ProgOps.dbConnection);

                cmd.Parameters.AddWithValue("courseID", courseList[lbxCourses.SelectedIndex].id);


                if (cmd.ExecuteNonQuery() <= 0)
                {
                    MessageBox.Show("Error occur while inserting to the database.", "Inserting Database..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Course successfully deleted!", "Deleting Database..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cmd.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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


              
                // if, it was ADMIN, show all data to admin
                cmd = new SqlCommand("SELECT * FROM group3fa212330.Courses ORDER BY CAST(CourseID AS INT)", ProgOps.dbConnection);
 
               
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
            btnDelete.Enabled = true;

            // check id user actually selected anything
            if (lbxCourses.SelectedIndex >= 0)
            {
                // get selected course id and set the course id
                selectedIndex = lbxCourses.SelectedIndex;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }



        }
    }
}
