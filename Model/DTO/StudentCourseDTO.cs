using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StudentCourseDTO
    {
        public string COURSE_INFO_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string IS_ELECTIVE { get; set; }
        public string IS_ACTIVE { get; set; }
        public string S_CLASS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string SEMESTER { get; set; }
        public string STAFF_ID { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
