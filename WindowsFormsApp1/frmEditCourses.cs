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
    public partial class frmEditCourses : Form
    {
        int _id = frmInfoCourses.selectedCourseID;

        public frmEditCourses()
        {
            InitializeComponent();
        }

        private void tbxGuardianPlaceofWork_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            if (_id != -1)
            {
                if (MessageBox.Show("Are you sure you want to save changes and update?", "Updating Database..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    updateChange();
            }
            else
            {
                // Add new row
                AddNewCourseRow();
            }
           
 
        }

        private void AddNewCourseRow()
        {
            try
            {
                string qery =
                    "INSERT INTO group3fa212330.Courses(CourseID, Name, StartDate, EndDate, MeetingDays, MeetingTime, Room) " +
                    "VALUES (@courseID, @name, @startDate, @endDate, @meetingDays, @meetingTime, @room);";

                SqlCommand cmd = new SqlCommand(qery, ProgOps.dbConnection);

                // check if Course ID is already exists
                for (int x = 0; x < frmInfoCourses.courseList.Count; x++ )
                {
                    if (frmInfoCourses.courseList[x].id == Int32.Parse(tbxCourseID.Text))
                    {
                        MessageBox.Show("Course ID is occupied, please enter different Course ID.", "Room Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxCourseID.Focus();
                        return;
                    }
                }
                
                // see if room number is already exists

                for (int i = 0; i < frmInfoCourses.courseList.Count; i++)
                {
                    if (frmInfoCourses.courseList[i].room == tbxRoom.Text)
                    {
                        MessageBox.Show("Room number is occupied, please enter different room number.", "Room Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxRoom.Focus();
                        return;
                    }
                }

                // If room number is not occupied, insert new row
                cmd.Parameters.AddWithValue("@courseID", tbxCourseID.Text);
                cmd.Parameters.AddWithValue("@name", tbxName.Text);
                cmd.Parameters.AddWithValue("@startDate", startTimePicker.Text);
                cmd.Parameters.AddWithValue("@endDate", endTimePicker.Text);
                cmd.Parameters.AddWithValue("@meetingDays", tbxMeetingDays.Text);
                cmd.Parameters.AddWithValue("@meetingTime", tbxMeetingTime.Text);
                cmd.Parameters.AddWithValue("@room", tbxRoom.Text);

                // check if any row affected


                if (cmd.ExecuteNonQuery() <= 0)
                {
                    MessageBox.Show("Error occur while inserting to the database.", "Inserting Database..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Course successfully added!", "Inserting Database..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



        private void updateChange()
        {
            try
            {
                
                string name = tbxName.Text, startDate = startTimePicker.Text, endDate = endTimePicker.Text, meetingDays = tbxMeetingDays.Text, meetingTime = tbxMeetingTime.Text, room = tbxRoom.Text;


                string qery = "UPDATE group3fa212330.Courses " +
                    "SET Name = @name, StartDate = @startDate, EndDate = @endDate, MeetingDays = @meetingDays, MeetingTime = @meetingTime, Room = @room " +
                    "WHERE CourseID = @courseID";


                SqlCommand cmd = new SqlCommand(qery, ProgOps.dbConnection);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                cmd.Parameters.AddWithValue("@meetingDays", meetingDays);
                cmd.Parameters.AddWithValue("@meetingTime", meetingTime);
                cmd.Parameters.AddWithValue("@room", room);
                cmd.Parameters.AddWithValue("@courseID", frmInfoCourses.courseList[_id].id);

                if (cmd.ExecuteNonQuery() <= 0)
                {
                    MessageBox.Show("Error occur while updating the database.", "Updating Database..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Changes successfully saved!", "Updating Database..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                cmd.Dispose();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Updating Database..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void frmEditCourses_Load(object sender, EventArgs e)
        {
            _id = frmInfoCourses.selectedCourseID;

            // check if user has selected anything
            if (_id != -1)
            {
                // if selected Id is not -1, then user has selected something
                tbxCourseID.ReadOnly = false;

                // Show info about the course
                tbxCourseID.Text = frmInfoCourses.courseList[_id].id.ToString();
                tbxName.Text = frmInfoCourses.courseList[_id].name;
                tbxRoom.Text = frmInfoCourses.courseList[_id].room;
                tbxMeetingDays.Text = frmInfoCourses.courseList[_id].meetingDays;
                tbxMeetingTime.Text = frmInfoCourses.courseList[_id].meetingTime;
                startTimePicker.Value = DateTime.Parse(frmInfoCourses.courseList[_id].startDate);
                endTimePicker.Value = DateTime.Parse(frmInfoCourses.courseList[_id].endDate);
            }
            else
            {
                tbxCourseID.ReadOnly = false;
            }
        }
    }
}
