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

        }

        private void btnGradebook_Click(object sender, EventArgs e)
        {
            // Opens Gradebook Form
            frmTeacherGradebook fg = new frmTeacherGradebook();
            this.Hide();
            fg.ShowDialog();
            this.Show();
            
        }

        private void btnSeating_Click(object sender, EventArgs e)
        {
            // Opens Seating Arrangement Form
            frmTeacherSeatingChart fs = new frmTeacherSeatingChart();
            
            this.Hide();
            fs.ShowDialog();
            this.Show();

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            // Opens Attendance Form
            frmTeacherAttendance fa = new frmTeacherAttendance();
           
            this.Hide();
            fa.ShowDialog();
            this.Show();
        }


            

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to return to login?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
