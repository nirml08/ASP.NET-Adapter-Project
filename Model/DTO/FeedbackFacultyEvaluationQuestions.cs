using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class FeedbackFacultyEvaluationQuestions
    {
        public string QUESTION_ID { get; set; }
        public string FE_SETTING_ID { get; set; }
        public string SETTING_NAME { get; set; }
        public string QUESTION { get; set; }
        public string QUESTION_TYPE_ID { get; set; }
        public string QUESTION_TYPE { get; set; }
        public string QUESTION_ORDER { get; set; }
        public string ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string ENTRY_ID { get; set; }
        public string IS_TEXT_AREA { get; set; }
        public string STUDENT_ID { get; set; }
        public string FEEDBACK_ROLE_ID { get; set; }
        public string QUESTION_GROUP { get; set; }
        public string GROUP_TITLE { get; set; }
        public string OBJECTIVE_ID { get; set; }
        public string OBJECTIVES { get; set; }
        public string QUESTION_OBJECT_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }

        public string FE_ANSWER_ID { get; set; }
        public string FEEDBACK_OPTION_ID { get; set; }
        public string FEEDBACK_OPTION { get; set; }
        public string FEEDBACK { get; set; }
        public string ENTRY_DATE { get; set; }
        public string ANSWER_STATUS { get; set; }
        public string SEMESTER_ID { get; set; }
    }
}
