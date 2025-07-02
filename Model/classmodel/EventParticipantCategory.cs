using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class EventParticipantCategory
    {
        public string CATEGORY_ID { get; set; }
        public string EVENT_ID { get; set; }
        public string EVENT_TITLE { get; set; }
        public string EVENT_START_DATE { get; set; }
        public string CATEGORY { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
