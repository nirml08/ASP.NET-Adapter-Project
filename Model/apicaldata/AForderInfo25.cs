using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{
    public class ForderInfo25
    {
        public int? EB_ORDER_ID { get; set; }
        public string? ID { get; set; }
        public string? ENTITY { get; set; } = "Order";
        public decimal? AMOUNT { get; set; }
        public decimal? AMOUNT_PAID { get; set; }
        public decimal? AMOUNT_DUE { get; set; }
        public string? CURRENCY { get; set; } = "INR";
        public string? RECEIPT { get; set; } = "";
        public string? OFFER_ID { get; set; } = "";
        public string? STATUS { get; set; } = "created";
        public int? ATTEMPTS { get; set; }
        public DateTime CREATED_AT { get; set; }
        public string UDF1 { get; set; }
        public string UDF2 { get; set; } //note 2 is for the semester admission fees
        public string UDF3 { get; set; }
        public string UDF4 { get; set; }
        public string UDF5 { get; set; }
        public string UDF6 { get; set; }
        public string UDF7 { get; set; } = "2025";
        public int IS_ACTIVE { get; set; } = 0;
        public int IS_DELETED { get; set; } = 0;
        public string PAY_URL { get; set; } = "";
        public int IS_PROCESSED { get; set; } = 0;
    }
}
