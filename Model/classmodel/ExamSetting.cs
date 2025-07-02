using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamSetting
    {
        public string EXAM_SETTING_ID { get; set; }
        public string EXAM_NAME { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string M_EXAM { get; set; }
        public string M_PASS { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_PUBLISHED { get; set; }
        public string IS_DELETED { get; set; }
        public string SEMESTER_TYPE { get; set; }
        public string SEMESTER_TYPE_ID { get; set; }
        public string EXAM_TYPE { get; set; }
        public string EXAM_TYPE_NAME { get; set; }
        public string LAST_DATE_FOR_EXAM_FEE { get; set; }
        public string FINE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string STUDENT_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string FREQUENCY_NAME { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string IS_MOCK { get; set; }
    }
}
