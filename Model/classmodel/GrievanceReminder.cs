using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class GrievanceReminder
    {
        public string REMINDER_ID{get;set;}
        public string GRIEVANCE_ID{get;set;}
        public string DATE{get;set;}
        public string TIME{get;set;}
        public string IS_READ{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED{get;set;}
        public string IS_TYPE { get; set; }
    }
}
