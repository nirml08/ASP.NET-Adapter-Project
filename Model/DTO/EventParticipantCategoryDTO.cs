using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class EventParticipantCategoryDTO
    {
        public string CATEGORY_ID { get; set; }
        public string EVENT_ID { get; set; }
        public string CATEGORY { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
