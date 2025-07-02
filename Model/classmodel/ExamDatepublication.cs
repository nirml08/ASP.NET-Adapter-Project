using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamDatepublication
    {
        public string PUBLICATION_ID { get; set; }
        public string APPLICATION_TYPE { get; set; }
        public string BATCH_ID { get; set; }
        public string DATE_OF_PUBLICATION { get; set; }
        public string CERTIFICATE_TYPE { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        // Extra
        public string PROGRAMME_LEVEL { get; set; }
        public string BATCH { get; set; }
        public string CERTIFICATE_NAME { get; set; }
        public string EXAM_NAME { get; set; }
    }
}
