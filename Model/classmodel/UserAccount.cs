using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class UserAccount
    {
        public string USER_ACCOUNT_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string NAME { get; set; }
        public string LAST_LOGIN { get; set; }
        public string USER_ID { get; set; }
        public string ROLE { get; set; }
        public string ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }


        public string USER_TYPE { get; set; }
        public string USER_TYPE_ID { get; set; }

        public string PHOTO { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CAMPUS_NAME { get; set; }

        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string USER_TYPE_NAME { get; set; }

        public string CONTROLLER_NAME { get; set; }
        public string ACTION_NAME { get; set; }
        public string MAIL_ID { get; set; }
        public string GSUITE_MAIL_ID { get; set; }
        public string GSUITE_PASSWORD { get; set; }

    }
}
