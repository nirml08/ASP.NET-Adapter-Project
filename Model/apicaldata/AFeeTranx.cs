using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{
    public class FeeTranx
    {
        public int TRANSACTION_ID { get; set; }
        public string STUDENT_ID { get; set; } = string.Empty;
        public int FREQUENCY { get; set; }
        public int CLASS { get; set; }
        public DateTime? PAYMENT_DATE { get; set; }
        public string? RECEIPT_NO { get; set; }
        public int PAYMENT_MODE { get; set; }
        public int? DD_CHEQUE_NO { get; set; }
        public double COLLECTED { get; set; } = 0;
        public double? DISCOUNT { get; set; }
        public int? DEDUCT_STUDENT_ACCOUNT { get; set; }
        public string RECEIPT_NARRATION { get; set; } = string.Empty;
        public string USERNAME { get; set; } = string.Empty;
        public int ACADEMIC_YEAR { get; set; }
        public int IS_DELETED { get; set; }
        public int IS_AMOUNT_COLLECTED { get; set; }
        public int IS_ACCOUNTANT_COLLECTED { get; set; }
        public int IS_ADVANCE { get; set; }
        public int UPLOAD_FLAG { get; set; }
        public int IS_DOWNLOADED { get; set; }
        public int IS_UPDATED { get; set; }
        public DateTime? DOWNLOAD_TIME { get; set; }
        public int FEE_TRANSACTION_COUNTER { get; set; }
        public int FEE_TRANSACTION_BANK { get; set; }
        public uint TEMP_ID { get; set; } // Note: Use uint if truly unsigned
        public double EXCESS_AMT { get; set; }
        public int F_TRANSACTION_ID { get; set; }
        public int FREQUENCY_TO { get; set; }
        public string CHALLAN_NO { get; set; } = string.Empty;
        public int? PayUResponse_Id { get; set; }
        public int? RAZORPAY_ID { get; set; }
        public string? RECEIPT_NO1 { get; set; } = string.Empty;
        public string? RECEIPT_NO2 { get; set; } = string.Empty;
        public string? EASEPAYID { get; set; } = string.Empty;
    }

}
