using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamRetotalSetting
    {
        public string EXAM_RETOTAL_SETTING_ID { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string SETTING_NAME { get; set; }
        public string APPLICATION_TYPE_ID { get; set; }
        public string APPLICATION_TYPE { get; set; }
        public string MAX_PAPER { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string STATUS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
    }
}
