using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class FeedbackRole
    {
        public string SUP_FEEDBACK_ROLE_ID { get; set; }
        public string FEEDBACK_ROLE_NAME { get; set; }
        public string ASSESSOR_ROLE { get; set; }
        public string ASSESSOR_ROLE_NAME { get; set; }

        public string ASSESSEE_ROLE { get; set; }
        public string ASSESSEE_ROLE_NAME { get; set; }

        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
