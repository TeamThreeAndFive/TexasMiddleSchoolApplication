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
    public partial class frmInfoStudents : Form
    {
        public frmInfoStudents()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Edit Button
            var editStudentForm = new frmEditStudents();
            editStudentForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add Button
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete Button
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Undo Button
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear Button
        }



        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
