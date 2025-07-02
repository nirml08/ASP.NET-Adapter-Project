using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class InventoryPurchaseReturn: InventoryPurchaseReturnItems
    {
        public string PURCHASE_RETURN_ID{get;set;}
        public string PURCHASE_NO{get;set;}
        public string SUPPLIER_ID{get;set;}
        public string NAME { get;set;}
        public string ORDER_QTY{get;set;}
        public string ORDER_UNIT{get;set;}
        public string PURCHASE_RETURN_DATE{get;set;}
        public string CAMPUS_ID{get;set;}
        public string USER_ID{get;set;}
        public string ACADEMIC_YEAR{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
