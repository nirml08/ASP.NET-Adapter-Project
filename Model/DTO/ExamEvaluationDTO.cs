using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class ExamEvaluationDTO
    {
        public string EXAM_EVALUATION_ID { get; set; }
        public string INVIGILATION_ID { get; set; }
        public string EVALUATOR_ID { get; set; }
        public string EVALUATION_TYPE { get; set; }
        public string COURSE_ID { get; set; }
        public string PACKET_NO { get; set; }
        public string EVALUATION_DATE { get; set; }
        public string DUMMY_NO { get; set; }
        public string IS_COMPLETED { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
