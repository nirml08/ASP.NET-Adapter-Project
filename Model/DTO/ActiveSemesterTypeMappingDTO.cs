using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ActiveSemesterTypeMappingDTO
    {
        public string ACTIVE_SEMESTER_ID { get; set; }
        public string SEMESTER_TYPE_ID { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string CLASS_YEAR_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
