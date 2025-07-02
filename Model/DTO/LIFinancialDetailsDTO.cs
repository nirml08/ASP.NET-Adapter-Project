using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class LIFinancialDetailsDTO
    {
        public string FINANCIAL_ID { get; set; }
        public string AMOUNT { get; set; }
        public string PURCHASE_CATEGORY_ID { get; set; }
        public string TRANSACTION_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CREATED_AT { get; set; }
        public string UPDATED_AT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
