using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// connection imports
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class frmInfoAcademicOfficers : Form
    {

        public static int selectedIndex = -1;
        public static List<Employee> academicOfficersList = new List<Employee>();

        public frmInfoAcademicOfficers()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back Button
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Edit Button
            // Edit Button
            var frm = new frmEditAcademicOfficers();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            ShowAcademicOfficers();
            selectedIndex = -1;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectedIndex = -1;

            var frm = new frmEditAcademicOfficers();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            ShowAcademicOfficers();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete Button

            // Check if user is sure want to delete
            if (MessageBox.Show("Are you sure you want to delete this?", "Updating Database..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                DeleteRow();

            ShowAcademicOfficers();
            selectedIndex = -1;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

        }

        private void DeleteRow()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM group3fa212330.Employees " +
                    "WHERE EmployeeID = @employeeID", ProgOps.dbConnection);

                cmd.Parameters.AddWithValue("@employeeID", academicOfficersList[selectedIndex].employeeID); ;


                if (cmd.ExecuteNonQuery() <= 0)
                {
                    MessageBox.Show("Error occur while inserting to the database.", "Inserting Database..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Course successfully deleted!", "Deleting Database..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cmd.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public  void ShowAcademicOfficers()
        {
            // This function will show or update all courses in the list box

            // get the information from the database
            try
            {

                SqlCommand cmd;

         
                cmd = new SqlCommand("SELECT * FROM group3fa212330.Employees WHERE Role = 'Academic Officer' ORDER BY LastName", ProgOps.dbConnection);


                SqlDataAdapter accademicOfficerAdapter = new SqlDataAdapter();
                DataTable accademicOfficerTable = new DataTable();

                accademicOfficerAdapter.SelectCommand = cmd;
                accademicOfficerAdapter.Fill(accademicOfficerTable);

                // Dispose unnecessary data
                accademicOfficerAdapter.Dispose();
                cmd.Dispose();

                // Before starting loop, Make sure the academicOfficersList and list box is empty
                // If not than it will add duplicate values
                academicOfficersList.Clear();
                lbxAcademicOfficers.Items.Clear();

                // show to the list box and also add to the course List
                for (int i = 0; i < accademicOfficerTable.Rows.Count; i++)
                {

                    // add item to the course List
                    academicOfficersList.Add(new Employee { 
                        
                        employeeID = accademicOfficerTable.Rows[i]["EmployeeID"].ToString(),
                        frist_name = accademicOfficerTable.Rows[i]["FirstName"].ToString(),
                        last_name = accademicOfficerTable.Rows[i]["LastName"].ToString(),
                        phone = accademicOfficerTable.Rows[i]["Phone"].ToString(),
                        email = accademicOfficerTable.Rows[i]["Email"].ToString(),
                        role = accademicOfficerTable.Rows[i]["Role"].ToString(),
                        
                    });

                    // Now show information to the List box
                    lbxAcademicOfficers.Items.Add(academicOfficersList[i].last_name + ", " + academicOfficersList[i].frist_name);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occur while receiving course information. \n\nSee Error below:\n"
                    + ex.Message.ToString(), "Data receiving error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lbxAcademicOfficers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If user select any index we will enable exit button
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            // check id user actually selected anything
            if (lbxAcademicOfficers.SelectedIndex >= 0)
            {
                selectedIndex = lbxAcademicOfficers.SelectedIndex;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        private void frmInfoAcademicOfficers_Load(object sender, EventArgs e)
        {
            selectedIndex = -1;
            ShowAcademicOfficers();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmHelp("AcademicInfo");
            frm.ShowDialog();
        }
    }
}
