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
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Next Button
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save Button
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
