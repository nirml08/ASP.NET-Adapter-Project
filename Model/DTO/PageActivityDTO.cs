using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class PageActivityDTO
    {
        public string PAGE_ACTIVITY_ID { get; set; }
        public string MENU_ID { get; set; }
        public string ROLE_ID { get; set; }
        public string PERMISSION { get; set; }
        public string IS_INSIDE_MENU { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
