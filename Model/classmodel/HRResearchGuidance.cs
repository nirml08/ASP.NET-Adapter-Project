using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class HRResearchGuidance
    {

        public string HR_RESEARCH_GUIDANCE_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string STAFF_NAME { get; set; }
        public string STUDENT_NAME { get; set; }
        public string EVALUVATION_TYPE { get; set; }    
        public string EVALUVATION_TYPE_ID { get; set; }
        public string RESEARCH_TITLE { get; set; }
        public string NUMBER_OF_STUDENT_COUNT { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string STATUS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CREATED_AT { get; set; }
        public string UPDATED_AT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
