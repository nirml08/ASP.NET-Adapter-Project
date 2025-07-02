using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AlumniMembershipSettingDTO
    {
        public string MEMBER_SETTING_ID { get; set; }
        public string SETTING_NAME { get; set; }
        public string BATCH_ID { get; set; }
        public string MEMBER_CATEGORY_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
