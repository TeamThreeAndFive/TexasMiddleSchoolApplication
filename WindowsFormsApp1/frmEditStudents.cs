using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class frmEditStudents : Form
    {
        public static int editID; //variable to carry StudentID from Info form
        const String _CONNECTION_STRING =
           "Server=cstnt.tstc.edu;" +
           "Database=inew2330sp22;" +
           "User Id=group3fa212330;" +
           "password=3926456";

        // Database connection
        public static SqlConnection dbConnection = new SqlConnection(_CONNECTION_STRING);

        // Data tables
        public static DataTable studentsTable;
        String query;

        public frmEditStudents()
        {
            InitializeComponent();
            editID = frmInfoStudents.editID+1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInfoStudents info = new frmInfoStudents();
            info.Show();
            // Back Button
            this.Close();
            
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Save Changes Button
            try
            {

                query = "SELECT * FROM group3fa212330.Students WHERE StudentID=" + editID;
                SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                SqlDataAdapter daStudent = new SqlDataAdapter();

                studentsTable = new DataTable();
                daStudent.SelectCommand = dbCommand;
                daStudent.Fill(studentsTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daStudent.Dispose();
               // update record in database
                studentsTable.Rows[0]["FirstName"] = tbxFirstName.Text;
                studentsTable.Rows[0]["MiddleName"] = tbxMiddleName.Text;
                studentsTable.Rows[0]["LastName"]=tbxLastName.Text;
                studentsTable.Rows[0]["BirthDate"] = dtpBirthdate.Value;
                studentsTable.Rows[0]["Email"]=tbxEmail.Text;
                studentsTable.Rows[0]["Year"]=tbxYear.Text;
                studentsTable.Rows[0]["MailingAddress"]=tbxMailingAddress;
                studentsTable.Rows[0]["StreetAddress"]=tbxStreetAddress;
                studentsTable.Rows[0]["City"]=tbxCity.Text;
                studentsTable.Rows[0]["State"]=tbxState.Text;
                studentsTable.Rows[0]["Zip"]=tbxZip.Text;


                query = "SELECT * FROM group3fa212330.Guardians WHERE StudentID=" + editID;
                dbCommand = new SqlCommand(query, dbConnection);
                daStudent = new SqlDataAdapter();

                studentsTable = new DataTable();
                daStudent.SelectCommand = dbCommand;
                daStudent.Fill(studentsTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daStudent.Dispose();
                studentsTable.Rows[0]["GuardianID"] = tbxGuardianID.Text;
                studentsTable.Rows[0]["Name"]=tbxGuardianName.Text;
                studentsTable.Rows[0]["MobilePhone"]=tbxGuardianPhone.Text;
                studentsTable.Rows[0]["PlaceOfWork"]=tbxGuardianPlaceofWork.Text;
                studentsTable.Rows[0]["WorkPhone"]=tbxGuardianWorkPhone.Text;

                MessageBox.Show("Update has been saved.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                query = "SELECT * FROM group3fa212330.Students WHERE StudentID=" + editID;
                dbCommand = new SqlCommand(query, dbConnection);
                daStudent = new SqlDataAdapter();

                studentsTable = new DataTable();
                daStudent.SelectCommand = dbCommand;
                daStudent.Fill(studentsTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daStudent.Dispose();

                tbxStudentID.Text = studentsTable.Rows[0]["StudentID"].ToString();
                tbxFirstName.Text = studentsTable.Rows[0]["FirstName"].ToString();
                tbxMiddleName.Text = studentsTable.Rows[0]["MiddleName"].ToString();
                tbxLastName.Text = studentsTable.Rows[0]["LastName"].ToString();
                dtpBirthdate.Value = (DateTime)studentsTable.Rows[0]["BirthDate"];
                tbxEmail.Text = studentsTable.Rows[0]["Email"].ToString();
                tbxYear.Text = studentsTable.Rows[0]["Year"].ToString();
                tbxMailingAddress.Text = studentsTable.Rows[0]["MailingAddress"].ToString();
                tbxStreetAddress.Text = studentsTable.Rows[0]["StreetAddress"].ToString();
                tbxCity.Text = studentsTable.Rows[0]["City"].ToString();
                tbxState.Text = studentsTable.Rows[0]["State"].ToString();
                tbxZip.Text = studentsTable.Rows[0]["Zip"].ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEditStudents_Load(object sender, EventArgs e)
        {
            try
            {
                query = "SELECT * FROM group3fa212330.Students WHERE StudentID=" + editID;
                SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                SqlDataAdapter daStudent = new SqlDataAdapter();

                studentsTable = new DataTable();
                daStudent.SelectCommand = dbCommand;
                daStudent.Fill(studentsTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daStudent.Dispose();

                tbxStudentID.Text = studentsTable.Rows[0]["StudentID"].ToString();
                tbxFirstName.Text = studentsTable.Rows[0]["FirstName"].ToString();
                tbxMiddleName.Text = studentsTable.Rows[0]["MiddleName"].ToString();
                tbxLastName.Text = studentsTable.Rows[0]["LastName"].ToString();
                dtpBirthdate.Value = (DateTime)studentsTable.Rows[0]["BirthDate"];
                tbxEmail.Text = studentsTable.Rows[0]["Email"].ToString();
                tbxYear.Text = studentsTable.Rows[0]["Year"].ToString();
                tbxMailingAddress.Text = studentsTable.Rows[0]["MailingAddress"].ToString();
                tbxStreetAddress.Text = studentsTable.Rows[0]["StreetAddress"].ToString();
                tbxCity.Text = studentsTable.Rows[0]["City"].ToString();
                tbxState.Text = studentsTable.Rows[0]["State"].ToString();
                tbxZip.Text = studentsTable.Rows[0]["Zip"].ToString();

                //load informmation into guardian list boxes
                query = "SELECT * FROM group3fa212330.Guardians WHERE StudentID=" + editID;
                dbCommand = new SqlCommand(query, dbConnection);
                daStudent = new SqlDataAdapter();

                studentsTable = new DataTable();
                daStudent.SelectCommand = dbCommand;
                daStudent.Fill(studentsTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daStudent.Dispose();

                tbxGuardianID.Text = studentsTable.Rows[0]["GuardianID"].ToString();
                tbxGuardianName.Text = studentsTable.Rows[0]["Name"].ToString();
                tbxGuardianPhone.Text = studentsTable.Rows[0]["MobilePhone"].ToString();
                tbxGuardianPlaceofWork.Text = studentsTable.Rows[0]["PlaceOfWork"].ToString();
                tbxGuardianWorkPhone.Text = studentsTable.Rows[0]["WorkPhone"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
