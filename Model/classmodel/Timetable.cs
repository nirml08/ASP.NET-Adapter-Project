using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class Timetable
    {
        public string TIME_TABLE_ID { get; set;}
        public string COURSE_ID { get; set;}
        public string COURSE_CODE { get; set;}
        public string COURSE_TITLE { get; set;}
        public string DAY_ORDER_ID { get; set;}
        public string DAY {get;set;}
        public string STAFF_ID {get; set;}
        public string FIRST_NAME { get; set; }

        public string STAFF_CODE { get; set;}
       
        public string CLASS_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string HOUR_ID { get; set; }
        public string HOUR { get; set; }

        public string SEMESTER_ID { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string HOUR_TYPE_ID { get; set; }
        public string HOUR_TYPE { get; set; }
        public string ACADEMIC_YEAR { get; set;}
        public string CAMPUS_ID { get; set; }
        public string CAMPUS_NAME { get; set;}
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string USER_TYPE { get; set; }
        public string SEMESTER_TYPE_ID { get; set;}
    }

}
