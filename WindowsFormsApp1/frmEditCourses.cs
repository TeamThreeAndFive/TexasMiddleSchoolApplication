using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmEditCourses : Form
    {
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
            // Save Changes Button
        }

        private void frmEditCourses_Load(object sender, EventArgs e)
        {
            // check if user has selected anything
            if (frmInfoCourses.selectedCourseID != -1)
            {
                // if selected Id is not -1, then user has selected something

                int _id = frmInfoCourses.selectedCourseID;

                // Show info about the course
                tbxCourseID.Text = frmInfoCourses.courseList[_id].id.ToString();
                tbxName.Text = frmInfoCourses.courseList[_id].name;
                tbxRoom.Text = frmInfoCourses.courseList[_id].room;
                tbxMeetingDays.Text = frmInfoCourses.courseList[_id].meetingDays;
                tbxMeetingTime.Text = frmInfoCourses.courseList[_id].meetingTime;
                startTimePicker.Value = DateTime.Parse(frmInfoCourses.courseList[_id].startDate);
                endTimePicker.Value = DateTime.Parse(frmInfoCourses.courseList[_id].endDate);
            }
        }
    }
}
