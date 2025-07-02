using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StudentAppraisalMarkDTO
    {
        public string STUDENT_APPRAISAL_MARK_ID { get; set; }
        public string MENTOR_MAIN_TOPIC_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string QUESTION_ID { get; set; }
        public string STU_MARK { get; set; }
        public string STAFF_MARK { get; set; }
        public string SETTING_ID { get; set; }
        public string APPRISAL_SETTING_ID { get; set; }
        public string STAFF_REMARK { get; set; }
        public string STUDENT_REMARK { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_TEXTAREA { get; set; }
        public string ACADAMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
