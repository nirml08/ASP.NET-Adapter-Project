using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ExamPhotocopyRegistrationDTO
    {
        public string EXAM_PHOTOCOPY_REGISTER_ID { get; set; }
        public string EXAM_PHOTOCOPY_SETTING_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string PAPERS { get; set; }
        public string AMOUNT { get; set; }
        public string REGISTERED_DATE { get; set; }
        public string FREQUENCY { get; set; }
        public string ACADEMIC_YEAR { get; set; }
    }
}
