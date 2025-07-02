using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamTimeTable
    {
        public string TIMETABLE_ID { get; set; }
        public string EXAM_DATE { get; set; }
        public string EXAM_TIME { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string EXAM_SESSION_ID { get; set; }
        public string STATUS { get; set; }
        public string SESSION_TYPE { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        
        public string COURSE_TITLE { get; set; }
        public string EXAM_NAME { get; set; }
        public string EXAM_SESSION { get; set; }
        public string TOTAL { get; set; }
        public string PACKET_COUNT { get; set; }
        public string REGISTER_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string SEMESTER_ID { get; set; }
        public string EXAM_TYPE { get; set; }
        public string EXTERNAL { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string DEPARTMENT { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
