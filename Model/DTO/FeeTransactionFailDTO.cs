using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class FeeTransactionFailDTO
    {
        public string ORDER_ID { get; set; }
        public string AMOUNT { get; set; }
        public string AMOUNTPAID { get; set; }
        public string STATUS { get; set; }
        public string FREQUENCYNAME { get; set; }
        public string CREATEDAT { get; set; }
        public string STUDENT_ID { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string ADMINSSIONNO { get; set; }
        public string ISACTIVE { get; set; }
        public string ISDELETED { get; set; }
    }
}
