using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AppointmentsDTO
    {
        public string APPOINTMENT_ID { get; set; }
        public string REQUEST_TYPE { get; set; }
        public string NAME { get; set; }
        public string DEPARTMENT { get; set; }
        public string DATE_TIME { get; set; }
        public string PURPOSE { get; set; }
        public string STAFF_ID { get; set; }
        public string STATUS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        
    }
}
