using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class EventReportApprovalDTO
    {
        public string REPORT_APPROVAL_ID { get; set; }
        public string EVENT_ID { get; set; }
        public string REQUEST_FROM { get; set; }
        public string REQUEST_TO { get; set; }
        public string ROLE_ID { get; set; }
        public string REMARK { get; set; }
        public string APPROVAL_STATUS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
