using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StudentCocurricularSurveyDTO
    {
        public string SERVEY_ID { get; set; }
        public string MAIN_CRITERIA_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string EVENT_ID { get; set; }
        public string QUESTION_ID { get; set; }
        public string RATING { get; set; }
        public string ENTRY_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
