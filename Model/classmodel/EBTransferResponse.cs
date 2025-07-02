using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class EBTransferResponse
    {
        public string txnid { get; set; }
        public double amount { get; set; }
        public string Status { get; set; }
        public string key { get; set; }
        public string firstname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string productinfo { get; set; }
        public string surl { get; set; }
        public string furl { get; set; }
        public string salt { get; set; }
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
        public string mode { get; set; }
        public string unmappedstatus { get; set; }
        public string cardCategory { get; set; }
        public string addedon { get; set; }
        public string payment_source { get; set; }
        public string PG_TYPE { get; set; }
        public string bank_ref_num { get; set; }
        public string bankcode { get; set; }
        public string error { get; set; }
        public string error_Message { get; set; }
        public string name_on_card { get; set; }
        public string upi_va { get; set; }
        public string cardnum { get; set; }
        public string issuing_bank { get; set; }
        public string easepayid { get; set; }
        public string net_amount_debit { get; set; }
        public string cash_back_percentage { get; set; }
        public string deduction_percentage { get; set; }
        public string merchant_logo { get; set; }
        public string card_type { get; set; }
        public string hash { get; set; }
        public string status { get; set; }
        public string bank_name { get; set; }
        public string EB_TRANSFER_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string FREQUENCY_ID { get; set; }
    }

    public class EasebuzzTransfer
    {
        public List<payouts_history_data> payouts_history_data { get; set; }

        public EBTransferResponse msg { get; set; }
        public bool status { get; set; }

    }

    public class payouts_history_data
    {
        public bool paid_out { get; set; }
        public DateTime payout_actual_date { get; set; }
        public decimal payout_amount { get; set; }
        public string payout_id { get; set; }
        public List<object> peb_refunds { get; set; }
        public string bank_name { get; set; }
        public string account_number { get; set; }
        public decimal service_charge_amount { get; set; }
        public string bank_transaction_id { get; set; }
        public List<peb_transactions> peb_transactions { get; set; }
        public List<split_payouts> split_payouts { get; set; }
    }

    public class peb_transactions
    {
        public string peb_transaction_id { get; set; }
        public decimal Amount { get; set; }
        public decimal peb_service_charge { get; set; }
        public decimal peb_service_tax { get; set; }
        public decimal peb_settlement_amount { get; set; }
        public string transaction_type { get; set; }
        public object submerchant_id { get; set; }
        public List<split_transactions> split_transactions { get; set; }
        public string status { get; set; }
        public string txnid { get; set; }
        public string udf1 { get; set; }
        public string udf2 { get; set; }
        public string udf3 { get; set; }
        public string udf4 { get; set; }
        public string udf5 { get; set; }
    }

    public class split_transactions
    {
        public decimal amount { get; set; }
        public decimal service_charge { get; set; }
        public decimal service_tax { get; set; }
        public decimal split_payout_percentage { get; set; }
        public string label { get; set; }
    }

    public class split_payouts
    {
        public string split_payout_id { get; set; }
        public DateTime payout_date { get; set; }
        public string account_number { get; set; }
        public string account_label { get; set; }
        public string bank_name { get; set; }
        public bool paid_out { get; set; }
        public decimal payout_amount { get; set; }
        public string bank_transaction_id { get; set; }
    }
}
