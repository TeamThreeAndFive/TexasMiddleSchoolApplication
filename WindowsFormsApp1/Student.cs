using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Student
    {
        private string student_id;
        private string first_name;
        private string middle_name;
        private string last_name;
        private string birthdate;
        private string mailing_address;
        private string street_address;
        private string city;
        private string state;
        private string zip;
        private string emergency_phone;
        private string year;
        private string email;
        private string guardian_id;
        private string emergency_contact;


        /// <summary>
        /// constructor to build employee with parameters
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="fName"></param>
        /// <param name="mName"></param>
        /// <param name="lName"></param>
        /// <param name="bDate"></param>
        /// <param name="mAddress"></param>
        /// <param name="sAddress"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="ePhone"></param>
        /// <param name="year"></param>
        /// <param name="email"></param>
        /// <param name="gID"></param>
        /// <param name="eContact"></param>
        public Student(string sId, string fName, string mName, string lName, string bDate, string mAddress, string sAddress, string city, string state, string zip, string ePhone, string year, string email, string gID, string eContact)
        {
            this.student_id = sId;
            this.first_name = fName;
            this.middle_name = mName;
            this.last_name = lName;
            this.birthdate = bDate;
            this.mailing_address = mAddress;
            this.street_address = sAddress;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.emergency_phone = ePhone;
            this.year = year;
            this.email = email;
            this.guardian_id = gID;
            this.emergency_contact = eContact;
        }

        // getter to get information

        // Student ID
        public string getStudentID()
        { return this.student_id; }

        // First Name
        public string getFirstName()
        { return this.first_name; }

        // Middle Name
        public string getMiddleName()
        { return this.middle_name; }

        // Last Name
        public string getLastName()
        { return this.last_name; }

        // Birthdate
        public string getBirthDate()
        { return this.birthdate; }

        // Mailing Address
        public string getMailingAddress()
        { return this.mailing_address; }

        // Street Address
        public string getStreetAddress()
        { return this.street_address; }

        // City
        public string getCity()
        { return this.city; }
        // State
        public string getState()
        { return this.state; }
        // Zip
        public string getZip()
        { return this.zip; }
        // Emergency Phone
        public string getEmergencyPhone()
        { return this.emergency_phone; }
        // Year
        public string getYear()
        { return this.year; }
        // Email
        public string getEmail()
        { return this.email; }

        // Guardian ID
        public string getGuardianID()
        { return this.guardian_id; }

        // Emergency Contact
        public string getEmergencyContact()
        { return this.emergency_contact; }
    }
}
