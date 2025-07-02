using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class EventGroupMembersInfoDTO
    {
        public string GRP_MENMBER_ID { get; set; }
        public string GROUP_ID { get; set; }
        public string EVENT_ID { get; set; }
        public string REGISTRATION_ID { get; set; }
        public string ADDED_DATE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
