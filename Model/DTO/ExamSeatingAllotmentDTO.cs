using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ExamSeatingAllotmentDTO
    {
        public string SEATING_ALLOTEMENT_ID { get; set; }
        public string SEATING_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string EXAM_DATE { get; set; }
        public string EXAM_SESSION_ID { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string EXAM_TYPE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
