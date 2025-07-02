using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class HRDirectTeachingHours
    {
        public string DIRECT_TEACHING_HOUR_ID { get; set;}
        public string STAFF_ID { get; set; }
        public string STAFF_NAME { get; set; }
        public string USER_CODE { get; set; }
        public string ACADEMIC_SESSION_ID { get; set; }
        public string ACADEMIC_SESSION_NAME { get; set; }
        public string FROM_YEAR { get; set; }
        public string TO_YEAR { get; set; }
        public string MODE_OF_TEACHING_ID { get; set; }
        public string TEACHING_MODE_NAME { get; set; }
        public string TOTAL_HOURS { get; set; }
        public string SCORE { get; set; }
        public string API { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
