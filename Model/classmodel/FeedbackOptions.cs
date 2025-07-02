using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class FeedbackOptions
    {
        public string FEEDBACK_OPTION_ID { get; set; }
        public string FEEDBACK_OPTION { get; set; }
        public string FEEDBACK_MARK { get; set; }
        public string LIKERT_SCALE_ID { get; set; }
        public string LIKERT_SCALE { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
