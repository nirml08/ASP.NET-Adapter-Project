using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class FeedbackFacultyEvaluationAnswerDTO
    {
        public string FE_ANSWER_ID { get; set; }
        public string FE_SETTING_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string QUESTION_ID { get; set; }
        public string FEEDBACK_OPTION_ID { get; set; }
        public string FEEDBACK { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string SEMESTER_ID { get; set; }
        public string CREATED_AT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }

    public class FeedbackFacultyEvaluationRemarkDTO
    {
        public string FE_REMARK_ID { get; set; }
        public string FE_SETTING_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string SEMESTER_ID { get; set; }
        public string NOTABLE_STRENGTHANDWEAKNESS { get; set; }
        public string STRENGTH { get; set; }
        public string WEAKNESS { get; set; }
        public string CONTINUE_TEACHING { get; set; }
        public string FACULTY_GRADE { get; set; }
        public string OVERALL_GRADE { get; set; }
        public string CHANGE_IN_COURSE_OUTLINE { get; set; }
        public string OTHER_REMARKS { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CREATED_AT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }

    public class FeedbackFacultyEvaluationAnswerandRemarkDTO
    {
        public List<FeedbackFacultyEvaluationAnswerDTO> FeedbackFacultyEvaluationAnswerDTO { get; set; }
        public List<FeedbackFacultyEvaluationRemarkDTO> FeedbackFacultyEvaluationRemarkDTO { get; set; }
    }
}
