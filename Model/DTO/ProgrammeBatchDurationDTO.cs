using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ProgrammeBatchDurationDTO
    {
        public string DURATION_ID { get; set; }
        public string BATCH_ID { get; set; }
        public string PROGRAMME_ID { get; set; }
        public string DURATION { get; set; }
        public string BEGIN_YEAR { get; set; }
        public string EXPIRED_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
