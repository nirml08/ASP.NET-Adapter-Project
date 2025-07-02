using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class TaskSetting
    {
        public string TASK_ID { get; set; }
        public string TASK_NAME { get; set; }
        public string LAST_DATE { get; set; }
        public string SEMESTER { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string COMPONENT_ID { get; set; }
        public string COMPONENT { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
