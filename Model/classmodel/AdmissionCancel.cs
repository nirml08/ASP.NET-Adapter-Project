using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AdmissionCancel
    {
        public string ADMISSION_CANCEL_ID { get; set; }
        public string PROGRAMME_ID { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string RECEIVE_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string APPLICATION_NO { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string REASON { get; set; }
        public string IS_REFUNDED { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string TRANSACTION_ID { get; set; }
    }
}
