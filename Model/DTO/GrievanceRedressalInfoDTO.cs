using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class GrievanceRedressalInfoDTO
    {
        public string REDRESSAL_ID { get; set; }
        public string GRIEVANCE_ID { get; set; }
        public string REDRESSAL_CONTENT { get; set; }
        public string FILE_PATH { get; set; }
        public string ENTRY_ID { get; set; }
        public string REP_DATE_TIME { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
