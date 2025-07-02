using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class NMEClassCourse
    {
        public string NME_CLASS_COURSE_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_TITLE { get; set; }

        public string SETTINGS_ID { get; set; }
        public string SETTINGS_NAME { get; set; }

        public string ACADEMIC_YEAR { get; set; }
        public string CLASS_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string CAMPUS_ID { get; set; }
        public string SEMESTER_ID { get; set; }

        public string IS_DELETED { get; set; }
    }
}
