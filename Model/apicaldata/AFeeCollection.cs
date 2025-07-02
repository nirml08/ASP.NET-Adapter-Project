using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{
    public class FeeCollection
    {
        public int COLLECTION_ID { get; set; }
        public int? TRANSACTION_ID { get; set; }
        public int? HEAD { get; set; }
        public double? PAID_AMOUNT { get; set; }
        public int IS_DOWNLOADED { get; set; }
        public int IS_UPDATED { get; set; }
        public DateTime? DOWNLOAD_TIME { get; set; }
        public uint? FREQUENCY { get; set; }
        public string? RECEIPT_NO { get; set; }
        public int SORT_ORDER { get; set; }
        public int IS_DELETED { get; set; }
        public uint TEMP_ID { get; set; }
        public int? FEE_MAIN_HEAD_ID { get; set; }
        public string? SETTLEMENT_DATE { get; set; }
        public string? B_SETTLEMENT_DATE { get; set; }
        public int? FEE_RAZORPAY_TRANSFER_ID { get; set; }
        public int? FEE_RAZORPAY_SETTLEMENT_ID { get; set; }
    }


}
