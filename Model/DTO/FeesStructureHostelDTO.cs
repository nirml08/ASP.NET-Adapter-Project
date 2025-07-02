using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class FeesStructureHostelDTO
    {
            public string FEE_STRUCTURE_ID{get;set;}
            public string ACADEMIC_YEAR{get;set;}
            public string FREQUENCY{get;set;}
            public string HEAD{get;set;}
            public string AMOUNT{get;set;}
            public string IS_DELETED{get;set;}
            public string IS_UPDATED{get;set;}
            public string BANK_ACCOUNT_ID {get;set;}
            public string FEE_MAIN_HEAD_ID{get;set;}
            public string CAMPUS_ID { get; set; }
    }
}
