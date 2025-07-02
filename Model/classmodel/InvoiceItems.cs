using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class InvoiceItems
    {
        public string ITEM_ID { get; set; }
        public string INVOICE_ID { get; set; }
        public string UNIT { get; set; }
        public string UNIT_PRICE { get; set; }
        public string TOTAL_PRICE { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
