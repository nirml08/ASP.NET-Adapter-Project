using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class HRResearchGuidanceDTO
    {
        public string HR_RESEARCH_GUIDANCE_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string RESEARCH_TITLE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string STATUS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
    }
}
