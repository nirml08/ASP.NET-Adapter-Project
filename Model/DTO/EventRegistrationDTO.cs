using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class EventRegistrationDTO
    {
        public string REGISTRATION_ID { get; set; }
        public string EVENT_ID { get; set; }
        public string FILE_PATH { get; set; }
        public string NAME { get; set; }
        public string MAIL_ID { get; set; }
        public string PHONE_NO { get; set; }
        public string COLLEGE_NAME { get; set; }
        public string COLLEGE_ID { get; set; }
        public string DEPARTMENT { get; set; }
        public string YEAR_OF_STUDY { get; set; }
        public string REGISTERED_DATE { get; set; }
        public string IS_INTERCOLLEGE { get; set; }
        public string IS_INTRACOLLEGE { get; set; }
        public string EVENT_CATEGORIES { get; set; }
        public string PARTCIPANT_TYPE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        // extra

        public string ROLE_ID { get; set; }
        public string USER_ID { get; set; }
        public string TEAM_ID { get; set; }
        public string TEAM_NAME { get; set; }
        public string NO_OF_COUNT { get; set; }
    }
}
