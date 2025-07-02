using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class InventoryOrderRequestDTO
    {
        public string ORDER_REQUEST_ID { get; set; }
        public string PRODUCT_ID { get; set; }
        public string CATEGORY_ID { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string ORDER_QUANTITY { get; set; }
        public string UNIT { get; set; }
        public string REQUEST_STAFF_ID { get; set; }
        public string INVENTORY_CLERK_APPORVAL { get; set; }
        public string PRINCIPAL_APPROVAL { get; set; }
        public string STATUS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string REQUEST_DATE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
    }
}
