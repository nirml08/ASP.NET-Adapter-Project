using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class HRStaffClassDurationDetailsDTO
    {
        public string CLASS_DURATION_DETAILS_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string LECTURE_UNIT_ID { get; set; }
        public string CONTENT { get; set; }
        public string PLANNED_HOURS { get; set; }
        public string OBTAINED_HOURS { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string LECTURE_METHOD { get; set; }
        public string ASSESSMENT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
