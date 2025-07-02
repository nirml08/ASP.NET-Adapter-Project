using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AttendancePercentageMark
    {
        public string PERCENTAGE_MARK_ID { get; set; }
        public string FROM_PERCENTAGE { get; set; }
        public string TO_PERCENTAGE { get; set; }
        public string MARK { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
