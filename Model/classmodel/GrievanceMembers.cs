using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class GrievanceMembers
    {
        public string G_MEMBER_ID { get; set; }
        public string GRIEVANCE_TYPE_ID { get; set; }
        public string GRIEVANCE_TYPE_NAME { get; set; }
        public string STAFF_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string ROLE { get; set; }
        public string ROLE_NAME { get; set; }

        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
