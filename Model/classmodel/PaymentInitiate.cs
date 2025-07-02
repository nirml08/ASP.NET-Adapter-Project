using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class PaymentInitiate
    {
        public string Key{get;set;}
        public string Access_Key{get;set;}
        public string PaymentGateway_Mode{get;set;}
        public string CollegeLogoUrl{get;set;}
        public string College_Name{get;set;}
        public string Payment_Url { get; set; }

    }
}
