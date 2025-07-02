using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class Degree
    {
        public string DEGREE_ID { get; set; }
        public string DEGREE { get; set; }
        public string PROGRAMME_LEVEL { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }

        public string DEGREE_ORDER { get; set; }
        public string FACULTY { get; set; }
        public string FACULTY_ID { get; set; }

        public string PREFIX { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CAMPUS_NAME { get;set; }
        public string IS_DELETED { get; set; }
    }
}
