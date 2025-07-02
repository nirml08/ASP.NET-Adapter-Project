using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AlumniMembershipRegistrationDTO
    {
        public string REGISTRATION_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string MEMBER_CATEGORY_ID { get; set; }
        public string REGISTERED_DATE { get; set; }
        public string IS_ACCEPTED { get; set; }
        public string IS_REJECTED { get; set; }
        public string REMARK { get; set; }
        public string AMOUNT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string APPROVED_BY { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
