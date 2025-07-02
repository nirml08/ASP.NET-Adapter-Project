using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AccountPaymentResponse
    {
        public string transfer_id { get; set; }
        public string easebuzz_txn_id { get; set; }
        public string sender_account_id { get; set; }
        public string transfer_amount { get; set; }
        public string currency { get; set; }
        public string transaction_date { get; set; }
        public string status { get; set; }
        public string easebuzz_response { get; set; }
        public string remarks { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}
