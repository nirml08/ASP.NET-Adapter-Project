using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class BankAccountDTO
    {
        public string BANK_ACCOUNT_ID{get;set;}
        public string ACCOUNT_PURPOSE{get;set;}
        public string BANK{get;set;}
        public string PASSBOOK_NO{get;set;}
        public string STARTED_DATE{get;set;}
        public string CLOSED_DATE{get;set;}
        public string CAMPUS_ID{get;set;}
        public string IS_DELETED { get; set; }
    }
}
