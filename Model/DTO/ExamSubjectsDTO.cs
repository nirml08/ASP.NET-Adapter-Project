using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ExamSubjectsDTO
    {
        public string STUDENT_ID { get; set; }

        public string SEMESTER { get; set; }
        public string SUBJECT_TYPE_ID { get; set; }
        public string STATUS { get; set; }
        public string ACADEMIC_YEAR { get; set; }

        public string COURSE_ROOT_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string REGISTRATION_ID { get; set; }

        public string EXAM_SEMESTER { get; set; }
        public string EXAM_SETTING_ID { get; set; }
    }
}
