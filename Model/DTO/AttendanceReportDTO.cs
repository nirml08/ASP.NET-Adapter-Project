using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AttendanceReportDTO
    {
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
    }
}
