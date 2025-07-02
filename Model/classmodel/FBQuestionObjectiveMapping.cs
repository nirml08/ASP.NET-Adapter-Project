using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class FBQuestionObjectiveMapping
    {
        public string QUESTION_OBJECT_ID{get;set;}
        public string FEEDBACK_ID{get;set;}
        public string QUESTION_ID{get;set;}
        public string OBJECTIVE_ID{get;set;}
        public string ACADEMIC_YEAR{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
