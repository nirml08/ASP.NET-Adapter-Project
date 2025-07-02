using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AssignmentSettingDTO
    {
        public string ASSIGNMENT_SETTING_ID{get;set;}
        public string ASSIGNMENT_NAME{get;set;}
        public string STAFF_ID{get;set;}
        public string COURSE_ID{get;set;}
        public string CLASS_ID{get;set;}
        public string TOTAL_MARK{get;set;}
        public string START_DATE{get;set;}
        public string END_DATE{get;set;}
        public string START_TIME{get;set;}
        public string END_TIME{get;set;}
        public string ACADEMIC_YEAR{get;set;}
        public string ENTRY_DATE{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED{get;set;}
        public string CAMPUS_ID { get; set; }
    }
}
