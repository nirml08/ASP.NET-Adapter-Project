using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class HRStaffEducationalDetailsDTO
    {
        public string EDUCATION_ID { get; set; }
        public string EDUCATION_NAME { get; set; }
        public string NAME_OF_UNIVERSITY { get; set; }
        public string YEAR { get; set; }
        public string MARKS_OBTAINED { get; set; }
        public string CLASS_OR_GRADE { get; set; }
        public string STAFF_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
