using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class QuizSettingDTO
    {
        public string SETTING_ID { get; set; }
        public string SETTING_NAME { get; set; }
        public string QUIZ_TYPE_ID { get; set; }
        public string QUIZ_STF_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string NO_OF_QUESTIONS { get; set; }
        public string EACH_QUESTION_MARKS { get; set; }
        public string TOTAL_MARK { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string ENTRY_DATE { get; set; }
        public string TIME { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string IS_CORRECT { get; set; }
        public string IS_SHOW_MARKS { get; set; }
        public string IS_SHOW_RIGHT_ANSWER { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }

    }
}
