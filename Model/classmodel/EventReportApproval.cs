using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class EventReportApproval : IQACEvents
    {
        public string REPORT_APPROVAL_ID { get; set; }
        public string EVENT_ID { get; set; }
        public string REQUEST_FROM { get; set; }
        public string FIRST_NAME { get; set; }
        public string REQUEST_TO { get; set; }
        public string ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string REMARK { get; set; }
        public string APPROVAL_STATUS { get; set; }
        public string APPROVAL_STATUS_NAME { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string EVENT_NAME { get; set; }
        public string EVENT_DATE { get; set; }
        public string REQUESTED_FROM_NAME { get; set; }
        public string PROFESSIONAL_ADMINISTRATIVE_TRAINING_ID { get; set; }
        public string REQUESTED_TO_NAME { get; set; }
        public string REQUEST_DATE { get; set; }
    }
}
