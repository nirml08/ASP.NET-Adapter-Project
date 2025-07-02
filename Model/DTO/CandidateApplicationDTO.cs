using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class CandidateApplicationDTO
    {
        public string APPLICATION_ID { get; set; }
        public string JOB_VACANCY_ID { get; set; }
        public string CANDIDATE_NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string QUALIFICATIONS { get; set; }
        public string EXPERIENCE { get; set; }
        public string RESUME_PATH { get; set; }
        public string COVER_LETTER_PATH { get; set; }
        public string APPLIED_DATE { get; set; }
        public string FR_STATUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
      
    }
}
