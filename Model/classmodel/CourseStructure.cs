using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class CourseStructure
    {
        public string COURSE_STRUCTURE_ID { get; set; }
        public string CREDIT { get; set; }
        public string PART_ID { get; set; }
        public string UGC_TYPE_ID { get; set; }
        public string UGC_COURSE_TYPE {get; set; }

        public string HRS_PER_WEEK { get; set; }
        public string MARKS { get; set; }
        public string SEMESTER_ID { get; set; }
        public string SEMESTER_NAME { get; set; }

        public string FACULTY_ID { get; set; }
        public string FACULTY_NAME { get; set; }

        public string PROGRAMME_LEVEL { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }

        public string PROGRAMME_YEAR_ID { get; set; }
        public string PROGRAMME_YEAR { get; set; }

        public string ACADEMIC_YEAR { get; set; }
        public string IS_OPTIONAL { get; set; }
        public string IS_NME { get; set; }
        public string IS_ALLIED { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string CAMPUS_ID { get; set; }
        public string BATCH_ID { get; set; }
    }
}
