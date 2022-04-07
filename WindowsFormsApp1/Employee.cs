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
    public class Employee
    {
        public string employeeID;
        public string frist_name;
        public string last_name;
        public string email;
        public string phone;
        public string role;

        public Employee() { }

        /// <summary>
        /// constructor to build employee with parameters
        /// </summary>
        /// <param name="empID"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="role"></param>
        public Employee(string empID, string fName, string lName, string email, string phone, string role)
        {
            this.employeeID = empID;
            this.frist_name = fName;
            this.last_name = lName;
            this.email = email;
            this.phone = phone;
            this.role = role;
        }

        // getter to get information

        public string getEmployeeID()
        { return this.employeeID; }

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
