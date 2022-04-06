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
        public static int editID; //variable to carry StudentID from Info form
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Save Changes Button
            // Save Changes Button
            try
            {

                query = "SELECT * FROM group3fa212330.Employees WHERE EmployeeID=" + editID;
                SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                SqlDataAdapter daStudent = new SqlDataAdapter();

                teachersTable = new DataTable();
                daStudent.SelectCommand = dbCommand;
                daStudent.Fill(teachersTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daStudent.Dispose();
                // update record in database
                teachersTable.Rows[0]["FirstName"] = tbxFirstName.Text;
                teachersTable.Rows[0]["LastName"] = tbxLastName.Text;
                teachersTable.Rows[0]["Phone"] = tbxPhone.Text;
                teachersTable.Rows[0]["Email"] = tbxEmail.Text;


                MessageBox.Show("Update has been saved.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                //reload listbox
                query = "SELECT * FROM group3fa212330.Employees WHERE EmployeeID=" + editID;
                dbCommand = new SqlCommand(query, dbConnection);
                daStudent = new SqlDataAdapter();

                teachersTable = new DataTable();
                daStudent.SelectCommand = dbCommand;
                daStudent.Fill(teachersTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daStudent.Dispose();

                tbxEmployeeID.Text = teachersTable.Rows[0]["EmployeeID"].ToString();
                tbxFirstName.Text = teachersTable.Rows[0]["FirstName"].ToString();
                tbxLastName.Text = teachersTable.Rows[0]["LastName"].ToString();
                tbxEmail.Text = teachersTable.Rows[0]["Email"].ToString();
                tbxPhone.Text = teachersTable.Rows[0]["Phone"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEditTeachers_Load(object sender, EventArgs e)
        {
            try
            {
                editID = frmInfoTeachers.editID;
                query = "SELECT * FROM group3fa212330.Employees WHERE EmployeeID=" + editID;
                SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                SqlDataAdapter daStudent = new SqlDataAdapter();

                teachersTable = new DataTable();
                daStudent.SelectCommand = dbCommand;
                daStudent.Fill(teachersTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daStudent.Dispose();

                tbxEmployeeID.Text = teachersTable.Rows[0]["EmployeeID"].ToString();
                tbxFirstName.Text = teachersTable.Rows[0]["FirstName"].ToString();
                tbxLastName.Text = teachersTable.Rows[0]["LastName"].ToString();
                tbxEmail.Text = teachersTable.Rows[0]["Email"].ToString();
                tbxPhone.Text = teachersTable.Rows[0]["Phone"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}