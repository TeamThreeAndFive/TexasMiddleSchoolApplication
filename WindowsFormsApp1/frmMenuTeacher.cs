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
            this.Hide();
        }

        private void btnGradebook_Click(object sender, EventArgs e)
        {
            frmTeacherGradebook fg = new frmTeacherGradebook();
            fg.Show();
        }

        private void btnSeating_Click(object sender, EventArgs e)
        {
            frmTeacherSeatingChart fs = new frmTeacherSeatingChart();
            fs.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            frmTeacherAttendance fa = new frmTeacherAttendance();
            fa.Show();
        }
    }
}
