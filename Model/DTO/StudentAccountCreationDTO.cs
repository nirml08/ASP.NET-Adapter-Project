using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StudentAccountCreationDTO
    {
        public string STUDENT_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string FREQUENCY { get; set; }
        
        public string PROGRAMME_GROUP_ID { get; set; }
        public string CLASS_YEAR_ID { get; set; }
       
    }
}
