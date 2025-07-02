using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class InventoryRepairRequestDTO
    {
        public string REPAIR_REQUEST_ID { get; set; }
        public string PRODUCT_ID { get; set; }
        public string CATEGORY_ID { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string REQUEST_DATE { get; set; }
        public string REQUEST_STAFF_ID { get; set; }
        public string INVENTORY_CLERK_APPORVAL { get; set; }
        public string PRINCIPAL_APPROVAL { get; set; }
        public string STATUS { get; set; }
        public string SOLVED_DATE { get; set; }
        public string TECHNICIAN_OR_COMPANY_NAME { get; set; }
        public string PAID_AMOUNT { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
