using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class PayrollAdvanceAccount
    {
        public string ADVANCE_ACCOUNT_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string ADVANCE_DATE { get; set; }
        public string ADVANCE_AMOUNT { get; set; }
        public string DEDUCTION_DATE { get; set; }
        public string DEDUCTION_AMOUNT { get; set; }
        public string NO_OF_INSTALLEMT { get; set; }
        public string IS_DEDUCTED { get; set; }
        public string CREATED_AT { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        // 
        public string INSTALLMENT_ID { get; set; }
        public string INSTALLMENT_AMOUNT { get; set; }
        public string INSTALLMENT_DATE { get; set; }
        public string IS_PAID { get; set; }
        public string DEDUCTED_AT { get; set; }
        public string REMARKS { get; set; }
        public string INSTALLMENT_CREATED_AT { get; set; }
        public string INSTALLMENT_UPDATED_AT { get; set; }

    }
}
