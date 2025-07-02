using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class MentorApprisalMark
    {
        public string STUDENT_APPRAISAL_MARK_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string QUESTION_ID { get; set; }
        public string STU_MARK { get; set; }
        public string STAFF_MARK { get; set; }
        public string SETTING_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADAMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }

        // Extra
        public string MENTOR_QUESTION_ID { get; set; }
        public string MENTOR_MAIN_TOPIC_ID { get; set; }
        public string MAIN_TOPIC_NAME { get; set; }
        public string MENTOR_SUP_TOPIC_ID { get; set; }
        public string SUP_TOPIC_NAME { get; set; }
        public string QUESTION_TEXT { get; set; }
        public string IS_TEXT_AREA { get; set; }
        public string MENTOR_MAIN_HEAD_REMARK_ID { get; set; }
        public string REMARK { get; set; }
        public string MENTOR_SPECIAL_APTITUDE_ID { get; set; }
        public string SPECIAL_APTITUDE { get; set; }
        public string MENTOR_CONCLUDING_REMARK_ID { get; set; }
        public string CONCLUDING_REMARK { get; set; }
        public string POSITIVE { get; set; }
        public string ENHANCEMENT_AREAS { get; set; }
        public string FACULTY { get; set; }
        public string FACULTY_NAME { get; set; }
        public string AVERAGE_MARK { get; set; }
        public string ROLL_NO { get; set; }
        public string PHOTO_PATH { get; set; }
        public string REGISTER_NO { get; set; }
        public string FIRST_NAME { get; set; }
        //
        public string PEER_APPRAISAL_MARK_ID { get; set; }
        public string PEER_MARK { get; set; }
        public string PEER_ID { get; set; }
        //
        public string STAFF_APPRAISAL_MARK_ID { get; set; }
        public string PEER_AVG_MARK { get; set; }
        public string STAFF_AVG_MARK { get; set; }
    }
}
