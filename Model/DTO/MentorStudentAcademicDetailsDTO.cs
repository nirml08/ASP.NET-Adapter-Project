using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class MentorStudentAcademicDetailsDTO
    {
        public string STU_ACADEMIC_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string SSLC_PERCENTAGE { get; set; }
        public string SSLC_GROUP { get; set; }
        public string HSC_PERCENTAGE { get; set; }
        public string HSC_GROUP { get; set; }
        public string UG_YEAR1_PERCENTAGE { get; set; }
        public string UG_YEAR2_PERCENTAGE { get; set; }
        public string UG_YEAR3_PERCENTAGE { get; set; }
        public string UG_YEAR4_PERCENTAGE { get; set; }
        public string UG_PROGRAMME { get; set; }
        public string EXTRA_QUALIFICATION { get; set; }
        public string EXTRA_QUALIFICATION_PERCENTAGE { get; set; }
        public string ACHIEVEMENTS { get; set; }
        public string HOBBIES { get; set; }
        public string ADDITIONAL_SKILLS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
