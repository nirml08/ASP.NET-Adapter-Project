using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class EventReport
    {
        public string EVENT_REPORT_ID{get;set;}
        public string EVENT_ID{get;set;}
        public string REPORT_NAME{get;set;}
        public string REPORT_CONTENT{get;set;}
        public string ENTRY_ID { get;set;}
        public string CAMPUS_ID{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
