using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class PayrollLog
    {
        public string PAYROLL_LOG_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string FULL_NAME { get; set; }
        public string PAYROLL_HEAD_ID { get; set; }
        public string PAYROLL_HEAD_NAME { get; set; }
        public string TRANSACTION_MONTH { get; set; }
        public string TRANSACTION_DATE { get; set; }
        public string AMOUNT { get; set; }
        public string CREATED_AT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string USER_CODE { get; set; }
        public string POSITION { get; set; }
        public string PAYROLL_HEAD_TYPE_ID { get; set; }
        public string HEAD_TYPE { get; set; }
        public string INSTALLMENT_ID { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string PAYROLL_HEAD_CODE { get; set; }
    }
}
