using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class MailUserTemplate
    {
        public string USER_TEMPLATE_ID { get; set; }
        public string TEMPLATE_ID { get; set; }
        public string TEMPLATE_NAME { get; set; }
        public string TEMPLATE_TEXT { get; set; }
        public string Email { get; set; }
        public string FIELDS_IDS { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
