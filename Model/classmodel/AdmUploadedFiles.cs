using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AdmUploadedFiles
    {
        public int? FILE_ID { get; set; }
        public string? FILE_PATH { get; set; }
        public int? FILE_TYPE_ID { get; set; }
        public int? RECEIVE_ID { get; set; }
        //public int? FILE_TYPE { get; set; }
        public int? IS_DELETED { get; set; }
        public int? IS_ACTIVE { get; set; }
        public int? ACADEMIC_YEAR { get; set; }
        public int? CAMPUS_ID { get; set; }
    }
}
