using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class FeedbackSetting
    {
        public string FB_SETTING_ID { get; set; }
        public string SETTING_NAME { get; set; }
        public string DATE_FROM { get; set; }
        public string DATE_TO { get; set; }
        public string LIKERT_SCALE_ID { get; set; }
        public string LIKERT_SCALE { get; set; }
        public string IS_ACTIVE { get; set; }
        public string USER_ID { get; set; }
        public string FB_ANSWER_ID { get; set; }
        public string ANSWER_STATUS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_DELETED { get; set; }
    }
}
