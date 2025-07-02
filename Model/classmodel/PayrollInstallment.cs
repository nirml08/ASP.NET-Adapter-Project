using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class PayrollInstallment
    {
        public string INSTALLMENT_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string ADVANCE_ACCOUNT_ID { get; set; }
        public string INSTALLMENT_AMOUNT { get; set; }
        public string INSTALLMENT_DATE { get; set; }
        public string IS_DEDUCTED { get; set; }
        public string DEDUCTED_AT { get; set; }
        public string REMARKS { get; set; }
        public string CREATED_AT { get; set; }
        public string UPDATED_AT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
