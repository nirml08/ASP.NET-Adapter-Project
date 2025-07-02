
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AlumniEventGalleryDTO
    {
        public string EVENT_GALLERY_ID { get; set; }
        public string EVENT_TITLE { get; set; }
        public string EVENT_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        //public List<AlumniEventGalleryItems> GalleryItems { get; set; }
    }
}
