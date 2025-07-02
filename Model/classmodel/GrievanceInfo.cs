using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class GrievanceInfo
    {
        public string GRIEVANCE_ID{get;set;}
        public string USER_ID{get;set;}
        public string GRIEVANCE_CODE{get;set;}
        public string GRIEVANCE_TYPE_ID{get;set;}
        public string GRIEVANCE_TITLE{get;set;}
        public string GRIEVANCE_SUBJECT{get;set;}
        public string GRIEVANCE_CONTENT{get;set;}
        public string ASSIGN_TO{get;set;}
        public string FIRST_NAME { get;set;}
        public string SUB_DATE_TIME{get;set;}
        public string ACADEMIC_YEAR{get;set;}
        public string STATUS{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED{get;set;}
        public string CAMPUS_ID { get; set; }
        public List<GrievanceAttachment> liattachment { get; set; }
    }

    public class GrievanceInfoDTO
    {
        public string GRIEVANCE_ID { get; set; }
        public string USER_ID { get; set; }
        public string GRIEVANCE_CODE { get; set; }
        public string GRIEVANCE_TYPE_ID { get; set; }
        public string GRIEVANCE_TITLE { get; set; }
        public string GRIEVANCE_SUBJECT { get; set; }
        public string GRIEVANCE_CONTENT { get; set; }
        public string ASSIGN_TO { get; set; }
        public string SUB_DATE_TIME { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string STATUS { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string CAMPUS_ID { get; set; }
        public List<GrievanceAttachment> liattachment { get; set; }
    }
}
