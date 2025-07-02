using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class Department
    {
        public string DEPARTMENT_ID { get; set; }
        public string DEPARTMENT_CODE { get; set; }
        public string DEPARTMENT { get; set; }
        public string IS_DELETED { get; set; }
        public string DEPARTMENT_ORDER { get; set; }
        public string FACULTY { get; set; }
        public string FACULTY_ID { get; set; }

        public string YEAR_OF_PUBLISHMENT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string PG_ORDER { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CAMPUS_NAME { get; set; }
    }
}
