using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class GrievanceType
    {
            public string GRIEVANCE_TYPE_ID{get;set;}
            public string GRIEVANCE_TYPE_NAME{get;set;}
            public string PREFIX_CODE{get;set;}
            public string GRIEVANCE_TYPE_CODE{get;set;}
            public string HAS_SUB{get;set;}
            public string IS_ACTIVE{get;set;}
            public string IS_DELETE { get; set; }
    }
}
