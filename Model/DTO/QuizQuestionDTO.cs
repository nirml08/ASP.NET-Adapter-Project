
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class QuizQuestionDTO
    {
        public string QUESTION_ID { get; set; }
        public string QUESTION { get; set; }
        public string COURSE_ID { get; set; }
        public string SET_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string ANSWER_ID { get; set; }
        public string QUESTION_TYPE { get; set; }
        public string MARK { get; set; }
        public string SETTING_ID { get; set; }
        public string NO_OF_QUESTIONS { get; set; }
        public string SEMESTER_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ENTRY_ID { get; set; }
    }

    public class QuizQuestionandAnswerDTO
    {
        public QuizQuestionDTO QuizQuestion { get; set; }
        public List<QuizOptionDTO> QuizOption { get; set; }
    }

    public class QuestionCopy
    {
        public string FROM_CLASS_ID { get; set; }
        public string FROM_COURSE_ID { get; set; }
        public string FROM_STAFF_ID { get; set; }
        public string FROM_SETTING_ID { get; set; }
        public string TO_CLASS_ID { get; set; }
        public string TO_COURSE_ID { get; set; }
        public string TO_STAFF_ID { get; set; }
        public string TO_SETTING_ID { get; set; }
    }
}
