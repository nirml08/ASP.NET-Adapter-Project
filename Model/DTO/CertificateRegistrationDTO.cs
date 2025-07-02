using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class CertificateRegistrationDTO
    {
        public string REGISTRATION_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string CERTIFICATE_ID { get; set; }
        public string PURPOSE { get; set; }
        public string REGISTERED_DATE { get; set; }
        public string STATUS_ID { get; set; }
        public string REMARK { get; set; }
        public string AMOUNT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_FEE_ACTIVE { get; set; }
    }
}
