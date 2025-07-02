using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class HallDetails
    {
        public string HALL_ID{get;set;}
        public string HALL_NAME{get;set;}
        public string HALL_PREFIX{get;set;}
        public string CAPACITY{get;set;}
        public string LOCATION{get;set;}
        public string IS_AVAILABLE{get;set;}
        public string CAMPUS_ID{get;set;}
        public string HALL_IMAGE_FILE { get; set; }
        public string HALL_IMAGE{get;set;}
        public string ACADEMIC_YEAR{get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
