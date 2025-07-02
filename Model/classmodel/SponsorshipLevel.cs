using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class SponsorshipLevel
    {
        public string SPONSORSHIP_LEVEL_ID{get;set;}
        public string SPONSORSHIP_LEVEL{get;set;}
        public string FINANCIAL_CONTRIBUTION{get;set;}
        public string BENEFITS{get;set;}
        public string FEE_MAIN_HEAD_ID { get;set;}
        public string MAIN_HEAD { get;set;}
        public string HEAD { get;set;}
        public string FREQUENCY_ID { get;set;}
        public string FREQUENCY_NAME { get;set;}
        public string CAMPUS{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
