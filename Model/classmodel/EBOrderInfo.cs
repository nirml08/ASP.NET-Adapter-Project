using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class EBOrderInfo
    {
        public string EB_ORDER_ID { get; set; }
        public string ID { get; set; }
        public string ENTITY { get; set; }
        public string AMOUNT { get; set; }
        public string AMOUNT_PAID { get; set; }
        public string AMOUNT_DUE { get; set; }
        public string CURRENCY { get; set; }
        public string RECEIPT { get; set; }
        public string OFFER_ID { get; set; }
        public string STATUS { get; set; }
        public string ATTEMPTS { get; set; }
        public string CREATED_AT { get; set; }
        public string UDF1 { get; set; }
        public string UDF2 { get; set; }
        public string UDF3 { get; set; }
        public string UDF4 { get; set; }
        public string UDF5 { get; set; }
        public string UDF6 { get; set; }
        public string UDF7 { get; set; }
        public string UDF8 { get; set; }

        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string PAY_URL { get; set; }
        public string ACADEMIC_YEAR { get; set; }
    }
}
