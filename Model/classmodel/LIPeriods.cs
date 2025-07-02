using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class LIPeriods
    {
        public string PERIOD_ID { get; set; }
        public string USER_TYPE_ID { get; set; }
        public string USER_TYPE_NAME { get; set; }
        public string ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string PROGRAMME_LEVEL { get; set; }
        public string SEM_BEGIN_DATE { get; set; }
        public string SEM_END_DATE { get; set; }
        public string SEMESTER_TYPE_ID { get; set; }
        public string SEMESTER_TYPE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_DELETED { get; set; }


    }
}
