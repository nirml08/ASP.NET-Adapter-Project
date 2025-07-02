using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class MultiMailDTO
    {
        public string MAIL_ID { get; set; }
        public string SENDER_NAME { get; set; }
        public string SENDER_MAIL { get; set; }
        public string SENDER_MAIL_PASSWORD { get; set; }
        public List<string> RECIPIENT_MAIL { get; set; }
        public string SUBJECT { get; set; }
        public string BODY { get; set; }
        public List<string>? ATTACHMENTS { get; set; }
        public string SENT_AT { get; set; }
        public string IS_READ { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
    }

    public class EmailMessage
    {
        public string RecipientMail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<string> Attachments { get; set; }
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
    }
}
