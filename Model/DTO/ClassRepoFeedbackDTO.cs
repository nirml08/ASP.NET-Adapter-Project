
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ClassRepoFeedbackDTO
    {

        public string FEEDBACK_ID { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string DATE_TIME { get; set; }
        public string VENUE { get; set; }
        public string MEETING_AGENDA { get; set; }
        public string CLASS_ID { get; set; }
        public string FEEDBACK_STUDENT { get; set; }
        public string SUGGESTIONS_FOR_IMPROVEMENT { get; set; }
        public string MAINTENANCE_REQUIREMENTS { get; set; }
        public string ATTENDANCE_PERCENTAGE { get; set; }
        public string ENTRY_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        //public List<ClassRepoFeedbackFaculty> classrepofeedbackfaculties { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ATTENDANCE_PERCENT_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
