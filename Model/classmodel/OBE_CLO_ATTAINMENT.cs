using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class OBE_CLO_ATTAINMENT
    {
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }

        public string OBE_COLEVEL { get; set; }
        public string AVG { get; set; }
        public string EXAM_TYPE { get; set; }
        public string OBE_CLO_ATTAINMENT_ID { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string EXTERNAL_SEC { get; set; }
        public string EXTERNAL { get; set; }
        public string INTERNAL_SEC { get; set; }
        public string INTERNAL { get; set; }
        public string TOTAL_ATTAINMENT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }

        //Extra
        public string CO_ATTAINMENT_ID { get; set; }
        public string CLASS_ID { get; set; }

        public string COMPONENT_ID { get; set; }
        public string CO_LEVEL { get; set; }
        public string RBT_LEVEL { get; set; }
        public string NO_OF_STUDENT { get; set; }
        public string THRESSHOLD { get; set; }
        public string ATTAINMENT { get; set; }
        public string POINTSCALE { get; set; }
        public string OBE_CO_PO_MATRIX_ID { get; set; }
        public string OBE_COLEVEL_ID { get; set; }

        public string OBE_POLEVEL_ID { get; set; }
        public string OBE_CO_PO_MARK { get; set; }
        public string OBE_CO_PO_ATTAINMENT_ID { get; set; }

        public string OBE_POLEVEL { get; set; }
        public string EXAM_NAME { get; set; }
        public string OBE_MAPPING_ID { get; set; }

    }
}
