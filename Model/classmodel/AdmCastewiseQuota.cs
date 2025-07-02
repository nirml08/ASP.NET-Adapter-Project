using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{

    public class AdmMaximuminTakes
    {
        public string ? INTAKE_ID { get; set; }
        public string ? DEPARTMENT_ID { get; set; }
        public string ? DEPARTMENT { get; set; }
        public string ? PROGRAMME_ID { get; set; }
        public string ? SHIFT { get; set; }
        public string ? SHIFT_NAME { get; set; }
        public string ? NO_OF_SEATS { get; set; }
        public string ? IS_DELETED { get; set; }
        public string ? ACADEMIC_YEAR { get; set; }
        public string ? CQ_SEATS { get; set; }
        public string ? PROGRAMME_CODE { get; set; }
        public string ? PROGRAMME_NAME { get; set; }
        public string ? MINORITY { get; set; }
    }

    public class AdmCastewiseQuota : AdmMaximuminTakes
    {
        public string ? CASTEWISE_QUATA_ID { get; set; }
        public string ? CASTE_ID { get; set; }
        public string ? COMMUNITY { get; set; }
        public string ? INTAKE_ID { get; set; }
        public string ? NO_OF_SEATS { get; set; }
        public string ? CAMPUS_ID { get; set; }
        public string ? IS_ACTIVE { get; set; }
        public string ? IS_DELETED { get; set; }
        public string ? ACADEMIC_YEAR { get; set; }
        public string ? SELECTED { get; set; }
        public string ? VERIFIED { get; set; }
        public string ? ADMITTED { get; set; }
    }

    public class MainCommunity
    {
        public string ? MAIN_COMMUNITY_ID { get; set; }
        public string ? MAIN_COMMUNITY { get; set; }
        public string ? CAMPUS_ID { get; set; }
        public string ? IS_ACTIVE { get; set; }
        public string ? IS_DELETED { get; set; }
    }

}
