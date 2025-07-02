using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class SponsorshipCriteria
    {
        public string CRITERIA_ID{get;set;}
        public string CATEGORY{get;set;}
        public string DESCRIPTION{get;set;}
        public string CAMPUS_ID{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
