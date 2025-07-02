using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class FeedbackFacultyEvaluationSettings
    {
        public string FE_SETTING_ID { get; set; }
        public string SETTING_NAME { get; set; }
        public string DATE_FROM { get; set; }
        public string DATE_TO { get; set; }
        public string LIKERT_SCALE_ID { get; set; }
        public string LIKERT_SCALE { get; set; }
        public string IS_ACTIVE { get; set; }
        public string USER_ID { get; set; }
        public string FB_ANSWER_ID { get; set; }
        public string ANSWER_STATUS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_DELETED { get; set; }
    }

    public class FeedbackClassandCourse
    {
        public string CLASS_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string STAFF_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string SEMESTER_ID { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string SEMESTER_TYPE_ID { get; set; }
        public string SEMESTER_TYPE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string ENTRY_STATUS { get; set; }
    }
}
