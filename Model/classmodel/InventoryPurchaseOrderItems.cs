using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class InventoryPurchaseOrderItems
    {
        public string PURCHASE_ORDER_ITEM_ID{get;set;}
        public string PURCHASE_ORDER_ID { get;set;}
        public string PRODUCT_ID{get;set;}
        public string PRODUCT_CODE { get;set;}
        public string PRODUCT_NAME { get;set;}
        public string CATEGORY_ID{get;set;}
        public string CATEGORY_NAME { get;set;}
        public string QTY{get;set;}
        public string UNIT_PRICE{get;set;}
        public string DESCRIPTION{get;set;}
        public string TOTAL_PRICE{get;set;}
        public string CAMPUS_ID{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
