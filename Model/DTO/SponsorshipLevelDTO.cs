using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class SponsorshipLevelDTO
    {
        public string SPONSORSHIP_LEVEL_ID { get; set; }
        public string SPONSORSHIP_LEVEL { get; set; }
        public string FINANCIAL_CONTRIBUTION { get; set; }
        public string BENEFITS { get; set; }
        public string FREQUENCY_ID { get; set; }    
        public string CAMPUS { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
