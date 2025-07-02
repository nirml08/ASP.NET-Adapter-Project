using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AdmissionModel
    {
        public string RECEIVE_STUID { get; set; }    
        public string APPLICATION_NO { get; set; }
        public string RECEIVE_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string PROGRAMME_LEVEL { get; set; }
        public string SELECTION_TYPE { get; set; }  
        public string STATUS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ISSUED_ID { get; set; }
        public string USER_ID { get; set; }
        public string SELECTION_CYCLE { get;set; }

        public string ACADEMIC_YEAR { get; set; }
        public string REASON { get; set; }

        public string COMMUNITY_ID { get; set; }
        public string IS_MINORITY { get; set; }
        public string IS_ROMAN_CATHOLIC { get;set; }
        public string FREQUENCY_ID { get; set; }
        public string SELECTION_ID { get; set; }
        public string IS_VERIFIED { get; set; } 
        public string FIELDS { get; set; } 
        public string FIELDS_ID { get; set; } 
        public string USER_TYPE { get; set; } 
        public string BATCH { get; set; } 

    }

    public class AdmissionStudentClass
    {
        public string CLASS_ID { get; set; }
        public string PROGRAMME_ID { get; set; }
        public string RECEIVE_ID { get; set; }
        public string APPLICATION_NO { get; set; }
    }

    public class AdmissionRollNoCreation
    {
        public string RECEIVE_ID { get; set; }
        public string RUN_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string SHIFT { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string PROGRAMME_MODE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string DEPARTMENT { get; set; }
        public string APPLICATION_NO { get; set; }
    }

    public class SaveAdmissionNo
    {
        public string STUDENT_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string ADMISSION_NO { get; set; }
    }
}
