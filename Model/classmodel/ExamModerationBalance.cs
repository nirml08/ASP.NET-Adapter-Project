using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamModerationBalance
    {
        public string MODERATION_BALANCE_ID { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string BALANCE_MARK { get; set; }
        public string IS_REVALUATION { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
