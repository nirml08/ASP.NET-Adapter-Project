using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class SupCocurricularSubCriteria
    {
        public string SUB_CRITERIA_ID { get; set; }
        public string MAIN_CRITERIA_ID { get; set; }
        public string MAIN_CRITERIA { get; set; }
        public string SUB_CRITERIA { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
