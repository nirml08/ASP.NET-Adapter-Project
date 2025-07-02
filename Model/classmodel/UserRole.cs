using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class UserRole
    {
            public string ROLE_ID{get;set;}
            public string ROLE_NAME {get;set;}
            public string CONTROLLER_NAME{get;set;}
            public string ACTION_NAME{get;set;}
            public string IS_ACTIVE{get;set;}
            public string IS_DELETED { get; set; }
    }
}
