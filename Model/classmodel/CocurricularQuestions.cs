using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class CocurricularQuestions
    {
        public string QUESTION_ID { get; set; }
        public string MAIN_CRITERIA_ID { get; set; }
        public string MAIN_CRITERIA { get; set; }
        public string QUESTION { get; set; }
        public string QUESTION_SCORE { get; set; }
        public string QUESTION_ORDER { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
