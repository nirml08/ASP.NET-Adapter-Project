using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class Programme
    {
        public string PROGRAMME_ID { get; set; }
        public string PROGRAMME_CODE { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string PROGRAMME_DESCRIPTION { get; set; }
        public string DEPARTMENT { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string DEGREE_ID { get; set; }

        public string DEGREE { get; set; }
        public string FACULTY_ID { get; set; }

        public string FACULTY { get; set; }
        public string PROGRAMME_ORDER { get; set; }
        public string DURATION { get; set; }
        public string DURATION_UNIT { get; set; }
        public string NO_OF_SEMESTER { get; set; }
        public string CHANNEL { get; set; }
        public string IS_AIDED { get; set; }
        public string IS_DELETED { get; set; }
        public string PRO_SERIES_ROLLNO { get; set; }
        public string IS_REGULAR { get; set; }
        public string PRO_SERIES_REGNO { get; set; }
        public string PRO_SERIES_ADMNO { get; set; }
        public string MEDIUM_OF_INSTRACTION { get; set; }
        public string COURSE { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
