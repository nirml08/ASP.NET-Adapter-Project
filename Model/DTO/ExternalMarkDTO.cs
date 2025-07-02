using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ExternalMarkDTO
    {
        public string EXTERNAL_MARK_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string EXTERNAL_MARK { get; set; }
        public string ENTRY_MARK { get; set; }
        public string SEMESTER { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string ENTRY_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ARREAR { get; set; }
        public string IS_COMBINED { get; set; }
        public string IS_LESS_CREDIT { get; set; }
        public string T_MARK { get; set; }
        public string P_MARK { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
