using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class StudentClass
    {
        public string ?  STU_CLASS_ID { get; set; }
        public string ? STUDENT_ID { get; set; }
        public string ? USER_CODE { get; set; }
        public string ? ROLL_NO { get; set; }
        public string ? FULL_NAME { get; set; }
        public string? MAIL_ID { get; set; }  //ADDED
        public string ? FIRST_NAME { get; set; }
        public string ? LAST_NAME { get; set; }
                      
        public string ? ACADEMIC_YEAR { get; set; }
        public string ? CLASS_ID { get; set; }
        public string ? CLASS_NAME { get; set; }
                      
        public string ? PROGRAMME_GROUP_ID { get; set; }
        public string ? PROGRAMME_NAME { get; set; }
        public string ? BATCH_ID { get; set; }
        public string ? BATCH { get; set; }
        public string ? CAMPUS_ID { get; set; }
        public string ? CAMPUS_NAME { get; set; }
        public string ? SHIFT { get; set; }
        public string ? IS_DELETED { get; set; }
    }                 
}
