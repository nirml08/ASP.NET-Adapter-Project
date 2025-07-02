using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class UGCCoursetype
    {
        public string UGC_COURSE_TYPE_ID { get; set; }
        public string UGC_COURSE_TYPE { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
        public string COURSE_ORDER { get; set; }
        public string PART_ID { get; set; }
        public string PART { get; set; }

        public string PROGRAMME_LEVEL { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string IS_NOT_REGISTRATION { get; set; }
        public string IS_NOT_REVALUATION { get; set; }

    }
}
