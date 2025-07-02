using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamRules
    {
        public string RULE_ID{get;set;}
        public string EXAM_SETTING_ID{get;set;}
        public string EXAM_NAME { get;set;}
        public string RULE_DESCRIPTION{get;set;}
        public string DATE{get;set;}
        public string CAMPUS_ID { get;set;} 
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
