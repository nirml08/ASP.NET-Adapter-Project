using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class CIAMarksInfo
    {
        public string PROGRAM_ID { get; set; }
        public string CIA_GROUP_MARK_ID { get; set; }
        public string NAME { get; set; }
        public string REGISTER_NO { get; set; }
        public string ROLL_NO { get; set; }
        public string ADMISSION_NO { get; set; }
        public string COURSE_ROOT_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string MAX_MARK { get; set; }
        public string ORDER_ID { get; set; }
        public string CIA_GROUP_ID { get; set; }
        public string COMPONENT_ID { get; set; }
        public string COMPONENT { get; set; }
        public string COURSE_GROUP_MARK { get; set; }
        public string SEMESTER_ID { get; set; }
        public string COURSE_GROUP_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string CLASS_LEVEL { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_TITLE { get; set; }
        public string REMARK { get; set; }
        public string PART { get; set; }
        public string PART_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_ORDER { get; set; }
        public string FIRST_NAME { get; set; }
        public string STAFF_CODE { get; set; }
        public string DEPARTMENT { get; set; }
        public string STAFF_ID { get; set; }
        public string CLSCRSSTF_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string STATUS { get; set; }
        public string MARK { get; set; }
        public string EX_MARK { get; set; }
        public string DIFFERENCE_MARK { get; set; }
        public string COURSE_TYPE_ID { get; set; }
        public string IS_ABSENT { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string M_EXAM { get; set; }
        public string ACADEMIC_YEAR { get; set; }
    }

    public class FetchCIAMarks
    {
        public string STAFF_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_GROUP_ID { get; set; }
        public string SEMESTER_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
    }
}
