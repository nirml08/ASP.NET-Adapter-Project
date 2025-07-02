using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class RegistrationCourseBlockDTO
    {
        public string REGISTRATION_COURSE_BLOCK_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string REASON { get; set; }
        public string IS_UNBLOCKED { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string ENTRY_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
