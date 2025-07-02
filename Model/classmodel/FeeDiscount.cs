using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class FeeDiscount
    {
        public string DISCOUNT_ID { get; set; }
        public string DISCOUNT_NAME { get; set; }
        public string FREQUENCY_TYPE { get; set; }
        public string DISCOUNT_VALUE { get; set; }
        public string IS_USED { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_DELETED { get; set; }
    }
    public class FeeDiscountCollection
    {
        public string FREQUENCY_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string PROGRAMEE_ID { get; set; }
        public string SHIFT_ID { get; set; }
        public string CLASS_YEAR { get; set; }
        public string CLASS_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string BALANCE { get; set; }
        public string DEBIT { get; set; }
        public string CREDIT { get; set; }
        public string PHOTO_PATH { get; set; }
        public string ROLL_NO { get; set; }
        public string HEAD { get; set; }
        public string FULL_NAME { get; set; }
        public string HEAD_ID { get; set; }
        public string FEE_MAIN_HEAD_ID { get; set; }
        public string DISCOUNT_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_STATUS { get; set; }
        public string TOTAL_AMOUNT { get; set; }
        public string TRANSACTION_DATE { get; set; }
        public string FREQUENCY_NAME { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string PAYMENT_MODE { get; set; }
    }

    public class FeeDiscountReport
    {
        public string DISCOUNT_ID { get; set; }
        public string DISCOUNT_NAME { get; set; }
        public string FREQUENCY_TYPE { get; set; }
        public string DISCOUNT_VALUE { get; set; }
        public string IS_USED { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_DELETED { get; set; }
        // 
        public string STU_DISCOUNT_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string FREQUENCY_NAME { get; set; }
        public string DISCOUNT_GROUP { get; set; }
        public string TOTAL_AMOUNT { get; set; }
        public string DISCOUNT_DATE { get; set; }
        public string IS_ACTIVE { get; set; }
    }

}
