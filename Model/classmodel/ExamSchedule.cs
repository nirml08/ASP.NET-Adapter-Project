using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamSchedule
    {
        public string EXAM_NAME{get;set;}
        public string M_EXAM{get;set;}
        public string IS_PUBLISHED{get;set;}
        public string LAST_DATE_FOR_EXAM_FEE{get;set;}
        public string FINE{get;set;}
        public string START_DATE{get;set;}
        public string END_DATE{get;set;}
        public string RULE_DESCRIPTION { get; set; }
    }
}
