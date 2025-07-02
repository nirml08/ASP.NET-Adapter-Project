using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class LICheckInInfoDTO
    {
        public string CHECKIN_ID { get; set; }
        public string USER_ID { get; set; }
        public string USER_TYPE_ID { get; set; }
        public string ROLE_ID { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string CHECKIN_DATE { get; set; }
        public string IS_CHECKOUT { get; set; }
        public string CHECKOUT_DATE { get; set; }
        public string IS_SYSTEM_CHECKOUT { get; set; }
        public string SEMESTER_ID { get; set; }
        public string SEMESTER_TYPE_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
