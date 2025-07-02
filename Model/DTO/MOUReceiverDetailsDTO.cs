using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class MOUReceiverDetailsDTO
    {
        public string MOU_RECEIVER_ID { get; set; }
        public string MOU_ID { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string FILE_PATH { get; set; }
        public string REMARK { get; set; }
        public string NO_OF_BENEFICIARIES { get; set; }
        public string MOU_STATUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CREATED_AT { get; set; }
        public string UPDATED_AT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
