using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StaffBankAccountDTO
    {
        public string STF_ACCOUNT_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string BANK_ID { get; set; }
        public string PASSBOOK_NO { get; set; }
        public string IFSC_CODE { get; set; }
        public string STARTED_DATE { get; set; }
        public string CLOSED_DATE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CREATEDAT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
