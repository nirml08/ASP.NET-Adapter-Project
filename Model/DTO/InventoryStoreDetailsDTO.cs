using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class InventoryStoreDetailsDTO
    {
        public string STORE_ID { get; set; }
        public string STORE_NAME { get; set; }
        public string PRODUCT_ID { get; set; }
        public string SUPPLIER_ID { get; set; }
        public string STOCK_QTY { get; set; }
        public string UNIT_ID { get; set; }
        public string STORED_DATE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
