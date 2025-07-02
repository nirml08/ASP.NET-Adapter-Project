using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class PayrollHeadsDTO
    {
        public string PAYROLL_HEAD_ID { get; set; }
        public string PAYROLL_HEAD_CODE { get; set; }
        public string PAYROLL_HEAD_NAME { get; set; }
        public string FORMULA { get; set; }
        public string IS_FLAT_AMT { get; set; }
        public string PAYROLL_HEAD_TYPE_ID { get; set; }
        public string PAYROLL_ORDER { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
