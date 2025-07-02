using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class MentorAppraisalMainHeadRemarkDTO
    {
        public string MENTOR_MAIN_HEAD_REMARK_ID { get; set; }
        public string MENTOR_MAIN_TOPIC_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string APPRISAL_SETTING_ID { get; set; }
        public string STAFF_REMARK { get; set; }
        public string STUDENT_REMARK { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
    }
}
