using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class Mailattachment
    {
            public string ATTACHMENT_ID{get;set;}
            public string MAIL_ID{get;set;}
            public string FILE_PATH{get;set;}
            public string FILE_NAME{get;set;}
            public string UPLOAD_AT{get;set;}
            public string IS_ACTIVE{get;set;}
            public string IS_DELETED { get; set; }
    }
}
