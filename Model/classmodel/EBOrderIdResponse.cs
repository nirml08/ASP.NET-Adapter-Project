using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class EBOrderIdResponse
    {
        public string txnid { get; set; }
        public string entity { get; set; }
        public double amount { get; set; }
        public string amount_paid { get; set; }
        public string amount_due { get; set; }
        public string currency { get; set; }
        public string receipt { get; set; }
        public string offer_id { get; set; }
        public string status { get; set; }
        public string attempts { get; set; }
        public Notes notes = new Notes();
        public string created_at { get; set; }
        public string key { get; set; }
        public string secret { get; set; }
        public string firstname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string productinfo { get; set; }
        public string surl { get; set; }
        public string furl { get; set; }
        public string salt { get; set; }
        public Dictionary<string, double> split { get; set; }
        public string split_payments { get; set; }
        public string udf1 { get; set; }
        public string udf2 { get; set; }
        public string udf3 { get; set; }
        public string udf4 { get; set; }
        public string udf5 { get; set; }
        public string udf6 { get; set; }
        public string udf7 { get; set; }
        public string udf8 { get; set; }
        public string udf9 { get; set; }
        public string udf10 { get; set; }
        public string sub_merchant_id { get; set; }
        public string Status { get; set; }
        public string response { get; set; }
        public string error_Message { get; set; }
        public string STR_RESPONSE { get; set; }
        public string easepayid { get; set; }
        public string ACADEMIC_YEAR { get; set; }
    }
}
