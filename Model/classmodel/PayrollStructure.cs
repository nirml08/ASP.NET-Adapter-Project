using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class PayrollStructure
    {
        public string PAYROLL_STRUCTURE_ID { get; set; }
        public string PAYROLL_HEAD_ID { get; set; }
        public string PAYROLL_HEAD_CODE { get; set; }
        public string PAYROLL_HEAD { get; set; }
        public string RANGE_FROM { get; set; }
        public string RANGE_TO { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        //
        public string STAFF_ID { get; set; }
        public string FORMULA { get; set; }
        public string IS_FLAT_AMT { get; set; }
        public string PAYROLL_ORDER { get; set; }
        public string PAYROLL_HEAD_TYPE_ID { get; set; }
        public string HEAD_TYPE { get; set; }
        public string PAYROLL_LOG_ID { get; set; }
        public string TRANSACTION_MONTH { get; set; }
        public string TRANSACTION_DATE { get; set; }
        public string AMOUNT { get; set; }

    }
}
