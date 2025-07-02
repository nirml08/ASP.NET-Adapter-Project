using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class OBEPatternSection
    {
        public string OBE_QUESTIONPAPERPATTERNSECTION_ID { get; set; }
        public string OBE_QUESTIONPAPERPATTERN_ID { get; set; }
        public string OBE_QUESTIONPAPERPATTERN { get; set; }
        public string OBE_QUESTIONLEVEL_ID { get; set; }
        public string QUESTION_LEVEL { get; set; }
        public string SECTION_ID { get; set; }
        public string SECTION { get; set; } 
        public string TOTAL_QUESTION { get; set; }
        public string TO_BE_ATTEND { get; set; }
        public string EITHER_OR { get; set; }
        public string MARK_FOR_EACH_QUESTION { get; set; }
        public string MARK_FOR_EACH_SECTION { get; set; }
        public string SECTION_DECRIPTION { get; set; }
        public string IS_DELETED { get; set; }
        public string CAMPUS_ID{ get; set; }
    }
}
