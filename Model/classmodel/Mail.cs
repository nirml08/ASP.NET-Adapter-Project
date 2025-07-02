using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class Mail
    {
        public string MAIL_ID{get;set;}
        public string SENDER_ID{get;set;}
        public string SENDER_NAME { get;set;}
        public string RECIPIENT_ID { get;set;}
        public string RECEIVER_NAME { get;set;}
        public string SUBJECT{get;set;}
        public string BODY{get;set;}
        public string SENT_AT{get;set;}
        public string IS_READ{get;set;}
        public string CAMPUS_ID{get;set;}
        public string ACADEMIC_YEAR{get;set;}

        public string ATTACHMENT_ID{get;set;}
        public string FILE_PATH{get;set;}
        public string FILE_NAME{get;set;}
        public string UPLOAD_AT{get;set;}
        public string MAIL_RECIPIENTS_ID{get;set;}
              
        public string IS_ACTIVE{get;set;}
        public string IS_DELETED { get; set; }
    }
}
