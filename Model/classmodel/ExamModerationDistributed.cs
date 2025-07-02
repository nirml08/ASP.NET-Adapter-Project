using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamModerationDistributed
    {
        public string EXAM_SETTING_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string MODERATION_MARK { get; set; }
        public string BALANCE_MARK { get; set; }

        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string FIRST_NAME { get; set; }
        public string COURSE_TITLE { get; set; }
        public string REGISTER_NO { get; set; }
        public string COURSE_CODE { get; set; }

        public string EXTERNAL_MARK { get; set; }
        public string INTERNAL_MARK { get; set; }
        public string TOTAL { get; set; }
        public string IS_REVALUTION { get; set; }
    }
}
