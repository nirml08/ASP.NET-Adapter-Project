using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AdmissionTransferDTO
    {
        public string TRANSFER_ID { get; set; }
        public string RECEIVE_ID { get; set; }
        public string APPLICATION_NO { get; set; }
        public string PROGRAMME_FROM { get; set; }
        public string PROGRAMME_TO { get; set; }
        public string APPROVE_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_APPROVED { get; set; }
        public string CAMPUS_ID { get; set; }
        public string STATUS { get; set; }
    }
}
