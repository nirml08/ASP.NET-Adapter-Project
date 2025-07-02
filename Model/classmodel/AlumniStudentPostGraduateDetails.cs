using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AlumniStudentPostGraduateDetails
    {
        public string PG_DETAIL_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string FULL_NAME { get; set; }
        public string ROLL_NO { get; set; }
        public string REGISTER_NO { get; set; }
        public string YEAR_OF_PASSING { get; set; }
        public string COURSE { get; set; }
        public string INSTITUTION { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CREATEDAT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
