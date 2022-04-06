using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Course
    {

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
    }
}
