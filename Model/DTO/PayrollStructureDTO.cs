using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class PayrollStructureDTO
    {
        public string PAYROLL_STRUCTURE_ID { get; set; }
        public string PAYROLL_HEAD_ID { get; set; }
        public string RANGE_FROM { get; set; }
        public string RANGE_TO { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
