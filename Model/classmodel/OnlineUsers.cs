using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class OnlineUsers
    {
        public string ONLINE_USER_ID{get;set;}
        public string CONNECTION_ID{get;set;}
        public string EMAIL_ID{get;set;}
        public string DATE_TIME{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
