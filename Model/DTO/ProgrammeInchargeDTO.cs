using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ProgrammeInchargeDTO
    {
        public string INCHARGE_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
