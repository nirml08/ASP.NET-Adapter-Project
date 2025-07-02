using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class MentorStudentInterventionAreasDTO
    {
        public string STUDENT_INTERVENTION_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string AREA_DESCRIPTION { get; set; }
        public string VISIT_DATE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
