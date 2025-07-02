using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AlumniMembershipCategoryDTO
    {
        public string MEMBER_CATEGORY_ID { get; set; }
        public string CATEGORY_NAME { get; set; }
        public string CATEGORY_DESCRIPTION { get; set; }
        public string FREQUENCY_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string EXPIRY_DAYS { get; set; }
        public string IS_LIFE_TIME { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
