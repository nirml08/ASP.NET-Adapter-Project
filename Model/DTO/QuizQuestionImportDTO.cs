using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class QuizQuestionImportDTO
    {
        public string ENTRY_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string SETTING_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string NO_OF_QUESTIONS { get; set; }
        public string SEMESTER_ID { get; set; }
        public List<QuizQuestionWithOption> QUESTION {  get; set; }

    }
    public class QuizQuestionWithOption
    {
        public string QUESTION_ID { get; set; }
        public string QUESTION { get; set; }
    
        public string QUESTION_TYPE { get; set; }
        public string MARK { get; set; }
        public string STAFF_ID { get; set; }
        public List<QuizOptionDTO> QuizOption { get; set; }

    }
}
