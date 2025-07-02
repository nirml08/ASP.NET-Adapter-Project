using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class NMERegistrationDTO
    {
        public string REGISTRATION_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string TIME_REGISTERED { get; set; }
        public string SETTINGS_ID { get; set; }
        public string SEMESTER { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string S_CLASS_ID { get; set; }
        public string IS_DELETED { get; set; }
    }
}
