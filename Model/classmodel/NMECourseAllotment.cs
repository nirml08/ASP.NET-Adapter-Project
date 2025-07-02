using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class NMECourseAllotment
    {
        public string ALLOTMENT_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_TITLE { get; set; }
        public string SHIFT_ID { get; set; }
        public string SHIFT_NAME { get; set; }
        public string ALLOTED_SEATS { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string SEMESTER_ID { get; set; }
        public string IS_DELETED { get; set; }
    }
}
