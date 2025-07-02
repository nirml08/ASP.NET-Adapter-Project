using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class MentorEvaluationQuestionAnswer
    {
        public string EVALUATION_QUESTION_ANSWER_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string STAFF_NAME { get; set; }
        public string MAIN_QUESTION_ID { get; set; }
        public string QUESTION_TEXT { get; set; }
        public string MAIN_QUESTION_ORDER { get; set; }
        public string SUB_QUESTION_ID { get; set; }
        public string SUB_QUESTION_TEXT { get; set; }
        public string SUB_QUESTION_ORDER { get; set; }
        public string ANSWER { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
