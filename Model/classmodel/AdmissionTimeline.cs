using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AdmissionTimeline
    {
        public string EVENT_ID{get;set;}
        public string EVENT_NAME{get;set;}
        public string EVENT_DESCRIPTION{get;set;}
        public string START_DATE { get;set;}
        public string DEAD_LINE_DATE{get;set;}
        public string CAMPUS_ID{get;set;}
        public string ACADEMIC_YEAR{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
