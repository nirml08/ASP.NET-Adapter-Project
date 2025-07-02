using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class EmailDTO
    {
        public string MAIL_ID{get;set;}
        public string SENDER_ID{get;set;}
        public string RECIPIENT_ID { get;set;}  
        public string SUBJECT{get;set;}
        public string BODY{get;set;}
        List<IFormFile> ATTACHMENTS { get; set; }
        public string SENT_AT{get;set;}
        public string IS_READ{get;set;}
        public string CAMPUS_ID{get;set;}
        public string ACADEMIC_YEAR { get; set; }
  
    }
}
