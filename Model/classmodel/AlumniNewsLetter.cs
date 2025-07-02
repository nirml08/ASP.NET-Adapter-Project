using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AlumniNewsLetter
    {
        public string NEWSLETTER_ID { get; set; }
        public string NEWSLETTER_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string FILE_PATH { get; set; }
        public string FROM_BATCH { get; set; }
        public string TO_BATCH { get; set; }
        public string ENTERED_DATE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_OPEN { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
