using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExaminerOrder
    {
        public string STAFF_ALLOTED_ID { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string EXAM_NAME { get; set; }

        public string ACADEMIC_YEAR { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string DEPARTMENT { get; set; }

        public string STAFF_ID { get; set; }
        public string STAFF_CODE { get; set; }
        public string FIRST_NAME { get; set; }

        public string ORDER_DATE { get; set; }
        public string DUE_DATE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
