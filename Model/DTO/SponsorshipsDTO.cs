using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class SponsorshipsDTO
    {
        public string SPONSORSHIP_ID { get; set; }
        public string SPONSOR_ID { get; set; }
        public string SPONSOR_NAME { get; set; }
        public string SPONSORSHIP_TYPE { get; set; }
        public string SPONSORSHIP_CRITERIA { get; set; }
        public string CONTRIBUTION_DATE { get; set; }
        public string SPONSORSHIP_AMOUNT { get; set; }
        public string PURPOSE { get; set; }
        public string REMARKS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
