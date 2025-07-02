using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class Attendance
    {
        public string ATTENDANCE_ID { get; set; }
        public string ATTENDENCE_DATE { get; set; }
        public string STAFF_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }

        public string HOUR_FROM { get; set; }
        public string HOUR_TO { get; set; }
        public string STUDENT_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string STATUS { get; set; }
        public string CLASS_ID { get; set; }
        public string CLASS_NAME { get; set; }

        public string REASON_ID { get; set; }
        public string ENTRY_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string IS_DELETED { get; set; }
        public string S_CLASS_ID { get; set; }
        public string ATTENDANCE_TYPE_ID { get; set; }
        public string IS_PROCESSED { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string SHIFT { get; set; }
        public string DAY_ORDER_ID { get; set; }
        public string DEPARTMENT { get; set; }

    }
}
