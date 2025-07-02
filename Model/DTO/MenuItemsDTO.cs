using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class MenuItemsDTO
    {
        public string MENU_ID { get; set; }
        public string MENU_NAME { get;set; }
        public string PARENT_ID { get; set; }  
        public string URL { get; set; }
        public string ICON { get; set; }
        public string ORDER { get; set; }
        public string CONTROLLER { get; set; }
        public string ACTION { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_SUB { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
