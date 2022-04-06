using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Course
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

        public int id;
        public string name, startDate, endDate, meetingDays, meetingTime, room;

        public Course() { }

        public Course(int id, string name, string startDate, string endDate, string meetingDays, string meetingTime, string room)
        {
            this.id = id;
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.meetingDays = meetingDays;
            this.meetingTime = meetingTime;
            this.room = room;
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
