using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class EventGalleryItemsDTO
    {
        public string EVENT_GALLERY_ITEM_ID { get; set; }
        public string EVENT_ID { get; set; }
        public string IMAGE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
