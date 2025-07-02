using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class InventoryPurchaseReturnItems
    {
        public string PURCHASE_RETURN_ITEM_ID{get;set;}
        public string PURCHASE_RETURN_ID{get;set;}
        public string PRODUCT_ID{get;set;}
        public string PRODUCT_NAME { get;set;}
        public string PRODUCT_CODE{get;set;}
        public string CATEGORY_ID { get;set;}
        public string CATEGORY_NAME { get;set;}
        public string RETURN_QTY{get;set;}
        public string UNIT_PRICE{get;set;}
        public string DESCRIPTION{get;set;}
        public string TOTAL_PRICE{get;set;}
        public string CAMPUS_ID{get;set;}
        public string ACADEMIC_YEAR{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
