using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{
    public class AFebTfResponse25
    {
        public int EB_TRANSFER_ID { get; set; }
        public string ORDER_ID { get; set; } = "";
        public decimal? AMOUNT { get; set; }
        public string EMAIL { get; set; } = "payments@salesiancollege.net";
        public string PHONE { get; set; } = "9002145120";
        public string? STATUS { get; set; } = null;
        public string? easepayid { get; set; }
        public string STR_RESPONSE { get; set; } = "Campus360.Domain.Modal.PaymentResponse";
        public string? RESPONSE { get; set; } // Use string to hold JSON; can be parsed later if needed
        public DateTime CREATED_AT { get; set; }
        public DateTime? SETTLEMENT_DATE { get; set; } // Nullable in case it's not yet settled

        public string? UDF1 { get; set; }
        public string? UDF2 { get; set; }
        public string? UDF3 { get; set; }
        public string? UDF4 { get; set; }
        public string? UDF5 { get; set; }
        public string? UDF6 { get; set; }

        public int IS_ACTIVE { get; set; } = 0;
        public int IS_DELETED { get; set; } = 0;
    }

}
