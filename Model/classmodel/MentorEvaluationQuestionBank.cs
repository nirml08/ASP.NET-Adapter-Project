using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class MentorEvaluationQuestionBank
    {
        public string EVALUATION_MAIN_QUESTION_ID { get; set; }
        public string QUESTION_TEXT { get; set; }
        public string QUESTION_ORDER { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
