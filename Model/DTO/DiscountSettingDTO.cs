using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class DiscountSettingDTO
    {
        public string DISCOUNT_SETTING_ID { get; set; }
        public string DISCOUNT_NAME { get; set; }
        public string FREQUENCY { get; set; }
        public string DISCOUNT_GROUP_ID { get; set; }
        public string MAX_DISCOUNT { get; set; }
        public string MIN_DISCOUNT { get; set; }
        public string DISCOUNT_PERCENTAGE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }

        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
