
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ConsultancyStudentDetailsDTO
    {
        public string CONSULTANCY_STU_ID { get; set; }    
        public string CONSULTANCY_ID { get; set; }    
        public string STUDENT_ID { get; set; }      
        public string ACADEMIC_YEAR { get; set; }    
        public string NO_OF_TRAINEE { get; set; }    
        public string CAMPUS_ID { get; set; }    
        public string IS_ACTIVE { get; set; }
        //public List<ConsultancyStudentFiles> ConsultancyStudentFileItems { get; set; }
    }
}
