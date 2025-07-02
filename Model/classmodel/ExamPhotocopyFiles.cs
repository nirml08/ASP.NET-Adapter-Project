using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamPhotocopyFiles
    {
        public string EXAM_PHOTOCOPY_FILE_ID { get; set; }
        public string EXAM_PHOTOCOPY_REGISTER_ID { get; set; }
        public string PHOTOCOPY { get; set; }
        public string COURSE_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string File {  get; set; }
        

    }
}
