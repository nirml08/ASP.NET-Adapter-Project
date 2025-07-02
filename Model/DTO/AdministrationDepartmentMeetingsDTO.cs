using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AdministrationDepartmentMeetingsDTO
    {
        public string DEPARTMENT_MEETING_ID { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string AGENDA { get; set; }
        public string MEETING_DATE { get; set; }
        public string TIME { get; set; }
        public string VENUE { get; set; }
        public string FILE_PATH { get; set; }
        public string CREATED_AT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
