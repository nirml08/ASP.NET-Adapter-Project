using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class IQACEventsDTO
    {
        public string EVENT_ID { get; set; }
        public string EVENT_TITLE { get; set; }
        public string CATEGORY { get; set; }
        public string SUB_CATEGORY { get; set; }
        public string EVENT_START_DATE { get; set; }
        public string EVENT_END_DATE { get; set; }
        public string ORGANIZED_BY { get; set; }
        public string COLLABORATION { get; set; }
        public string CAMPUS { get; set; }
        public string VENUE { get; set; }
        public string ESTIMATED_BUDGET { get; set; }
        public string APPROVED_BUDGET { get; set; }
        public string ACTUAL_EXPENDITURE { get; set; }
        public string CONTACT_INFORMATION { get; set; }
        public string REGISTRATION_WEB_LINK { get; set; }
        public string ASSIGNED_FACULTY_MEMBER { get; set; }
        public string DURATION { get; set; }
        public string RESOURCE_PERSON { get; set; }
        public string IS_WEBINAR { get; set; }
        public string IS_WORKSHOPS { get; set; }
        public string IS_ONLINE { get; set; }
        public string SUGGESTED_CRITERIA { get; set; }
        public string ENTRY_ID { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public List<IQACEventDocument> EventFileItems { get; set; }
    }
}
