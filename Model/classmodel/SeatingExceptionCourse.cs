using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class SeatingExceptionCourse
    {
        public string EXAM_SEATING_EXCEPTOIN_COURSE_ID { get; set; }
        public string EXAM_DATE { get; set; }
        public string EXAM_TIME { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }

        public string ACADEMIC_YEAR { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string EXAM_NAME { get; set; }

        public string EXAM_SESSION_ID { get; set; }
        public string EXAM_SESSION { get; set; }

        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
    }
}
