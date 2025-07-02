using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class InsideMenuDTO
    {
        public string INSIDE_MENU_ID { get; set; }
        public string INSIDE_MENU_NAME { get; set; }
        public string MENU_ID { get; set; }
        public string PARENT_ID { get; set; }
        public string URL { get; set; }
        public string ICON { get; set; }
        public string ORDER { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
