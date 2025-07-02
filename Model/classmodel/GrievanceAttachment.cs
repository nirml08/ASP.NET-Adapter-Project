using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class GrievanceAttachment
    {
        public string ATTACHMENT_ID { get; set; }
        public string GRIEVANCE_ID { get; set; }
        public string ATTACHMENT_PATH { get; set; }
        public string ATTACHMENT_NAME { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_TYPE { get; set; }
    }
}
