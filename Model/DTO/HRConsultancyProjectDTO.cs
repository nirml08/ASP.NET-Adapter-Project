using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class HRConsultancyProjectDTO
    {
        public string HR_CONSULTANCY_PROJECT_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string PROJECT_TITLE { get; set; }
        public string FUNDING_AGENCY { get; set; }
        public string DURATION { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string TOTAL_BUDGET { get; set; }
        public string OBJECTIVE { get; set; }
        public string CREATED_AT { get; set; }
        public string UPDATED_AT { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
