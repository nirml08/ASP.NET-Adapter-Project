using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StaffEvaluationQuestionsDTO
    {
        public string STAFF_EVALUTION_QUESTION_ID { get; set; }
        public string QUESTION { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
