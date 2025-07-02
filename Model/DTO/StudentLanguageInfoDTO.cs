using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StudentLanguageInfoDTO
    {
        public string STU_LANGUAGE_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string LANGUAGE_ID { get; set; }
        public string IS_READ { get; set; }
        public string IS_WRITE { get; set; }
        public string IS_SPEAK { get; set; }

    }
}
