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
    public partial class frmEditTeachers : Form
    {
        public int editID; //variable to carry TeacherID from Info form
        const String _CONNECTION_STRING =
           "Server=cstnt.tstc.edu;" +
           "Database=inew2330sp22;" +
           "User Id=group3fa212330;" +
           "password=3926456";

        // Database connection
        public static SqlConnection dbConnection = new SqlConnection(_CONNECTION_STRING);

        // Data tables
        public static DataTable teachersTable;
        String query;
        public frmEditTeachers()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addNewTeacher()
        {
            
            //inserting student information
            query = "INSERT INTO group3fa212330.Employees(FirstName, LastName, Email, Phone, Role, Password) " +
                    "VALUES (@FirstName, @LastName, @Email, @Phone, @Role, @Password);";
            SqlCommand dbCommand = new SqlCommand(query, ProgOps.dbConnection);
            SqlDataAdapter daTeacher = new SqlDataAdapter();
            teachersTable = new DataTable();
            dbCommand = new SqlCommand(query, ProgOps.dbConnection);
            dbCommand.Parameters.AddWithValue("@FirstName", tbxFirstName.Text);
            dbCommand.Parameters.AddWithValue("@LastName", tbxLastName.Text);
            dbCommand.Parameters.AddWithValue("@Email", tbxEmail.Text);
            dbCommand.Parameters.AddWithValue("@Phone", tbxPhone.Text);
            dbCommand.Parameters.AddWithValue("@Role", "Teacher");
            dbCommand.Parameters.AddWithValue("@Password", tbxPassword.Text);
            daTeacher = new SqlDataAdapter();
            teachersTable = new DataTable();
            daTeacher.SelectCommand = dbCommand;
            daTeacher.Fill(teachersTable);
        }


        private void frmEditTeachers_Load(object sender, EventArgs e)
        {
            try
            {
                editID = frmInfoTeachers.editID;
                if (editID == 0) //if no Teacher is selected, create new Teacher
                {
                    lblEditTeachers.Text = "New Teacher Information";
                    query = "SELECT * FROM group3fa212330.Employees";
                    SqlCommand dbCommand = new SqlCommand(query, ProgOps.dbConnection);
                    SqlDataAdapter daTeacher = new SqlDataAdapter();
                    teachersTable = new DataTable();
                    daTeacher.SelectCommand = dbCommand;
                    daTeacher.Fill(teachersTable);
                }
                else
                {
                    editID = frmInfoTeachers.editID;
                    query = "SELECT * FROM group3fa212330.Employees WHERE EmployeeID=" + editID;
                    SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                    SqlDataAdapter daTeacher = new SqlDataAdapter();

                    teachersTable = new DataTable();
                    daTeacher.SelectCommand = dbCommand;
                    daTeacher.Fill(teachersTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daTeacher.Dispose();

                    tbxEmployeeID.Text = teachersTable.Rows[0]["EmployeeID"].ToString();
                    tbxFirstName.Text = teachersTable.Rows[0]["FirstName"].ToString();
                    tbxLastName.Text = teachersTable.Rows[0]["LastName"].ToString();
                    tbxEmail.Text = teachersTable.Rows[0]["Email"].ToString();
                    tbxPhone.Text = teachersTable.Rows[0]["Phone"].ToString();
                    tbxPassword.Text = teachersTable.Rows[0]["Password"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            // Save Changes Button
            try
            {
                if (frmInfoTeachers.editID==0)
                {
                    addNewTeacher();
                }
                else
                {
                    query = "UPDATE group3fa212330.Employees SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Phone=@Phone," +
                    "Role='Teacher', Password=@Password WHERE EmployeeID=" + editID;
                    SqlCommand dbCommand = new SqlCommand(query, ProgOps.dbConnection);
                    dbCommand.Parameters.AddWithValue("@FirstName", tbxFirstName.Text);
                    dbCommand.Parameters.AddWithValue("@LastName", tbxLastName.Text);
                    dbCommand.Parameters.AddWithValue("@Email", tbxEmail.Text);
                    dbCommand.Parameters.AddWithValue("@Phone", tbxPhone.Text);
                    dbCommand.Parameters.AddWithValue("@Password", tbxPassword.Text);
                    SqlDataAdapter daTeacher = new SqlDataAdapter();

                    teachersTable = new DataTable();
                    daTeacher.SelectCommand = dbCommand;
                    daTeacher.Fill(teachersTable);

                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daTeacher.Dispose();
                    // Dispose unnecessary data
                    dbCommand.Dispose();
                    daTeacher.Dispose();

                }
                MessageBox.Show("Teacher has been updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}