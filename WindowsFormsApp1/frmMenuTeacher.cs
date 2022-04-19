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
    public partial class frmMenuTeacher : Form
    {
        public frmMenuTeacher()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back Button
            this.Hide();
        }

        private void btnGradebook_Click(object sender, EventArgs e)
        {
            // Opens Gradebook Form
            frmTeacherGradebook fg = new frmTeacherGradebook();
            fg.Show();
            this.Hide();
        }

        private void btnSeating_Click(object sender, EventArgs e)
        {
            // Opens Seating Arrangement Form
            frmTeacherSeatingChart fs = new frmTeacherSeatingChart();
            fs.Show();
            this.Hide();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            // Opens Attendance Form
            frmTeacherAttendance fa = new frmTeacherAttendance();
            fa.Show();
            this.Hide();
        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to return to login?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // Opens Login Form
                frmMenuLogin fl = new frmMenuLogin();
                fl.Show();
                this.Hide();
            }
        }

    }
}
