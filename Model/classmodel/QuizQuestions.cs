using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class QuizQuestions
    {
        public string QUESTION_ID { get; set; }
        public object QUESTION { get; set; }
        public string ANSWER { get; set; }
        public string CLASS_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE { get; set; }
        public string STAFF_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string OPTION_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string OPTIONS { get; set; }
        public object A { get; set; }
        public object B { get; set; }
        public object C { get; set; }
        public object D { get; set; }
        public string E { get; set; }
        public string F { get; set; }
        public string CODE { get; set; }
        public string SET { get; set; }
        public string MARK { get; set; }
    }
}
