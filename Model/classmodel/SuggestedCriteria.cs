using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class SuggestedCriteria
    {
        public string SUGGESTED_CRITERIA_ID{get;set;}
        public string EVENT_ID{get;set;}
        public string CRITERIA{get;set;}
        public string CRITERIA_CODE { get;set;}
        public string CRITERIA_NAME { get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
