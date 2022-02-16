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
        const String _CONNECTION_STRING = "Server=cstnt.tstc.edu;" +
            "Database=inew2330sp22;" +
            "User Id=group3fa212330;" +
            "password=3926456";
        
        // Database connection
        static SqlConnection dbConnection;
        
        
        /// <summary>
        /// Connect to inew2330sp22 database and open connection.
        /// Display status of connection on Message Box.
        /// 
        /// Parameters: None
        /// </summary>
        public static void openDatabseConnection()
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
        public static void closeDatabaseConnection()
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

    }
}
