using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class CandidateShortlistDTO
    {
        public string SHORTLIST_ID {  get; set; }
        public string APPLICATION_ID { get; set; }
        public string JOB_VACANCY_ID { get; set; }
        public string SHORTLIST_DATE { get; set; }
        public string INTERVIEW_SCHEDULED_DATE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
