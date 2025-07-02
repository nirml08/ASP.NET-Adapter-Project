using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class MessageResult
    {
        public class listsms
        {
            public string sms { get; set; }
            public string mobiles { get; set; }
            public string senderid { get; set; }
            public string clientSMSID { get; set; }
            public string accountusagetypeid { get; set; }
            public string entityid { get; set; }
            public string tempid { get; set; }
        }
        public class SMSRequestCompose
        {
            public List<listsms> listsms { get; set; }
            public string password { get; set; }
            public string user { get; set; }
            public string clientSMSID { get; set; }
            public string entityid { get; set; }
            public string tempid { get; set; }

        }

    }
}
