using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class FRJobVacancyDTO
    {
        public string JOB_VACANCY_ID { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string MIN_QUALIFICATION { get; set; }
        public string EXPERIENCE_REQUIRED { get; set; }
        public string JOB_DESCRIPTION { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string POST_DATE { get; set; }
        public string APPLICATION_DEADLINE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CREATED_AT { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
