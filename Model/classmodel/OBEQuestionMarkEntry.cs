using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class OBEQuestionMarkEntry
    {   
        public string OBE_MARKENTRY_ID { get; set; }
        public string OBE_QUESTIONPAPER_ID { get; set; }
        public string OBE_QUESTIONPAPERSTRUCTURE_ID { get; set; }
        public string OBE_QUESTIONPAPERPATTERN_ID { get; set; }
        public string QUESTION_NUMBER { get; set; }
        public string OBE_QUESTION_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string TOTAL_MARK { get; set; }
        public string SECURED_MARK { get; set; }
        public string COURSE_ID { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string ENTRY_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_DELETED { get; set; }
        public string CLASS_ID { get; set; }
        public string OBE_COMPONENT_ID { get; set; }
        public string OBE_COLEVEL_ID { get; set; }
        public string OBE_QUESTIONMARKSTRUCTURE_ID { get; set; }
        public string REGISTER_NO { get; set; }
        public string ROLL_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string CLASS_NAME { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string OBE_ABSENT_ID { get; set; }
        public string EXAM_TYPE { get; set; }
        public string OBE_QUESTIONLEVEL_ID { get; set; }
        public string OBE_RBT_LEVEL { get; set; }
        public string QUESTION_LEVEL { get; set; }
        public string PERCENTAGE { get; set; }
        public string OBE_COLEVEL { get; set; }
        public string REPORT_TYPE { get; set; }
        public string PROGRAMME { get; set; }


    }

    public class OBEFinalSubmitReport
    {
        public string OBE_EXAM_MARK_ENTERED_ID { get; set; }
        public string USER_CODE{ get; set; }
        public string FIRST_NAME { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string CLASS_NAME { get; set; }
        public string IS_DELETED { get; set; }
    }

}
