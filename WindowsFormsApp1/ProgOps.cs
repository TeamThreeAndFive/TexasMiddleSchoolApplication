using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Forms imports
using System.Windows.Forms;

// connection imports
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class ProgOps
    {
        // Connection string
        const String _CONNECTION_STRING = 
            "Server=cstnt.tstc.edu;" +
            "Database=inew2330sp22;" +
            "User Id=group3fa212330;" +
            "password=3926456";
        
        // Database connection
        static SqlConnection dbConnection;

        // Data tables
        static DataTable _userTable;

        // current employee
        public static Employee currentEmployee;

        
        /// <summary>
        /// Connect to inew2330sp22 database and open connection.
        /// Display status of connection on Message Box.
        /// 
        /// Parameters: None
        /// </summary>
        public static void OpenDatabseConnection()
        {
            // Try to connect 
            try
            {
                // connect to the database and open.
                dbConnection = new SqlConnection(_CONNECTION_STRING);
                dbConnection.Open();

                // display connection successful massage
                MessageBox.Show("Database connection is successful.", "Connection success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            } catch (Exception ex)
            {
                // Display error stating cannot connect to the database.
                MessageBox.Show( "Cannot connect / login to the database.\nPlease wait few minutes or restart the application.\n\nSee the error below:\n" + ex.Message, "Failed to connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Close connection and dispose database.
        /// Display status of connection on Message Box.
        /// 
        /// Parameters: None
        /// </summary>
        public static void CloseDatabaseConnection()
        {
            // Try to close connections 
            try
            {
                // close connection
                dbConnection.Close();

                // display connection successful massage
                MessageBox.Show("Database connection closed successfully.", "Connection close", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                // Display error stating cannot connect to the database.
                MessageBox.Show("Unable to close connections.\n\nSee the error below:\n" + ex.Message, "Failed to close", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        /// <summary>
        /// 
        /// login user and add data to employee.
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Boolean: True if found user else false.</returns>
        public static bool Login(string query)
        {
            try
            {
                /// try to log in with provided query

                // EST command and data adapter
                SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                SqlDataAdapter daUser = new SqlDataAdapter();

                // creating new user data table and filling the information
                _userTable = new DataTable();
                daUser.SelectCommand = dbCommand;
                daUser.Fill(_userTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                daUser.Dispose();

                // check if DB return any row
                if (_userTable.Rows.Count != 0)
                {
                    // If so, user is found and add it information to the currentUser.

                    // parse info
                    string fName = _userTable.Rows[0]["FirstName"].ToString();
                    string lName = _userTable.Rows[0]["LastName"].ToString();
                    string email = _userTable.Rows[0]["Email"].ToString();
                    string phone = _userTable.Rows[0]["Phone"].ToString();
                    string role = _userTable.Rows[0]["role"].ToString();

                    currentEmployee = new Employee(fName, lName, email, phone, role);

                    return true;
                } 
                else
                {
                    // else return false because no data was returned and user does not exists with provided query
                    MessageBox.Show("Provided UserName or Password is invalid, Please Try again.", "Validation Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            } 
            catch (Exception ex)
            {
                // If any unknown error occurs
                MessageBox.Show(ex.Message, "LogIn Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        /// <summary>
        /// Check if user exists with provided email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Boolean: True if user found, false if not found.</returns>
        public static bool SearchByEmail(string email)
        {
            // selecting query
            String query = "SELECT * FROM group3fa212330.Employees " +
                "WHERE email = '" + email + "'";

            // 
            try
            {

                // EST command and data adapter
                SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                // creating new user data table and filling the 
                dataAdapter.SelectCommand = dbCommand;
                dataAdapter.Fill(dataTable);

                // Dispose unnecessary data
                dbCommand.Dispose();
                dataAdapter.Dispose();

                if (dataTable.Rows.Count != 0)
                {
                    // dispose data table
                    dataTable.Dispose();
                    return true;
                }
                else
                {
                    // if nothing returned 
                    dataTable.Dispose();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        
        /// <summary>
        /// Update password of given user email.
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="newPassword"></param>
        public static void UpdatePassword(string email, string newPassword)
        {
            // Update query
            string query = "UPDATE group3fa212330.Employees " +
                "SET password = " + "@newPassword " +
                "WHERE email = @email";

            try
            {
                // Make a database connection
                SqlCommand dbCommand = new SqlCommand(query, dbConnection);
                dbCommand.Parameters.AddWithValue("@newPassword", newPassword);
                dbCommand.Parameters.AddWithValue("@email", email);

                // Execute non query and check if it returned anything
                if (dbCommand.ExecuteNonQuery() < 0)
                {
                    // if nothing returned, show message, cannot update new password
                    MessageBox.Show("Cannot update password please try again in few minutes.", "Insertion Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // if something is returned, show message -- successfully updated.
                    MessageBox.Show("Your password has been successfully updated. Please go back to login and login with your new password.", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Dispose data
                dbCommand.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
