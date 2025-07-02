using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class EventSupportDocument
    {
        public string SUPPORT_DOCUMENT_ID { get; set; }
        public string EVENT_ID { get; set; }
        public string EVENT_TITLE { get; set; }
        public string FILE_PATH { get; set; }
        public string FILE_PATH_CONVERTED { get; set; }
        public string FILE_NAME { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ENTRY_ID { get; set; }
        public string IS_FINANCE_DOC { get; set; }
        public string IS_GEO_DOC { get; set; }
        public string IS_RELATED_DOC { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_PDF { get; set; }
        public string IS_DELETED { get; set; }
    }
}
