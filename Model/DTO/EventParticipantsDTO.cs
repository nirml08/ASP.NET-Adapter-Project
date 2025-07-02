using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class EventParticipantsDTO
    {
        public string PARTICIPANT_ID { get; set; }
        public string EVENT_ID { get; set; }
        public string ROLE_ID { get; set; }
        public string REGISTRATION_ID { get; set; }
        public string USER_ID { get; set; }
        public string CATEGORY_ID { get; set; }
        public string IS_INTERCOLLEGE { get; set; }
        public string IS_INTRACOLLEGE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
