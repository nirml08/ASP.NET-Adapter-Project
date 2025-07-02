using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class RolesRights
    {
        public string USER_RIGHTS_ID { get; set; }
        public string MENU_ITEM_ID { get; set; }
        public string MENU_NAME { get; set; }

        public string MODIFY { get; set; }
        public string ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }

        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string MENU_ORDER { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
