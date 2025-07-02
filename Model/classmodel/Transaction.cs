using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace adapter.Model.classmodel
{
    public class Transaction
    {
        [Name("Easebuzz ID")]
        public string EasebuzzID { get; set; }

        [Name("Amount")]
        public string Amount { get; set; }

        [Name("Transaction status")]
        public string TransactionStatus { get; set; }

        [Name("Transaction Ref Number")]
        public string TransactionRefNumber { get; set; }

        [Name("Customer Name")]
        public string CustomerName { get; set; }

        [Name("Error Message")]
        public string ErrorMessage { get; set; }

        [Name("Submerchant ID")]
        public string SubmerchantID { get; set; }

        [Name("Customer Email")]
        public string CustomerEmail { get; set; }

        [Name("Customer Phone")]
        public string CustomerPhone { get; set; }

        [Name("Date of Transaction")]
        public string DateOfTransaction { get; set; }

        [Name("Merchant Transaction ID")]
        public string MerchantTransactionID { get; set; }
        [Name("Submerchant Name")]
        public string SubmerchantName { get; set; }
        [Name("Submerchant Email")]
        public string SubmerchantEmail { get; set; }
        [Name("Transaction Type")]
        public string TransactionType { get; set; }
        public string UDF1 { get; set; }
        public string UDF2 { get; set; }
        public string UDF3 { get; set; }
        public string UDF4 { get; set; }
    }
}
