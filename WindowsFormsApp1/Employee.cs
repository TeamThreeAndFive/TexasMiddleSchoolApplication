using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// This class holds information about the employee
    /// </summary>
    class Employee
    {
        private string frist_name;
        private string last_name;
        private string email;
        private string phone;
        private string role;

        
        /// <summary>
        /// constructor to build employee with parameters
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="role"></param>
        public Employee(string fName, string lName, string email, string phone, string role)
        {
            this.frist_name = fName;
            this.last_name = lName;
            this.email = email;
            this.phone = phone;
            this.role = role;
        }

        // getter to get information
        public string getFirstName()
        { return this.frist_name; }

        public string getLastName()
        { return this.last_name; }

        public string getEmail()
        { return this.email; }

        public string getPhone()
        { return this.phone; }

        public string getRole()
        { return this.role; }

    }
}
