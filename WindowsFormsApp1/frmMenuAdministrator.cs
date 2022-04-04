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
    public partial class frmMenuAdministrator : Form
    {
        public frmMenuAdministrator()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            // Opens Students Form
            frmEditStudents fes = new frmEditStudents();
            fes.Show();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            // Opens Teachers Form
            frmEditTeachers fet = new frmEditTeachers();
            fet.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            // Opens Courses Form
            frmEditCourses fec = new frmEditCourses();
            fec.Show();
        }

        private void btnAcademicOfficers_Click(object sender, EventArgs e)
        {
            // Opens Academic Officer Form
            frmEditAcademicOfficers feao = new frmEditAcademicOfficers();
            feao.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back Button
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log-out and exit the application?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // If user want to exit the application
                Application.Exit();
            }
        }
    }
}
