using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
  
     public class PublicationJournalArticale
    {
        public string PUBLICATION_JOURNAL_ARTICLE_ID { get; set; }
        public string ARTICLE_PATH { get; set; }
        public string STAFF_ID { get; set; }
        public string STAFF_NAME { get; set; }
        public string UPLOAD_DATE { get; set; }
        public string TITLE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
