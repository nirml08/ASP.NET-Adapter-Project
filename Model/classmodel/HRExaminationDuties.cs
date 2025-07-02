using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class HRExaminationDuties
    {
        public string EXAMINATION_DUTY_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string STAFF_NAME { get; set; }
        public string USER_CODE { get; set; }
        public string ACADEMIC_SESSION_ID { get; set; }
        public string ACADEMIC_SESSION_NAME { get; set; }
        public string EXAMINATION_DUTY_TYPE_ID { get; set; }
        public string EXAMINATION_DUTY_TYPE { get; set; }
        public string HOURS { get; set; }
        public string SCORE { get; set; }
        public string API { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
