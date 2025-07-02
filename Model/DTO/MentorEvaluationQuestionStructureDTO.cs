using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class MentorEvaluationQuestionStructureDTO
    {
        public string EVALUATION_QUESTION_STRUCTURE_ID {  get; set; }
        public string MAIN_QUESTION_ID {  get; set; }
        public string SUB_QUESTION_ID {  get; set; }
        public string SEMESTER_TYPE {  get; set; }
        public string ACADEMIC_YEAR {  get; set; }
        public string CAMPUS_ID {  get; set; }
    }
}
