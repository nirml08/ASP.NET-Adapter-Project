using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class CIAExamSettingDTO
    {
        public string EXAM_SETTING_ID { get; set; }
        public string EXAM_NAME { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string M_EXAM { get; set; }
        public string M_PASS { get; set; }
        public string SEMESTER { get; set; }
        public string LAST_DATE_FOR_EXAM_FEE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string EXAM_TYPE { get; set; }
        public string PROGRAMME_TYPE_IDS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
    }
}
