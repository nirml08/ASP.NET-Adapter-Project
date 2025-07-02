using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamInvigilatorSetting
    {
        public string EXAM_INVIGILATOR_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string MAX_SUPERVISION_HOUR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string FIRST_NAME { get; set; }
    }
}
