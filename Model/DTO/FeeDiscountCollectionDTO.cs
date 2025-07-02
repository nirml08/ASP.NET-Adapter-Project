using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class FeeDiscountCollectionDTO
    {
        public string STUDENT_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string HEAD { get; set; }
        public string DEBIT { get; set; }
        public string DISCOUNT_AMOUNT { get; set; }
        public string TRANSACTION_DATE { get; set; }
        public string DISCOUNT_DATE { get; set; }
        public string DISCOUNT_ID { get; set; }
        public string IS_STATUS { get; set; }  
        public string FEE_MAIN_HEAD_ID { get; set; }  
        public string TOTAL_AMOUNT { get; set; }          
        public string STU_DISCOUNT_ID { get; set; }          
         
    }
}
