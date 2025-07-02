using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ProgrammeSemesterWiseCreditsDTO
    {
        public string PROGRAMME_CREDIT_ID { get; set; }
        public string BATCH_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string SEMESTER_ID { get; set; }
        public string TOTAL_CREDITS { get; set; }
        public string MAX_MARKS { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
