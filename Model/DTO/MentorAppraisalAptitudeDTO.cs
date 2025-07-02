using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public  class MentorAppraisalAptitudeDTO
    {
        public string MENTOR_SPECIAL_APTITUDE_ID {  get; set; }
        public string APPRISAL_SETTING_ID {  get; set; }
        public string STUDENT_ID {  get; set; }
        public string SPECIAL_APTITUDE {  get; set; }
        public string CONCLUDING_REMARK {  get; set; }
        public string MENTOR_CONCLUDING_REMARK_ID {  get; set; }
        public string POSITIVE {  get; set; }
        public string ENHANCEMENT_AREAS {  get; set; }
        public string FACULTY {  get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
