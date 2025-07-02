using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class Alumni
    {

    }
    public class AlumniStudentInfoDTO
    {
        public string ALUMNI_STUDENT_ID { get; set; }
        public string USER_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string NAME { get; set; }
        public string DEPARTMENT { get; set; }
        public string EMAIL { get; set; }
        public string PHONE_NO { get; set; }
        public string GRADUATION_YEAR { get; set; }
        public string COURSE { get; set; }
        public string GENDER { get; set; }

        public string PHOTO { get; set; }
        public string PHOTO_FILE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string ACADEMIC_YEAR { get; set; }

    }

    public class AlumniStudentInfo
    {
        public string ALUMNI_STUDENT_ID { get; set; }
        public string USER_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string NAME { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string DEPARTMENT { get; set; }
        public string EMAIL { get; set; }
        public string PHONE_NO { get; set; }
        public string GRADUATION_YEAR { get; set; }
        public string COURSE { get; set; }
        public string GENDER { get; set; }
        public string GENDER_ID { get; set; }
        public string GENDER_NAME { get; set; }
        public string PHOTO { get; set; }
        public string PHOTO_FILE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
    public class AlumniProfessionalInfo
    {
        public string ALUMNI_PROFESSIONAL_INFO_ID { get; set; }
        public string USER_ID { get; set; }
        public string JOB_TITLE { get; set; }
        public string COMPANY_NAME { get; set; }
        public string LOCATION { get; set; }
        public string DURATION { get; set; }
        public string ROLE { get; set; }
        public string INCOME { get; set; }
        public string ORGANIZATION { get; set; }
        public string EXPERIENCE { get; set; }
        public string INSTITUTION { get; set; }
        public string EXPERTISE { get; set; }
        public string YEAR_OF_JOINING { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
