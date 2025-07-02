using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class SaveUserDetailsDTO
    {
        public string USER_ID { get; set; }
        public string USER_CODE { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string FULL_NAME { get; set; }
        public string GENDER { get; set; }
        public string DOB { get; set; }
        public string USER_TYPE { get; set; }
        public string COMMUNITY { get; set; }
        public string NATIONALITY { get; set; }
        public string CASTE { get; set; }
        public string RELIGION { get; set; }
        public string DEPARTMENT { get; set; }
        public string PROGRAMME { get; set; }
        public string BATCH { get; set; }
        public string CATEGORY { get; set; }
        public string BARCODE { get; set; }
        public string MOBILE_NO { get; set; }
        public string MAIL_ID { get; set; }
        public string AADHAR_NO { get; set; }
        public string RFID { get; set; }
        public string GSUITE_MAIL_ID { get; set; }
        public string GSUITE_PASSWORD { get; set; }
        public string DOJ { get; set; }
        public string IS_FULL_TIME { get; set; }
        public string IS_PART_TIME { get; set; }
        public string DOL { get; set; }
        public string CAMPUS_ID { get; set; }
        public string PHOTO_PATH { get; set; }
        public string ADDRESS { get; set; }
        public string REGISTER_NO { get; set; }
        public string ROLL_NO { get; set; }
        public string SIGNATURE { get; set; }
        public string FATHER_NAME { get; set; }
        public string MOTHER_NAME { get; set; }
        public string IS_LEFT { get; set; }
        public string PAN_NO { get; set; }
        public string IS_PERMANANT { get; set; }
        public string RESIDENCE_ID { get; set; }
        public string HEIGHT { get; set; }
        public string WEIGHT { get; set; }
        public string BLOOD_GROUP_ID { get; set; }
    }

    public class UpdateStudentDetails
    {
        public string USER_ID { get; set; }
        public string RELIGION { get; set; }
        public string COMMUNITY { get; set; }
        public string RESIDENCE_ID { get; set; }
        public string HEIGHT { get; set; }
        public string WEIGHT { get; set; }
        public string BLOOD_GROUP_ID { get; set; }
        public string MAIL_ID { get; set; }
        public string MOBILE_NO { get; set; }
        public string ADDRESS { get; set; }
        public string NATIONALITY { get; set; }
    }

    public class UpdateStudentFamilyDetails
    {
        public string USER_ID { get; set; }
        public string FAMILY_TYPE_ID { get; set; }
        public string FATHER_QUALIFICATION { get; set; }
        public string MOTHER_QUALIFICATION { get; set; }
        public string GUARDIAN_QUALIFICATION { get; set; }
        public string FATHER_ANNUAL_INCOME { get; set; }
        public string MOTHER_ANNUAL_INCOME { get; set; }
        public string GUARDIAN_ANNUAL_INCOME { get; set; }
        public string FR_OCCUPATION { get; set; }
        public string MR_OCCUPATION { get; set; }
        public string GUARDIAN_OCCUPATION { get; set; }
        public string NO_OF_BROTHERS { get; set; }
        public string NO_OF_SISTERS { get; set; }
        public string REMARKS { get; set; }
        public string FATHER_NAME { get; set; }
        public string MOTHER_NAME { get; set; }
    }

    public class StudentHealthDetails
    {
        public string USER_ID { get; set; }
        public string IS_PHYSICALLY_CHALLENGED { get; set; }
        public string IS_HOSPITALIZED { get; set; }
        public string HOSPITALIZED_REASON { get; set; }
        public string IS_SERIOUS_ILL { get; set; }
        public string ILL_COUNT { get; set; }
        public string IS_HAVE_ALERGY { get; set; }
        public string ALERGY_DESCRITION { get; set; }
        public string DISABILITY_TYPE_ID { get; set; }
    }

    public class StudentValuesandHabits
    {
        public string USER_ID { get; set; }
        public string GOAL { get; set; }
        public string STRENGTH { get; set; }
        public string WEAKNESS { get; set; }
        public string ROLE_MODEL { get; set; }
    }
}
