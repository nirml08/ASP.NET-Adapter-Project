using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class HRProfessionalActivities
    {
        public string HR_PROFESSIONAL_DEVELOPMENT_ACTIVITIES_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string STAFF_NAME { get; set; }
        public string ACADEMIC_SESSION_ID { get; set; }
        public string ACADEMIC_SESSION_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string TOTAL_HOURS { get; set; }
        public string ACTUAL_SCORE { get; set; }
        public string API_SCORE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
