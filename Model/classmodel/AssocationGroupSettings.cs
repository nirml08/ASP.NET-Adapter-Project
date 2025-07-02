using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AssocationGroupSettings
    {
            public string ASSOCIATION_GROUP_SETTING_ID{get;set;}
            public string SETTING_NAME{get;set;}
            public string DATE_FROM {get;set;}
            public string DATE_TO{get;set;}
            public string SEMESTER_ID{get;set;}
            public string ACADEMIC_YEAR{get;set;}
            public string IS_ACTIVE {get;set;}
            public string IS_DELETED { get; set; }
    }
}
