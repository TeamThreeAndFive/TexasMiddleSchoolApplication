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
    public partial class frmTeacherGradebook : Form
    {
        public frmTeacherGradebook()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuTeacher menu = new frmMenuTeacher();
            menu.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Submit Grade Changes Button
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherAttendance attendance = new frmTeacherAttendance();
            attendance.Show();
            this.Hide();
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

        private void frmTeacherGradebook_Load(object sender, EventArgs e)
        {
            //code to fill lbxStudents; need to fill _userTable with student table information in progOps
            lbxStudents.Items.Clear();
            int students = ProgOps._userTable.Rows.Count;
            for(int i=0;i<students;i++)
            {
                lbxStudents.Items.Add(ProgOps._userTable.Rows[i].ToString());
            }
        }
    }
}
