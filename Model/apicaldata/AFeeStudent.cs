using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{
    public class FeeStdAccount
    {
        public int STUDENT_AC_ID { get; set; }
        public int STUDENT_ID { get; set; }
        public int? ACADEMIC_YEAR { get; set; }
        public int? FREQUENCY_ID { get; set; }
        public int? HEAD { get; set; }
        public double? CREDIT { get; set; }
        public double? DEBIT { get; set; }
        public DateTime? TRANSACTION_DATE { get; set; }
        public int? DISCOUNT_ID { get; set; }
        public int? STU_DISCOUNT_ID { get; set; }
        public int? IS_DELETED { get; set; }
        public int? TRANSACTION_ID { get; set; }
        public int BANK { get; set; }
        public int IS_REFUND { get; set; }
        public int SPONSOR_ID { get; set; }
        public int F_STUDENT_AC_ID { get; set; }
        public DateTime? FINE_DATE { get; set; }
        public uint IS_CANCELLED_HEAD { get; set; }
        public int? FEE_MAIN_HEAD_ID { get; set; }
        public int? INSTALLMENT_ID { get; set; }
        public string? REASON { get; set; }
        public int? FEE_STRUCTURE_ID { get; set; }
    }



}
