using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ProgrammeEligibilityDTO
    {
            public string PGW_ID {get;set;}
            public string PROGRAMME_GROUP_ID{get;set;}
            public string HSS_GROUP_ID {get;set;}
            public string ACADEMIC_YEAR{get;set;}
            public string IS_ACTIVE {get;set;}
            public string IS_DELETED{get;set;}
            public string CAMPUS_ID { get; set; }
    }
}
