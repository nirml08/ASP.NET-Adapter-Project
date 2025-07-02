using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamInstruction
    {
        public string INSTRUCT_ID { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string INSTR_NAME { get; set; }
        public string INSTRUCTION { get; set; }
        public string DATE { get; set; }
        public string EXAM_NAME { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
