using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ReserveStatus
    {
        public string RESERVE_STATUS_ID { get; set; }
        public string RESERVE_STATUS { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
}
