using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamRegistration
    {
        public string REGISTRATION_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string STUDENT_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string COURSE_ROOT_ID { get; set; }
        public string STATUS { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string EXAM_SEMESTER { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string DATE { get; set; }
        public string COURSE_STRUCTURE_ID { get; set; }
        public string SEMESTER_ID { get; set; }
        public string INTERNAL { get; set; }
        public string APPTYPE_ID { get; set; }
        public string FULL_NAME { get; set; }
        public string EXAM_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string CLASS_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string COURSE_COUNT { get; set; }
        public string APPLICATION_TYPE_ID { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string BATCH { get; set; }
        public string REGISTER_NO { get; set; }
        public string PROGRAMME { get; set; }
        public string CLASS_YEAR { get; set; }
        public string SEMESTER { get; set; }
        public string SEMESTER_TYPE { get; set; }
        public string M_EXAM { get; set; }
        public string M_PASS { get; set; }
        public string SEMESTER_TYPE_ID { get; set; }
        public string EXAM_TYPE { get; set; }
        public string EXAM_TYPE_NAME { get; set; }
        public string LAST_DATE_FOR_EXAM_FEE { get; set; }
        public string FINE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string IS_COMPULSORY { get; set; }

        public string NAME { get; set; }

        public string PART { get; set; }

        public string REMOVE_ID { get; set; }

        public string SUBJECT_TYPE_ID { get; set; }
        public string SUBJECT_TYPE { get; set; }
        public string AC_YEAR { get; set; }
        public string COURSE_ORDER { get; set; }
        public string COURSE_TYPE { get; set; }
        public string DATE_OF_BIRTH { get; set; }

        public string DEPARTMENT { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string PROGRAMENAME { get; set; }
        public string MOBILE_NO { get; set; }
        public string MONTH { get; set; }
        public string EXAM_DATE { get; set; }
        public string EXAM_SESSION_ID { get; set; }
        public string EXAM_SESSION { get; set; }
        public string STYPE { get; set; }
        public string UDF1 { get; set; }
        public string UDF2 { get; set; }
        public string UDF3 { get; set; }
        public string COMBINED { get; set; }
        public string PACKET_NO { get; set; }
        public string PACKET_REFERENCE_NO { get; set; }
        public string EXTERNAL { get; set; }
        public string SESSION_NAME { get; set; }
        public string CHECKING { get; set; }
        public string DUMMY_NO { get; set; }
        public string CAMPUS_ID { get; set; }
        public string YEAR { get; set; }
        public string STRENGTH { get; set; }
        public string AMOUT { get; set; }
        public string DATE_FROM { get; set; }
        public string DATE_TO { get; set; }
        public string S_CLASS_ID { get; set; }
        public string CIA_GROUP_MARK_CHECKING_ID { get; set; }
        public string TOTAL { get; set; }
        public string BARCODE { get; set; }
        public string CERTIFICATE_TYPE { get; set; }
        public string ROLE { get; set; }
        public string EXAM_SETTING { get; set; }
        public string BAR_CODE { get; set; }
        public string REGISTERED_COUNT { get; set; }
        public string REVALUATION_REGISTERED_COUNT { get; set; }
        public string PHOTO_PATH { get; set; }
    }
    public class GetActiveSemesterBatch
    {
        public string BATCH { get; set; }
        public string ACADEMIC_YEAR_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string SEMESTER { get; set; }
        public string IS_ACTIVE { get; set; }
        public string STUDENT_ID { get; set; }
        public string PROGRAMME { get; set; }

    }
    public class GetProgrammeandBatch
    {
        public string STUDENT_ID { get; set; }
        public string PROGRAMME { get; set; }
        public string BATCH { get; set; }
        public string SEMESTER_ID { get; set; }
        public string CLASS_YEAR { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string APPTYPE_ID { get; set; }
    }

    public class ExanSupplementarySettingForProgramme
    {
        public string PROGRAMME_SETTING_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string PROGRAMME_YEAR_ID { get; set; }
        public string PROGRAMME_YEAR { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string EXAM_NAME { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string REGISTER_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string COURSE_TITLE { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string COURSE_CODE { get; set; }
        public string EXAM_SETTING { get; set; }
        public string DEBIT { get; set; }
        public string FREQUENCY_TYPE_ID { get; set; }
        public string APPLICATION_TYPE { get; set; }
        public string REGISTERED_DATE { get; set; }
        public string ROLL_NO { get; set; }
        public string CAMPUS_ID { get; set; }
        public string FREQUENCY_ID { get; set; }
    }
    public class SupBatchDuration
    {
        public string DURATION_ID { get; set; }
        public string BATCH_ID { get; set; }
        public string APPLICATION_TYPE_ID { get; set; }
        public string DURATION { get; set; }
        public string BEGIN_YEAR { get; set; }
        public string EXPIRED_YEAR { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string CLASS_ID { get; set; }
    }
    public class ExamRegistrationCOE
    {
        public string EXAM_SETTING_ID { get; set; }
        public string SEMESTER { get; set; }
        public string STUDENT_ID { get; set; }
        public string COURSE_ROOT_ID { get; set; }
        public string STATUS { get; set; }
    }
    public class ActiveAcademicYear
    {
        public string STUDENT_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string SEMESTER { get; set; }
        public string IS_ACTIVE { get; set; }
        public string RESULT { get; set; }
    }
    public class ExamHallTicketDownload
    {
        public string HALLTICKET_DOWNLOAD_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string DOWNLOAD_DATE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
    public class ExamHalltickentDowloadReport
    {
        public string HALLTICKET_DOWNLOAD_ID { get; set; }
        public string FULL_NAME { get; set; }
        public string ROLL_NO { get; set; }
        public string EXAM_NAME { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string DOWNLOAD_DATE { get; set; }
    }


}
