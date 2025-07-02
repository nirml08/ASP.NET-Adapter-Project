using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class FeeDiscountAllotmentDTO
    {
            public string DISCOUNT_ALLOTMENT_ID{get;set;}
            public string STUDENT_ID {get;set;}
            public string FREQUENCY_ID {get;set;}
            public string ACCADEMIC_YEAR{get;set;}
            public string CLASS_ID {get;set;}
            public string DISCOUNT_ID {get;set;}
            public string IS_DELETED{get;set;}
            public string IS_USED { get; set; }
    }
}
