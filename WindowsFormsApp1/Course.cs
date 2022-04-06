using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Course
    {
        // Course ID
        private string course_id;
        // Course Name
        private string course_name;
        // Start Date
        private string start_date;
        // End Date
        private string end_date;
        // Meeting Days
        private string meeting_days;
        // Meeting Time
        private string meeting_time;
        // Room Number
        private string room_number;

        public Course(string cId, string cName, string sDate, string eDate, string mDays, string mTime, string rNum)
        {
            this.course_id = cId;
            this.course_name = cName;
            this.start_date = sDate;
            this.end_date = eDate;
            this.meeting_days = mDays;
            this.meeting_time = mTime;
            this.room_number = rNum;
        }
        // getter to get information

        // Course ID
        public string getCourseID()
        { return this.course_id; }

        public string getCourseName()
        { return this.course_name; }

        public string getStartDate()
        { return this.start_date; }

        public string getEndDate()
        { return this.end_date; }

        public string getMeetingDays()
        { return this.meeting_days; }

        public string getMeetingTime()
        { return this.meeting_time; }

        public string getRoomNumber()
        { return this.room_number; }
    }
}
