using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class IQACCriteriaMapping
    {
        public string CRITERIA_MAPPING_ID { get; set; }
        public string CRITERIA_ID { get; set; }
        public string CRITERIA_CODE { get; set; }
        public string CRITERIA_NAME { get; set; }
        public string CATEGORY_ID { get; set; }
        public string CATEGORY { get; set; }
        public string SUB_CATEGORY_ID { get; set; }
        public string SUB_CATEGORY { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
