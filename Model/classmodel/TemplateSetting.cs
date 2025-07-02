using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class TemplateSetting
    {
            public string SETTING_ID{get;set;}
            public string SETTING_NAME{get;set;}
            public string ALLOW_STATIC_HOUR{get;set;}
            public string NO_OF_HOURS{get;set;}
            public string NO_OF_DAYS{get;set;}
            public string BASIC_HOURS_FOR_HOD{get;set;}
            public string BASIC_HOURS_FOR_STAFF{get;set;}
            public string SEMESTER_TYPE{get;set;}
            public string SEMESTER_TYPE_ID { get;set;}  
            public string ACADEMIC_YEAR{get;set;}
            public string IS_ACTIVE{get;set;}
            public string IS_DELETE { get; set; }
    }
}
