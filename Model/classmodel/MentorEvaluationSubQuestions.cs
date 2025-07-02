using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class MentorEvaluationSubQuestions
    {
        public string EVALUATION_SUB_QUESTION_ID { get; set; }
        public string MAIN_QUESTION_ID { get; set; }
        public string QUESTION_TEXT { get; set; }
        public string QUESTION_ORDER_NO { get; set; }
        public string SUB_QUESTION_TEXT { get; set; }
        public string SUB_QUESTION_ORDER { get; set; }
        public string MAIN_QUESTION_ORDER { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }

    }
}
