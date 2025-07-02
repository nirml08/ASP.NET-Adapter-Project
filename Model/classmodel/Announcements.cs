using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class Announcements
    {
        public string ANNOUNCEMENT_ID{get;set;}
        public string TITLE{get;set;}
        public string CONTENT{get;set;}
        public string CREATED_AT{get;set;}
        public string EXPIRY_DATE{get;set;}
        public string CAMPUS_ID{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
