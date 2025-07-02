using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class PaymentGatewayType
    {
            public string GATEWAY_TYPE_ID{get;set;}
            public string GATEWAY_NAME{get;set;}
            public string DESCRIPTION{get;set;}
            public string MAIL_ID{get;set;}
            public string CONTACT_NO{get;set;}
            public string IS_ACTIVE{get;set;}
            public string IS_DELETED { get; set; }
    }
}
