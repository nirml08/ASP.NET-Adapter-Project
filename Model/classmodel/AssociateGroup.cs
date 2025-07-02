using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AssociateGroup
    {
        public string ASSOCIATE_GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string INCHARGE_NAME { get; set; }
        public string INCHARGE_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string EVALUVATION_TYPE_ID { get; set; }
        public string EVALUVATION_TYPE { get; set; }
        public string DATE_OF_YEAR { get; set; }
        public string LOGO_PATH { get; set; }
        public string INITIATED_ON { get; set; }
        public string CREATED_ON { get; set; }
        public string CREATED_BY { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        // Extra
        public string PHOTO_PATH { get; set; }
    }
}
