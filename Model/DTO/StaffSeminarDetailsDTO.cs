using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StaffSeminarDetailsDTO
    {
        public string SEMINAR_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string SEMINAR_TITLE { get; set; }
        public string LECTURE_TITLE { get; set; }
        public string API_SCORE { get; set; }
        public string REGION_ID { get; set; }
        public string ORGANIZED_BY { get; set; }
        public string COLLEGE_NAME { get; set; }
        public string SEMINAR_DATE { get; set; }
        public string EVALUVATION_TYPE_ID { get; set; }
        public string DATE_OF_YEAR { get; set; }
        public string DURATION { get; set; }
        public string TOPICS_COVERED { get; set; }
        public string FEEDBACK { get; set; }
        public string PHOTO { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
