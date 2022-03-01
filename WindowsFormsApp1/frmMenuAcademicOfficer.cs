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
    public partial class frmMenuAcademicOfficer : Form
    {
        public frmMenuAcademicOfficer()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmInfoStudents fs = new frmInfoStudents();
            fs.Show();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            frmInfoTeachers ft = new frmInfoTeachers();
            ft.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            frmInfoCourses fc = new frmInfoCourses();
            fc.Show();
        }

        private void btnAcademicOfficers_Click(object sender, EventArgs e)
        {
            frmInfoAcademicOfficers fo = new frmInfoAcademicOfficers();
            fo.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
