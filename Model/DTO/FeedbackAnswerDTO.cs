using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class FeedbackAnswerDTO
    {
        public string FB_ANSWER_ID {  get; set; }
        public string FB_SETTING_ID {  get; set; }
        public string QUESTION_ID {  get; set; }
        public string FEEDBACK_OPTION_ID {  get; set; }
        public string FEEDBACK {  get; set; }
        public string ENTRY_DATE {  get; set; }
        public string USER_ID {  get; set; }
        public string CAMPUS_ID {  get; set; }
        public string ACADEMIC_YEAR {  get; set; }
    }
}
