using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class BookRequisitionDTO
    {
        public string BOOK_REQUISITION_ID { get; set; }
        public string REQUESTED_BY_ID { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string PROGRAMME_ID { get; set; }
        public string BOOK_TITLE { get; set; }
        public string AUTHOR { get; set; }
        public string ISBN { get; set; }
        public string PUBLISHER { get; set; }
        public string EDITION { get; set; }
        public string QUANTITY { get; set; }
        public string PRICE_PER_UNIT { get; set; }
        public string TOTAL_PRICE { get; set; }
        public string REMARKS { get; set; }
        public string REQUISITION_DATE { get; set; }
        public string REQUISITION_STATUS_ID { get; set; }
        public string APPROVAL_DATE { get; set; }
        public string APPROVED_BY_ID { get; set; }
        public string ORDER_DATE { get; set; }
        public string DELIVERY_DATE { get; set; }
        public string DELIVERED_BY { get; set; }
        public string SUPPLIER_NAME { get; set; }
        public string INVOICE_PATH { get; set; }
        public string REQUESTED_DATE { get; set; }
        public string MODIFIED_BY_ID { get; set; }
        public string MODIFIED_DATE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
       
    }
}
