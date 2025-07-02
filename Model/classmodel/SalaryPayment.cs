using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class SalaryPayment
    {
        public string beneficiary_name { get; set; }
        public string beneficiary_account_number { get; set; }
        public string beneficiary_ifsc { get; set; }
        public string amount { get; set; }
        public string transfer_mode { get; set; }
        public string remarks { get; set; }
    }
}
