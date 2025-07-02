using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AssocationClassQuota
    {
            public string ASSOCIATION_GROUP_CLASS_QUOTA_ID{get;set;}
            public string CLASS_ID{get;set;}
            public string COURSE_ID{get;set;}
            public string SETTING_ID{get;set;}
            public string QUOTA{get;set;}
            public string ACADEMIC_YEAR{get;set;}
            public string IS_ACTIVE{get;set;}
            public string IS_DELETE { get; set; }
    }
}
