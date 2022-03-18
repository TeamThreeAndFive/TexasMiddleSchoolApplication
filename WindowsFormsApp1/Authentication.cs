using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{


    class Authentication
    {
        /// <summary>
        /// Login the user, if exists
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns> Boolean: True if user exists. false if user is not exists</returns>
        public static bool authenticate(string email, string password)
        {
            // make a query to authenticate user
            String query = "SELECT FirstName, LastName, Email, Phone, Role FROM group3fa212330.Employees " +
                "WHERE email = '" + email + "' " +
                "AND " +
                "password = '" + password + "'";

            // Return boolean based on login
            return ProgOps.login(query);
        }

    }

}
