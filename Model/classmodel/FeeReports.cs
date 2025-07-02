using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class FeeReports
    {
        public string STUDENT_AC_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string HEAD { get; set; }
        public string CREDIT { get; set; }
        public string DEBIT { get; set; }
        public string TRANSACTION_DATE { get; set; }
        public string DISCOUNT_ID { get; set; }
        public string IS_DELETED { get; set; }
        public string TRANSACTION_ID { get; set; }
        public string BANK { get; set; }
        public string IS_REFUND { get; set; }
        public string SPONSOR_ID { get; set; }
        public string F_STUDENT_AC_ID { get; set; }
        public string FINE_DATE { get; set; }
        public string IS_CANCELLED_HEAD { get; set; }
        public string FEE_MAIN_HEAD_ID { get; set; }

        public string BALANCE { get; set; }
        public string HEAD_ID { get; set; }
        public string MAIN_HEAD_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string PAYMENT_DATE { get; set; }
        public string SETTLEMENT_DATE { get; set; }
        public string FREQUENCY_NAME { get; set; }
        public string ROLL_NO { get; set; }
        public string REGISTER_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string TOTAL_AMOUNT { get; set; }
        public string STATUS { get; set; }
        public string CLASS { get; set; }
        public string CLASS_YEAR { get; set; }
        public string ROLE_NAME { get; set; }
        public string EVENT_TITLE { get; set; }
        public string RECEIPT_NO { get; set; }
        public string COLLECTED { get; set; }
        public string PAYMENT_MODE { get; set; }
        public string LI_MEMBERSHIP_SETTING { get; set; }
    }
    public class FeeOrderIdBasedHistory
    {
        public string FULL_NAME { get; set; }
        public string CLASS_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string PROGRAMME_MODE { get; set; }
        public string STUDENT_ID { get; set; }
        public string STUDENT_COUNT { get; set; }
        public string STATUS { get; set; }
    }
}
