using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class HostelStudent
    {
        public string STU_HOSTEL_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string ROLL_NO { get; set; }

        public string HOSTEL_ID { get; set; }
        public string HOSTEL_NAME { get; set; }

        public string ROOM_NO { get; set; }      
        public string BLOCK_INCHARGE { get; set; }
        public string ADMITTED_YEAR { get; set; }
        public string ROLE { get; set; }
        public string ROLE_NAME { get; set; }

        public string ADMITTED_DATE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_LEFT { get; set; }
        public string IS_DELETED { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
