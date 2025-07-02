using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class Consultancy
    {
        public string CONSULTANCY_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string STAFF_NAME { get; set; }
        public string CONSULTANCY_PROJECT_NAME { get; set; }
        public string SPONSORSHIP_NAME { get; set; }
        public string CONSULTANCY_STU_ID { get; set; }
        public string CONSULTANCY_CONTACT { get; set; }
        public string CONSULTANCY_ADDRESS { get; set; }
        public string AMOUNT { get; set; }
        public string SUPPORTING_SPONSOR { get; set; }
        public string FILE_PATH { get; set; }
        public string FILE_NAME { get; set; }
        public string CONSULTANCY_TYPE_ID { get; set; }
        public string CONSULTANCY_TYPE_NAME { get; set; }
        public string CONSULTANCY_FILE_ID { get; set; }
        public string NO_STUDENTS { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CREATED_AT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public List<IQACConsultancyFiles> ConsultancyFileItems { get; set; }


    }
}
