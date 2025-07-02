using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ClassRepoFeedback
    {
        public string FEEDBACK_ID { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string DATE_TIME { get; set; }
        public string VENUE { get; set; }
        public string MEETING_AGENDA { get; set; }
        public string COURSE_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string STAFF_ID { get; set; }
        public string FEEDBACK_STUDENT { get; set; }
        public string FEEDBACK_STAFF { get; set; }
        public string COMPLETION_SYLLABUS { get; set; }
        public string SUGGESTIONS_FOR_IMPROVEMENT { get; set; }
        public string MAINTENANCE_REQUIREMENTS { get; set; }
        public string ENTRY_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string ROLL_NO { get; set; }
        public string REGISTER_NO { get; set; }
        public string PERCENTAGE { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string ATTENDANCE_PERCENT_ID { get; set; }
        public string CLASSREPO_FEEDBACK_FACULTY { get; set; }
        public string FACULTY_FEEDBACK { get; set; }
        public string COMPLETION_OF_SYLLABUS { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string STAFF_NAME { get; set; }
        public string COURSE_TITLE { get; set; }


    }
    public class ClassRepoFeedbackFaculty
    {
        public string CLASSREPO_FEEDBACK_FACULTY { get; set; }
        public string FEEDBACK_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string FACULTY_FEEDBACK { get; set; }
        public string COMPLETION_OF_SYLLABUS { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }

    }
    public class AttendancePercentage
    {

        public string ATTENDANCE_PERCENT_ID { get; set; }
        public string FEEDBACK_ID { get; set; }
        public string PERCENTAGE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
