using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StuFolioNumberDTO
    {
        public string FOLIO_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string CERTIFICATE_TYPE { get; set; }
        public string SEMESTER_ID { get; set; }
        public string BATCH_ID { get; set; }
        public string APPLICATION_TYPE { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
