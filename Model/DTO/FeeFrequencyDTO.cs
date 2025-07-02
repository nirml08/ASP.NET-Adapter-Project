using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class FeeFrequencyDTO
    {
        public string FREQUENCY_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string FREQUENCY_NAME { get; set; }
        public string DATE_FROM { get; set; }
        public string DATE_TO { get; set; }
        public string STATUS { get; set; }
        public string IS_DELETED { get; set; }
        public string LAST_DATE_OF_PAYMENT { get; set; }
        public string SEMESTER_TYPE_ID { get; set; }
        public string FEE_ROOT_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_PARTIAL_PAYMENT { get; set; }
        public string NO_OF_INSTALLMENT { get; set; }
        public string IS_RESTRICTED { get; set; }


    }
}
