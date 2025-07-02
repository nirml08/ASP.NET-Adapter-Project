using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ClassCourseStaff
    {
        public string CLSCRSSTF_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string STAFF_ID { get; set; }
        public string USER_CODE { get; set; }

        public string FIRST_NAME { get; set; }
        public string NAME { get; set; }


        public string STF_ALLOTMENT_TYPE { get; set; }
        public string HRS_WEEK { get; set; }
        public string HRS_TERM { get; set; }
        public string SHIFT { get; set; }
        public string IS_PRIMARY_STAFF { get; set; }
        public string SEMESTER_ID { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string SEMESTER { get; set; }

        public string SEMESTER_TYPE_ID { get; set; }
        public string SEMESTER_TYPE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CAMPUS_NAME { get; set; }

        public string IS_DELETED { get; set; }
        public string CLASS_TYPE { get; set; }
        public string STAFF_COUNT { get; set; }
        public string DEPARTMENT { get; set; }
        public string CLASS_CODE { get; set; }
        public string QUIZ_STF_ID { get; set; }
    }
}
