using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class NMESettings
    {
        public string SETTINGS_ID { get; set; }
        public string SETTINGS_NAME { get; set; }
        public string CLASS_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string SETTING_CLASS_NAME { get; set; }

        public string DATE_FROM { get; set; }
        public string DATE_TO { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ALLOWED { get; set; }
        public string IS_DELETED { get; set; }
        public string SEMESTER_ID { get; set; }
        public string SEMESTER { get; set; }

        public string SEMESTER_NAME { get; set; }
        public string PROGRAMME_LEVEL_ID { get; set; }

        public string PROGRAMME_LEVEL { get; set; }
        public string TIME_FROM { get; set; }
        public string TIME_TO { get; set; }
        public string IS_CLASS_WISE_QUOTA { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
