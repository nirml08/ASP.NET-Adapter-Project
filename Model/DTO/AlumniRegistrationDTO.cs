using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AlumniRegistrationDTO
    {
        // ud
        public string USER_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string FULL_NAME { get; set; }
        public string GENDER { get; set; }
        public string DOB { get; set; }
        public string NATIONALITY { get; set; }
        public string BATCH { get; set; }
        public string COURSE { get; set; }
        public string DEPARTMENT { get; set; }
        public string PROGRAMME { get; set; }
        public string MOBILE_NO { get; set; }
        public string MAIL_ID { get; set; }
        public string PHOTO { get; set; }
        public string REGISTER_NO { get; set; }
        public string ROLL_NO { get; set; }
        public string USER_TYPE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string GRADUATION_YEAR { get; set; }

        // professional
        public string JOB_TITLE { get; set; }
        public string COMPANY_NAME { get; set; }
        public string LOCATION { get; set; }
        public string DURATION { get; set; }
        public string ROLE { get; set; }
        public string INCOME { get; set; }
        public string ORGANIZATION { get; set; }
        public string INSTITUTION { get; set; }
        public string EXPERIENCE { get; set; }
        public string EXPERTISE { get; set; }
        public string YEAR_OF_JOINING { get; set; }
        //
        public string ALUMNI_STUDENT_ID { get; set; }
        public string ALUMNI_PROFESSIONAL_INFO_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }

        // Academic Details
        public string ALUMNI_ACADEMIC_IDd { get; set; }
        public string UG_ROLL_NO { get; set; }
        public string UG_REGISTER_NO { get; set; }
        public string UG_GRADUATION_YEAR { get; set; }
        public string UG_BATCH { get; set; }
        public string UG_DEPARTMENT { get; set; }
        public string UG_COURSE { get; set; }
        public string UG_INSTITUION { get; set; }
        //public string PG_ROLL_NO { get; set; }
        //public string PG_REGISTER_NO { get; set; }
        //public string PG_COURSE { get; set; }
        //public string PG_INSTITUION { get; set; }
        //public string PG_PASSOUT_YEAR { get; set; }
        public List<PostGraduateDTO> PostGraduateDTO { get; set; }
        public List<PHDDetailsDTO> PHDDetailsDTO { get; set; }
        public string NATIONAL_LEVEL_COURSE { get; set; }
        public string STATE_LEVEL_COURSE { get; set; }
    }

    public class PostGraduateDTO
    {
        public string PG_DETAIL_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string REGISTER_NO { get; set; }
        public string YEAR_OF_PASSING { get; set; }
        public string COURSE { get; set; }
        public string INSTITUTION { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CREATEDAT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }

    public class PHDDetailsDTO
    {
        public string PHD_DETAIL_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string INSTITUTION { get; set; }
        public string FIELD_OF_RESEARCH { get; set; }
        public string YEAR_OF_AWARD { get; set; }
        public string IS_COMPLETED { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CREATEDAT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
