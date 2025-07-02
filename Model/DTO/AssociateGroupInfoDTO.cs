using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AssociateGroupInfoDTO
    {
        public string ASSOCIATE_GROUP_INFO_ID { get; set; }
        public string GROUP_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string INCHARGE_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string ROLE_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CREATED_ON { get; set; }
        public string CREATED_BY { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
