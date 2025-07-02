using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ProgrammeGroup
    {
        public string PROGRAMME_GROUP_ID { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string PROGRAMME_LEVEL { get; set; }
        public string PROGRAMME_ID { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string IS_DELETED { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string SHIFT { get; set; }
        public string SHIFT_NAME { get; set; }
        public string PROGRAMME_MODE_ID { get; set; }

        public string PROGRAMME_MODE { get; set; }
        public string PROGRAMME_ORDER { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string FACULTY { get; set; }
        public string APPTYPE_ID { get; set; }
        public string IS_NOT_ADMISSION { get; set; }
    }
}
