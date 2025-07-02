using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class InventoryPurchaseOrder: InventoryPurchaseOrderItems
    {
        public string PURCHASE_ORDER_ID{get;set;}
        public string PURCHASE_ORDER_NO{get;set;}
        public string SUPPLIER_ID{get;set;}
        public string NAME { get;set;}
        public string ADDRESS { get;set;}
        public string PURCHASE_DATE{get;set;}
        public string CAMPUS_ID{get;set;}
        public string APPROVAL_STATUS { get;set;}

        public string ACADEMIC_YEAR{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
        
        
    }
}
