using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class OBEMarkEntryDTO
    {
            public string OBE_MARKENTRY_ID{get;set;}
            public string OBE_QUESTIONMARKSTRUCTURE_ID {get;set;}
            public string STUDENT_ID{get;set;}
            public string COURSE_ID{get;set;}
            public string TOTAL_MARK{get;set;}
            public string SECURED_MARK{get;set;}
            public string QUESTION_NUMBER{get;set;}
            public string OBE_COLEVEL_ID{get;set;}
            public string OBE_COMPONENT_ID{get;set;}
            public string EXAM_SETTING_ID{get;set;}
            public string EXAM_TYPE{get;set;}
            public string ENTRY_ID{get;set;}
            public string ACADEMIC_YEAR { get; set; }
    }
}
