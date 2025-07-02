using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class FeedbackFacultyEvaluationQuestionsDTO
    {
        public string QUESTION_ID { get; set; }
        public string FE_SETTING_ID { get; set; }
        public string QUESTION { get; set; }
        public string QUESTION_TYPE_ID { get; set; }
        public string QUESTION_ORDER { get; set; }
        public string IS_TEXT_AREA { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ENTRY_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
