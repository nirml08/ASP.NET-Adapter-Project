using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class SemesterMarksDTO
    {
        public string SEMESTER_MARK_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string INTERNAL_MARK { get; set; }
        public string EXTERNAL_MARK { get; set; }
        public string TOTAL { get; set; }
        public string CREDIT { get; set; }
        public string RESULT { get; set; }
        public string APPLIED { get; set; }
        public string SEMESTER { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string M_PASS { get; set; }
        public string IS_ARREAR { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string ENTRY_ID { get; set; }
    }
}
