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
    public partial class frmTeacherSeatingChart : Form
    {
        public frmTeacherSeatingChart()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            //Shuffle Seating Arrangement 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save Seating Arrangement
        }
    }
}
