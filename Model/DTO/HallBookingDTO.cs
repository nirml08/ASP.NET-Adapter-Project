using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class HallBookingDTO
    {
        public string HALL_BOOKING_ID { get; set; }
        public string HALL_ID { get; set; }   
        public string FROM_BOOKING_DATE_TIME { get; set; }
        public string TO_BOOKING_DATE_TIME { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string PURPOSE { get; set; }
        public string STATUS { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
