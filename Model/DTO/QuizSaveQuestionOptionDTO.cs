using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class QuizSaveQuestionOptionDTO
    {
        public string QUIZ_SAVE_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string DATE { get; set; }
        public string STUDENT_ID { get; set; }
        public string QUESTION_ID { get; set; }
        public string OPTION_ID { get; set; }
        public string ANSWER_ID { get; set; }
        public string STATUS { get; set; }
        public string SETTING_ID { get; set; }
        public string SET_ID { get; set; }
        public string SEMESTER_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string SECONDS { get; set; }
        public string MINUTES { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
