using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class LIRuleDTO
    {
        public string RULE_ID { get; set; }
        public string USER_TYPE_ID { get; set; }
        public string ROLE_ID { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string NO_OF_BOOKS { get; set; }
        public string NO_OF_DAYS { get; set; }
        public string NO_OF_RENEW_DAYS { get; set; }
        public string PER_DAY_DUE_COST { get; set; }
        public string REVISED_DUE_DATES { get; set; }
        public string REVISED_DUE_COST { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }

    }
}
