using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class MentorApprisalSpecialApptitudeDTO
    {
        public string MENTOR_SPECIAL_APTITUDE_ID { get; set; }
        public string APPRISAL_SETTING_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string NOMINEE_ID { get; set; }
        public string PEER_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string SPECIAL_APTITUDE { get; set; }
        public string CREATED_AT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
