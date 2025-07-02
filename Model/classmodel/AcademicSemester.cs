using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AcademicSemester
    {
        public string ACC_SEMESTER_ID { get; set; }
        public string BATCH { get; set; }
        public string BATCH_ID { get; set; }

        public string PROGRAMME_GROUP_ID { get; set; }
        public string PROGRAMME_NAME { get; set; }

        public string SEMESTER_NAME { get; set; }
        public string SEMESTER_ID { get; set; }

        public string DATE_FROM { get; set; }
        public string DATE_TO { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CAMPUS_NAME { get; set; }

        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
