using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AssocationRegistration
    {
        public string REGISTRATION_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string FIRST_NAME { get; set; }

        public string CLASS_ID { get; set; }
        public string CLASS_NAME { get; set; }

        public string COURSE_ID { get; set; }
        public string COURSE_TITLE { get; set; }

        public string SETTING_ID { get; set; }
        public string SETTING_NAME { get; set; }

        public string TIME_REGISTERED { get; set; }
        public string IS_DELETED { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
    }
}
