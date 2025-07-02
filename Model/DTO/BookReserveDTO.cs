using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class BookReserveDTO
    {
        public string RESERVE_ID { get; set; }
        public string USER_ID { get; set; }
        public string USER_TYPE_ID { get; set; }
        public string ROLE_ID { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string BOOK_ID { get; set; }
        public string REASON { get; set; }
        public string ENTRY_DATE { get; set; }
        public string APPROVED_DATE { get; set; }
        public string APPROVED_BY { get; set; }
        public string IS_APPROVED { get; set; }
        public string IS_COLLECTED { get; set; }
        public string COLLECTED_DATE { get; set; }
        public string IS_CANCELLED { get; set; }
        public string CANCELLED_DATE { get; set; }
        public string CANCELLED_BY { get; set; }
        public string SEMESTER_ID { get; set; }
        public string SEMESTER_TYPE_ID { get; set; }
        public string CANCEL_REASON { get; set; }
        public string IS_USER_CANCELLED { get; set; }
        public string IS_SYSTEM_CANCELLED { get; set; }
        public string RESERVE_STATUS_ID { get; set; }
        public string IS_CSMS_SENT { get; set; }
        public string IS_ASMS_SENT { get; set; }
        public string COLLECTED_BY { get; set; }
        public string IS_SCSMS_SENT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
