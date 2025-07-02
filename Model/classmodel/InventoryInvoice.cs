using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class InventoryInvoice
    {
        public string INVOICE_ID{get;set;}
        public string INVOICE_NO{get;set;}
        public string INVOICE_DATE{get;set;}
        public string PRODUCT_ID{get;set;}
        public string CATEGORY_ID{get;set;}
        public string STOCK{get;set;}
        public string GRAND_TOTAL{get;set;}
        public string DESCRIPTION{get;set;}
        public string LABORATORY{get;set;}
        public string DEPARTMENT{get;set;}
        public string DISCOUNT{get;set;}
        public string PAID_STATUS{get;set;}
        public string CAMPUS_ID{get;set;}
        public string ACADEMIC_YEAR{get;set;}
        public string STATUS{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
