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
    public partial class frmHelp : Form
    {
        private string _helpKind;

        public frmHelp(string helpKind)
        {
            InitializeComponent();
            _helpKind = helpKind;
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            // check help kind and display appropriate picture
            if(_helpKind == "CourseInfo")
            {
                pbxHelpImage.Image = Properties.Resources.CourseInformationHelp;

            } else if (_helpKind == "AcademicInfo")
            {
                pbxHelpImage.Image = Properties.Resources.AcademicOfficerInformation;

            } else if (_helpKind == "EditCourse")
            {
                pbxHelpImage.Image = Properties.Resources.EditCourseInfo;
            }
            else if (_helpKind == "NewCourse")
            {
                pbxHelpImage.Image = Properties.Resources.addNewCourse;
            }
            else if (_helpKind == "EditAcademic")
            {
                pbxHelpImage.Image = Properties.Resources.EditAcademicOfficer;
            }
            else if (_helpKind == "NewAcademic")
            {
                pbxHelpImage.Image = Properties.Resources.AddNewAcademicOfficer;
            } 
            else if (_helpKind == "AssignCourse")
            {
                pbxHelpImage.Image = Properties.Resources.NewAssignCourseHelp;
            }
        }
    }
}
