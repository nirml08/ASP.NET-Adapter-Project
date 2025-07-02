using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AdmOTPVerification
    {
            public string OTP_VERIFICATION_ID{get;set;}
            public string MAIL_ID{get;set;}
            public string HSC_NO {get;set;}
            public string OTP{get;set;}
            public string IS_ACTIVE{get;set;}
            public string IS_DELETED { get; set; }
    }
}
