using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class RolebasedDashboardItem
    {
        public string ROLEBASED_DASHBOARD_ID{get;set;}
        public string ROLE_ID{get;set;}
        public string ROLE_NAME { get; set; }
        public string DASHBOARD_ITEM_ID{get;set;}
        public string SHORT_NAME { get;set;}
        public string URL { get;set;}
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
