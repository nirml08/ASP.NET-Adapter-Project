using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class FeeSalaryTransfer
    {
        public string TRANSACTION_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string BATCH_ID { get; set; }
        public string BENEFICIARY_NAME { get; set; }
        public string BENEFICIARY_ACCOUNT_NUMBER { get; set; }
        public string BENEFICIARY_IFSC { get; set; }
        public string AMOUNT { get; set; }
        public string TRANSFER_MODE { get; set; }
        public string STATUS { get; set; }
        public string REMARKS { get; set; }
        public string CREATED_AT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
