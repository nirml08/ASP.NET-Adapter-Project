using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AttendancePercentageEntry
    {
        public string ATT_PERCENTAGE_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string STUDENT_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string CLASS_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string SEMESTER_ID { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string PERCENTAGE { get; set; }
        public string ENTRY_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
