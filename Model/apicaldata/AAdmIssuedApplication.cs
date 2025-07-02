using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{
    public class AdmIssuedApplication
    {
        public int? ISSUED_ID { get; set; }
        public string? APPLICATION_NO { get; set; }
        public string? DEPARTMENT_CODE { get; set; }
        public int? RECEIVE_ID { get; set; }
        public int? PROGRAMME_GROUP_ID { get; set; }
        public int? STATUS { get; set; }
        public int? SELECTION_TYPE { get; set; }
        public int? IS_ACTIVE { get; set; }
        public int? IS_DELETED { get; set; }
        public int? ACADEMIC_YEAR { get; set; }
        public int? IS_PAID { get; set; }
        public int? PAYMENT_MODE { get; set; }
        public string? RAZORPAY_ID { get; set; }
        public int? OLD_PROGRAMME_GROUP_ID { get; set; }
        public int? PRIORITY_ORDER { get; set; }
        public int? CAMPUS_ID { get; set; }
        public DateTime? APPLY_DATE { get; set; }
    }
}
