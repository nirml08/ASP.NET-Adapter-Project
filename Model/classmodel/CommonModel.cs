using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class CommonModel
    {
        public string EVENT_ID { get; set; }
        public string MAIL_ID { get; set; }
        public string PRODUCT_ID { get; set; }
        public string REQUEST_TYPE { get; set; }
        public string ROLE_ID { get; set; }
        public string GRIEVANCE_TYPE_ID { get; set; }
        public string QUIZ_ID { get; set; }
        public IFormFile FILE { get; set; }
        public string SETTING_ID { get; set; }
        public string QUESTION_GROUP { get; set; }
        public string FEEDBACK_ID { get; set; }
        public string FEEDBACK_ROLE_ID { get; set; }

        public string HSC_GROUP_ID { get; set; }
        public object easepayid;
        public string FREQUENCY_TYPE_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string FB_SETTING_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string CLASS_YEAR { get; set; }
        public string CLASS_YEAR_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string FREQUENCY { get; set; }
        public string BATCH_ID { get; set; }
        public string BATCH { get; set; }
        public string BATCH_YEAR { get; set; }

        public string PROGRAMME { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string APPLICATION_TYPE_ID { get; set; }
        public string SEMESTER { get; set; }
        public string AC_YEAR { get; set; }
        public string FINE { get; set; }
        public string FINE_AMOUNT { get; set; }
        public string FINE_ID { get; set; }
        public string FEE_ROOT_ID { get; set; }
        public string FEE_MODE { get; set; }
        public string RESULT { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string FEE_MAIN_HEAD_ID { get; set; }
        public string MAIN_HEAD { get; set; }
        public string HEAD { get; set; }
        public string COST { get; set; }
        public string TITLE { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string PROGRAMME_TYPE_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string CLASS_LEVEL { get; set; }
        public string REGISTRATION_ID { get; set; }
        public string REGISTER_NO { get; set; }
        public string ROLL_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string SEMESTER_ID { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string STATUS { get; set; }
        public string PAID_STATUS { get; set; }
        public string EXAM_TYPE { get; set; }
        public string EVALUATION_TYPE { get; set; }
        public string EXAM_DATE { get; set; }
        public string EXAM_SESSION_ID { get; set; }
        public string EXAM_SESSION { get; set; }
        public string SUBJECT_TYPE { get; set; }
        public string UGC_COURSE_TYPE_ID { get; set; }
        public string UGC_COURSE_TYPE { get; set; }
        public string EXAM_NAME { get; set; }
        public string SEMESTER_TYPE_ID { get; set; }
        public string COURSE_ROOT_ID { get; set; }
        public string COURSE_TYPE_ID { get; set; }
        public string COURSE_TYPE { get; set; }
        public string MARK { get; set; }
        public string CAMPUS_ID { get; set; }
        public string STYPE { get; set; }
        public string UDF1 { get; set; }
        public string UDF2 { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string ENTRY_ID { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string MONTH_YEAR { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string FREQUENCY_TYPE { get; set; }
        public string ID { get; set; }
        public string STR_RESPONSE { get; set; }
        public object EMAIL { get; set; }
        public object PHONE { get; set; }
        public object MOBILE_NO { get; set; }
        public object ORDER_ID { get; set; }
        public string IS_LIVE { get; set; }
        public string PAY_URL { get; set; }
        public string SUBJECT_TYPE_ID { get; set; }
        public string COURSE_ORDER { get; set; }
        public string AMOUT { get; set; }
        public string COURSE_STRUCTURE_ID { get; set; }
        public string IS_COMPULSORY { get; set; }
        public string PART { get; set; }
        public string INTERNAL { get; set; }

        public string STUDENT_COUNT { get; set; }
        public string MODERATION_MARK { get; set; }
        public string TRANSACTION_ID { get; set; }

        public string GENDER { get; set; }
        public string EXAM_SETTING { get; set; }
        public string EXAM_REVALUATION_SETTING_ID { get; set; }
        public string EXAM_RETOTAL_SETTING_ID { get; set; }

        public string APPLICATION_TYPE { get; set; }
        public string MAX_PAPER { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string EXAM_REVALUATION_REGISTER_ID { get; set; }
        public string REGISTERED_DATE { get; set; }
        public string PAPERS { get; set; }
        public string CREDIT { get; set; }
        public string DEBIT { get; set; }
        public string CERTIFICATE_TYPE { get; set; }
        public string BAR_CODE { get; set; }
        public string USER_TYPE { get; set; }
        public string ROLE { get; set; }
        public string TIMETABLE_ID { get; set; }
        public string PACKET_NO { get; set; }
        public string PASS_COUNT { get; set; }
        public string FAIL_COUNT { get; set; }
        public string PROGRAMME_SETTING_ID { get; set; }
        public string FOLIO_NUMBER { get; set; }
        public string NO_OF_WORKING_DAYS { get; set; }
        public string NO_OF_PRESENT_DAYS { get; set; }
        public string NO_OF_ABSENT_DAYS { get; set; }
        public string COMPONENT_ID { get; set; }
        public string ATTENDANCE_PERCENTAGE { get; set; }
        public string COMPONENT { get; set; }
        public string COURSE_GROUP_MARK { get; set; }
        public string FATHER_NAME { get; set; }
        public string MOTHER_NAME { get; set; }
        public string NAME { get; set; }
        public string GENDER_ID { get; set; }
        public string GENDER_NAME { get; set; }
        public string DOB { get; set; }
        public string USER_TYPE_ID { get; set; }
        public string USER_TYPE_NAME { get; set; }
        public string COMMUNITY_ID { get; set; }
        public string COMMUNITY { get; set; }
        public string NATIONALITY_ID { get; set; }
        public string NATIONALITY_NAME { get; set; }
        public string CASTE { get; set; }
        public string RELIGION_ID { get; set; }
        public string RELIGION { get; set; }
        public string DEPARTMENT { get; set; }
        public string ASSESSEE { get; set; }
        public string SUP_FEEDBACK_ROLE_ID { get; set; }
        public string DEGREE { get; set; }
        public string FIRST_MAJOR { get; set; }
        public string SECOND_MAJOR { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string PHOTO_PATH { get; set; }
        public string ADDRESS { get; set; }
        public string NO_OF_SEMESTER { get; set; }
        public string FINAL_SEMESTER { get; set; }
        public string DATE_OF_PUBLICATION { get; set; }
        public string SIGNATORIES_NAME { get; set; }
        public string CGPA { get; set; }
        public string CLASS_STUDENT_STRENGTH { get; set; }
        public string REGISTERED_STUDENT_STRENGTH { get; set; }
        public string REGISTERED_PERCENTAGE { get; set; }
        public string TXNID { get; set; }
        public string AMOUNT { get; set; }
        public string EASEPAYID { get; set; }
        public string SETTLEMENT_DATE { get; set; }
        public string EB_TRANSFER_ID { get; set; }
        public string IS_LANGUAGE { get; set; }
        public string DATE_FROM { get; set; }
        public string DATE_TO { get; set; }
        public string FEE_CATEGORY_ID { get; set; }
        public string BANK_ACCOUNT_ID { get; set; }
        public string BANK_ACCOUNT { get; set; }
        public string IS_OPTIONAL { get; set; }
        public string INSTALLMENT_ID { get; set; }
        public string PROGRAMME_MODE { get; set; }
        public string SHIFT { get; set; }
        public string PAYMENT_MODE { get; set; }
        public string EXAM_PHOTOCOPY_SETTING_ID { get; set; }
        public string ORDER_BY { get; set; }

        public string USER_ID { get; set; }
        public string PAYMENT_DATE { get; set; }
        public string IS_COMBINED { get; set; }
        public string IS_COMMON_COURSE { get; set; }
        public string LIMIT_COUNT { get; set; }
        public string OFFSET_COUNT { get; set; }
        public string RECEIVE_ID { get; set; }
        public string APPLICATION_NO { get; set; }
        public string COMMUNITY_STRENGTH { get; set; }
        public string HEAD_ID { get; set; }
        public string RUN_ID { get; set; }
        public string ADMISSION_NUMBER_ID { get; set; }
        public string ADMISSON_NO { get; set; }
        public string QUIZ_SETTING_ID { get; set; }
        public string NO_OF_QUESTIONS { get; set; }
        public string SET_ID { get; set; }
        public string COUNT { get; set; }
        public string FROM_PERCENTAGE { get; set; }
        public string TO_PERCENTAGE { get; set; }
        public string CIA_GROUP_COMPONENT_ID { get; set; }
        public string CIA_GROUP_ID { get; set; }
        public string SUP_CIA_COMPONENT_ID { get; set; }
        public string MAX_MARK { get; set; }
        public string MIN_MARK { get; set; }
        public string COURSE_GROUP_ID { get; set; }
        public string RECEIVER_ID { get; set; }
        public string SENDER_ID { get; set; }
        public string GROUP_ID { get; set; }
        public string REPLY_ID { get; set; }
        public string BEGIN_YEAR { get; set; }
        public string SERIAL_NO { get; set; }
        public string STAFF_COUNT { get; set; }
        public string EXPIRED_YEAR { get; set; }
        public string JOB_VACANCY_ID { get; set; }
        public string APPLICATION_ID { get; set; }
        public string PEER_ID { get; set; }
        public string LI_MEMBERSHIP_SETTING_ID { get; set; }
        public string MEMBER_ID { get; set; }
    }

    public class StudentCIAMarks
    {
        public string ROLL_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string COMPONENT_ID { get; set; }
        public string COMPONENT { get; set; }
        public string COURSE_GROUP_MARK { get; set; }
        public string TOTAL { get; set; }


    }
    
}
