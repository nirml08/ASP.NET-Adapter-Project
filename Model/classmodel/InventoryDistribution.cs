using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class InventoryDistribution
    {
        public string INVENTORY_DISTRIBUTION_ID{get;set;}
        public string DEPARTMENT_ID{get;set;}
        public string DEPARTMENT_NAME { get;set;}
        public string PRODUCT_ID { get; set; }

        public string CATEGORY_ID { get;set;}
        public string CATEGORY_NAME { get;set;}
        public string PRODUCT_NAME { get;set;}
        public string PRODUCT_CODE { get;set;}
        public string FACULTY_ID{get;set;}
        public string FIRST_NAME { get;set;}
        public string QTY{get;set;}
        public string UNIT{get;set;}
        public string UNIT_NAME { get;set;}
        public string DESCRIPTION{get;set;}
        public string DATE{get;set;}
        public string CAMPUS_ID { get;set;}
        public string ACADEMIC_YEAR{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
