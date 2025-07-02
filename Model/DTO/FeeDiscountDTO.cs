using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class FeeDiscountDTO
    {
            public string DISCOUNT_ID{get;set;}
            public string DISCOUNT_NAME{get;set;}
            public string FREQUENCY_TYPE_ID{get;set;}
            public string DISCOUNT_VALUE{get;set;}
            public string IS_USED{get;set;}
            public string CAMPUS_ID{get;set;}
            public string IS_DELETED { get; set; }
    }
}
