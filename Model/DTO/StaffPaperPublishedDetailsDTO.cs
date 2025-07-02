using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StaffPaperPublishedDetailsDTO
    {
        public string STF_PAPERPUBLISHED_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string TITLE { get; set; }
        public string ABSTRACT { get; set; }
        public string PUBLICATION_DATE { get; set; }
        public string JOURNALNAME { get; set; }
        public string VOLUME { get; set; }
        public string ISSUE { get; set; }
        public string PAGES { get; set; }
        public string IS_RESEARCHED { get; set; }
        public string REGION_ID { get; set; }
        public string CHAPTER_TEXT { get; set; }
        public string ISBN_NO { get; set; }
        public string CHAPTER_PATH { get; set; }
        public string E_BROCHURE_PATH { get; set; }
        public string BOOK_CATEGORY_ID { get; set; }
        public string DOI { get; set; }
        public string KEYWORDS { get; set; }
        public string COAUTHORS { get; set; }
        public string RESEARCH_AREA { get; set; }
        public string CREATED_AT { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
