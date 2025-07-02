using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class IQACEventDocument
    {
        public string EVENT_ID {  get; set; }
        public string EVENT_DOCUMENT_ID {  get; set; }
        public string FILE_NAME {  get; set; }
        public string FILE_PATH {  get; set; }
        public string IS_DELETED {  get; set; }
    }
}
