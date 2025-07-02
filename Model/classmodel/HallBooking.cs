using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class HallBooking
    {
        public string HALL_BOOKING_ID{get;set;}
        public string HALL_ID{get;set;}
        public string HALL_NAME { get;set;}
        public string CAPACITY { get;set;}
        public string LOCATION { get;set;}
        public string HALL_IMAGE { get;set;}
        public string FROM_BOOKING_DATE_TIME { get;set;}
        public string TO_BOOKING_DATE_TIME { get;set;}
        public string DEPARTMENT_ID{get;set;}
        public string DEPARTMENT { get;set;}
        public string STAFF_ID{get;set;}
        public string FIRST_NAME { get;set;}
        public string PURPOSE{get;set;}
        public string STATUS{get;set;}
        public string STATUS_NAME { get;set;}
        public string CAMPUS_ID{get;set;}
        public string ACADEMIC_YEAR{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
        public string FROMDATE { get; set; }
        public string TODATE { get; set; }
    }
}
