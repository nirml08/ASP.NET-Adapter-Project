﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class EmailSettings
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPass { get; set; }
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
        public string AdmissionSenderEmail { get; set; }
        public string AdmissionSenderName { get; set; }
        public string AdmissionMailPwd { get; set; }
    }
}
