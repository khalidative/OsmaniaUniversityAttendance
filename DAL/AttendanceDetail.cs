using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AttendanceDetail
    {
        public int AttendanceCode { get; set; }
        public long RollNo { get; set; }
        public Boolean Presence { get; set; }

        public AttendanceDetail(int attendanceCode, long rollNo, Boolean presence)
        {
            AttendanceCode = attendanceCode;
            RollNo = rollNo;
            Presence = presence;
        }
    }
}
