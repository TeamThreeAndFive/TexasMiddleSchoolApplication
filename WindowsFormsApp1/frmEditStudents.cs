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

        // Data tables
        public static DataTable studentsTable;
        String query;

        public frmEditStudents()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back Button
            this.Close();
            this.Visible = false;

        }
        private void addNewStudent()
        {
            query = "SELECT * FROM group3fa212330.Students";
            SqlCommand dbCommand = new SqlCommand(query, ProgOps.dbConnection);
            SqlDataAdapter daStudent = new SqlDataAdapter();
            studentsTable = new DataTable();
            daStudent.SelectCommand = dbCommand;
            daStudent.Fill(studentsTable);

            for (int i = 0; i < studentsTable.Rows.Count; i++)
            {
                if (tbxStudentID.Text == studentsTable.Rows[i]["StudentID"].ToString())
                {
                    MessageBox.Show("StudentID is taken. Please enter a different ID number.", "Student ID Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            tbxGuardianID.Text = tbxStudentID.Text;
            //inserting student information
            query = "INSERT INTO group3fa212330.Students(StudentID, FirstName, MiddleName, LastName, BirthDate, MailingAddress, StreetAddress, City, State, Zip, EmergencyPhone, Year, Email, GuardianID, EmergencyContact) " +
            "VALUES (@StudentID, @FirstName, @MiddleName, @LastName, @BirthDate, @MailingAddress, @StreetAddress, @City, @State, @Zip, @EmergencyPhone, @Year, @Email, @GuardianID, @EmergencyContact);";
            dbCommand = new SqlCommand(query, ProgOps.dbConnection);
            dbCommand.Parameters.AddWithValue("@StudentID", tbxStudentID.Text);
            dbCommand.Parameters.AddWithValue("@FirstName", tbxFirstName.Text);
            dbCommand.Parameters.AddWithValue("@MiddleName", tbxMiddleName.Text);
            dbCommand.Parameters.AddWithValue("@LastName", tbxLastName.Text);
            dbCommand.Parameters.AddWithValue("@BirthDate", dtpBirthdate.Text);
            dbCommand.Parameters.AddWithValue("@MailingAddress", tbxMailingAddress.Text);
            dbCommand.Parameters.AddWithValue("@StreetAddress", tbxStreetAddress.Text);
            dbCommand.Parameters.AddWithValue("@City", tbxCity.Text);
            dbCommand.Parameters.AddWithValue("@State", tbxState.Text);
            dbCommand.Parameters.AddWithValue("@Zip", tbxZip.Text);
            dbCommand.Parameters.AddWithValue("@EmergencyPhone", tbxGuardianPhone.Text);
            dbCommand.Parameters.AddWithValue("@Year", tbxYear.Text);
            dbCommand.Parameters.AddWithValue("@Email", tbxEmail.Text);
            dbCommand.Parameters.AddWithValue("@GuardianID", tbxGuardianID.Text);
            dbCommand.Parameters.AddWithValue("@EmergencyContact", tbxGuardianName.Text);
            daStudent = new SqlDataAdapter();
            studentsTable = new DataTable();
            daStudent.SelectCommand = dbCommand;
            daStudent.Fill(studentsTable);

           

            query = "SELECT * FROM group3fa212330.Guardians";
            dbCommand = new SqlCommand(query, ProgOps.dbConnection);
            daStudent = new SqlDataAdapter();
            studentsTable = new DataTable();
            daStudent.SelectCommand = dbCommand;
            daStudent.Fill(studentsTable);

            for (int i = 0; i < studentsTable.Rows.Count; i++)
            {
                if (tbxGuardianID.Text == studentsTable.Rows[i]["GuardianID"].ToString())
                {
                    MessageBox.Show("Guardian ID is taken. Please enter a different ID number.", "Guardian ID Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //inserting guardian information
            query = "INSERT INTO group3fa212330.Guardians(GuardianID, Name, MobilePhone, WorkPhone, PlaceOfWork, StudentID) " +
           "VALUES (@GuardianID, @Name, @MobilePhone, @WorkPhone, @PlaceOfWork, @StudentID);";
            dbCommand = new SqlCommand(query, ProgOps.dbConnection);
            dbCommand.Parameters.AddWithValue("@GuardianID", tbxGuardianID.Text);
            dbCommand.Parameters.AddWithValue("@Name", tbxGuardianName.Text);
            dbCommand.Parameters.AddWithValue("@MobilePhone", tbxGuardianPhone.Text);
            dbCommand.Parameters.AddWithValue("@PlaceOfWork", tbxGuardianPlaceofWork.Text);
            dbCommand.Parameters.AddWithValue("@WorkPhone", tbxGuardianWorkPhone.Text);
            dbCommand.Parameters.AddWithValue("@StudentID", tbxStudentID.Text);
            daStudent = new SqlDataAdapter();
            studentsTable = new DataTable();
            daStudent.SelectCommand = dbCommand;
            daStudent.Fill(studentsTable);

            

            dbCommand.Dispose();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // uses editID to open add student form
                if (frmInfoStudents.editID == 0)
                {
                    addNewStudent();         

                }
                else
                {
                    query = "UPDATE group3fa212330.Students SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName,BirthDate=@BirthDate, MailingAddress = @MailingAddress, StreetAddress = @StreetAddress, City = @City, State = @State, Zip = @Zip,Year=@Year, Email = @Email, GuardianID=@GuardianID, EmergencyContact=@EmergencyContact WHERE StudentID=" + editID;
                    SqlCommand dbCommand = new SqlCommand(query, ProgOps.dbConnection);
                    dbCommand.Parameters.AddWithValue("@FirstName", tbxFirstName.Text);
                    dbCommand.Parameters.AddWithValue("@MiddleName", tbxMiddleName.Text);
                    dbCommand.Parameters.AddWithValue("@LastName", tbxLastName.Text);
                    dbCommand.Parameters.AddWithValue("@BirthDate", dtpBirthdate.Text);
                    dbCommand.Parameters.AddWithValue("@MailingAddress", tbxMailingAddress.Text);
                    dbCommand.Parameters.AddWithValue("@StreetAddress", tbxStreetAddress.Text);
                    dbCommand.Parameters.AddWithValue("@City", tbxCity.Text);
                    dbCommand.Parameters.AddWithValue("@State", tbxState.Text);
                    dbCommand.Parameters.AddWithValue("@Zip", tbxZip.Text);
                    dbCommand.Parameters.AddWithValue("@EmergencyPhone", tbxGuardianPhone.Text);
                    dbCommand.Parameters.AddWithValue("@Year", tbxYear.Text);
                    dbCommand.Parameters.AddWithValue("@Email", tbxEmail.Text);
                    dbCommand.Parameters.AddWithValue("@GuardianID", tbxGuardianID.Text);
                    dbCommand.Parameters.AddWithValue("@EmergencyContact", tbxGuardianName.Text);
                    SqlDataAdapter daStudent = new SqlDataAdapter();

                    studentsTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(studentsTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();

                    query = "UPDATE group3fa212330.Guardians SET Name=@Name, MobilePhone=@MobilePhone, WorkPhone=@WorkPhone, PlaceOfWork=@PlaceOfWork WHERE StudentID=" + editID;
                    dbCommand = new SqlCommand(query, ProgOps.dbConnection);
                    dbCommand.Parameters.AddWithValue("@Name", tbxGuardianName.Text);
                    dbCommand.Parameters.AddWithValue("@MobilePhone", tbxGuardianPhone.Text);
                    dbCommand.Parameters.AddWithValue("@PlaceOfWork", tbxGuardianPlaceofWork.Text);
                    dbCommand.Parameters.AddWithValue("@WorkPhone", tbxGuardianWorkPhone.Text);
                    daStudent = new SqlDataAdapter();

                    studentsTable = new DataTable();
                    daStudent.SelectCommand = dbCommand;
                    daStudent.Fill(studentsTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daStudent.Dispose();
                }
                MessageBox.Show("Update has been saved.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                frmInfoStudents info = new frmInfoStudents();
                info.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEditStudents_Load(object sender, EventArgs e)
        {
            try
            {
                editID = frmInfoStudents.editID;
                if (editID == 0) //if no student is selected, create new student
                {
                    lblEditStudents.Text = "New Student Information";
                    tbxStudentID.ReadOnly = false;
                    tbxGuardianID.ReadOnly = false;
                }
                else
                {
                    query = "SELECT * FROM group3fa212330.Students WHERE StudentID=" + editID;
                    SqlCommand dbCommand = new SqlCommand(query, ProgOps.dbConnection);
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
                    dbCommand = new SqlCommand(query, ProgOps.dbConnection);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
