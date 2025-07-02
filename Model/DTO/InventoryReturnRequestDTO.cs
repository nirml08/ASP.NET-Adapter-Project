using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class InventoryReturnRequestDTO
    {
        public string RETURN_REQUEST_ID { get; set; }
        public string ORDER_REQUEST_ID { get; set; }
        public string PRODUCT_ID { get; set; }
        public string CATEGORY_ID { get; set; }
        public string UNIT { get; set; }
        public string RETURN_QTY { get; set; }
        public string FACULTY_ID { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
