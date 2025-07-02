using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StaffHonorsDTO
    {
        public string STF_HONOR_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string HONOR_TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public string DATE_RECEIVED { get; set; }
        public string ISSUING_ORGANIZATION { get; set; }
        public string PHOTO { get; set; }
        public string CREATED_AT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
