using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Attendance
    {
        public int AttendanceCode { get; set; }
        public int ClassId { get; set; }
        public DateTime Date { get; set; }
        public int FacultyId { get; set; }
        public int Period { get; set; }

        public Attendance(int attendanceCode, int classId, DateTime date, int facultyId, int period)
        {
            AttendanceCode = attendanceCode;
            ClassId = classId;
            Date = date;
            FacultyId = facultyId;
            Period = period;

        }
    }
}
