using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class LIBookIssueDTO
    {
        public string ISSUE_ID { get; set; }
        public string USER_ID { get; set; }
        public string USER_TYPE_ID { get; set; }
        public string ROLE_ID { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string BOOK_ID { get; set; }
        public string ISSUE_DATE { get; set; }
        public string ISSUE_BY { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_SMS_SENT { get; set; }
        public string IS_RENEWED { get; set; }
        public string ACTUAL_RETURNED_DATE { get; set; }
        public string IS_RETURNED { get; set; }
        public string RECEIVED_BY { get; set; }
        public string IS_MODE { get; set; }
        public string RETURN_DATE { get; set; }
        public string SEMESTER_ID { get; set; }
        public string SEMESTER_TYPE_ID { get; set; }
        public string IS_DAMAGED { get; set; }
        public string IS_MISSED { get; set; }
        public string IS_RETURN_CONFIRMED { get; set; }
        public string IS_RCSMS_SENT { get; set; }
        public string IS_DSMS_SENT { get; set; }
        public string DSMS_SENT_DATE { get; set; }
        public string IS_MSMS_SENT { get; set; }
        public string MSMS_SENT_DATE { get; set; }
        public string AMOUNT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string BOOK_ISSUE_STATUS_ID { get; set; }
    }
}
