using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class CertificateTypeDTO
    {
        public string CERTIFICATE_ID { get; set; }
        public string CERTIFICATE_NAME { get; set; }
        public string SIGNATORIES_NAME { get; set; }
        public string EMAIL_ID { get; set; }
        public string SIGNATURE_1 { get; set; }
        public string SIGNATURE_2 { get; set; }
        public string APPROVER_1 { get; set; }
        public string APPROVER_2 { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string APPLICATION_TYPE_ID { get; set; }
        public string AMOUNT { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
