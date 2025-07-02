using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ExamSeatingInvigilatorDTO
    {
        public string SEATING_INVIGILATOR_ID { get; set; }
        public string ROOM_ID { get; set; }
        public string STAFF_ID { get; set; }
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
