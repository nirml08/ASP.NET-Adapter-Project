using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AcademicAdministrativeAuditDTO
    {
        public string AUDITID { get; set; }
        public string AUDITDATE { get; set; }
        public string AUDIT_NAME { get; set; }
        public string AUDIT_DESCRIPTION { get; set; }
        public string DEPARTMENTID { get; set; }
        public string AUDITORNAME { get; set; }
        public string AUDIT_TYPE_ID { get; set; }
        public string FINDINGS { get; set; }
        public string RECOMMENDATIONS { get; set; }
        public string ACTIONPLAN { get; set; }
        public string RESPONSIBLEPERSON { get; set; }
        public string DUEDATE { get; set; }
        public string REMARKS { get; set; }
        public string ACADEMICYEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CREATEDAT { get; set; }
        public string UPDATEDAT { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
        
    }
}
