using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class InvitedLecturesDTO
    {
        public string HR_INVITED_LECTURE_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string BOOK_CATEGORY_ID { get; set; }
        public string LECTURE_TITLE { get; set; }
        public string EVENT_NAME { get; set; }
        public string ORGANIZING_INSTITUTION { get; set; }
        public string EVENT_DATE { get; set; }
        public string LOCATION { get; set; }
        public string DURATION { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
    }
}
