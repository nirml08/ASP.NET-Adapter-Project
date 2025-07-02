using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class CoursePattern
    {
        public string COURSE_PATTERN_ID { get; set; }
        public string COURSE_STRUCTURE_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string PROGRAMME_NAME { get; set; }

        public string COURSE_ID { get; set; }
       
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }

        public string COURSE_ORDER { get; set; }
        public string IS_OPTIONAL { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string BATCH_ID { get; set; }
        public string BATCH { get; set; }

        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string PART { get; set; }
        public string PART_ID { get; set; }
        public string FACULTY_NAME { get; set; }
        public string FACULTY_ID { get; set; }


        public string CREDIT { get; set; }
        public string UGC_COURSE_TYPE { get; set; }
        public string UGC_COURSE_TYPE_ID { get; set; }


        public string PROGRAMME_LEVEL { get; set;}
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string SEMESTER_ID { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string PROGRAMME_YEAR_ID { get; set; }
        public string PROGRAMME_YEAR { get; set; }
    

    }
}
