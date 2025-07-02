using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class QuizOptionDTO
    {
        public string OPTION_ID { get; set; }
        public string OPTION { get; set; }
        public string QUESTION_ID { get; set; }
        public string SET_ID { get; set; }
        public string MARK { get; set; }
        public string SETTING_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ANSWER { get; set; }
    }
}
