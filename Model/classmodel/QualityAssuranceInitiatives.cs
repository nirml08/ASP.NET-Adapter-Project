using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class QualityAssuranceInitiatives
    {
        public string EVENTID { get; set; }
        public string PARTICIPANT_DESCRIPTION { get; set; }
        public string COLLABORATIVE_NAME { get; set; }
        public string COLLABORATIVE_DESCRIPTION { get; set; }
        public string AUDIT_NAME { get; set; }
        public string AUDIT_DESCRIPTION { get; set; }
        public string PARTICIPANT_NAME { get; set; }
        public string EVENTDATE { get; set; }
        public string EVENTTITLE { get; set; }
        public string CAMPUS { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string VENUE { get; set; }
        public string DATE { get; set; }
        public string AUDITID { get; set; }
        public string AUDITORNAME { get; set; }
        public string FINDINGS { get; set; }
        public string ACTIONPLAN { get; set; }
        public string RESPONSIBLEPERSON { get; set; }
        public string PARTICIPATIONID { get; set; }
        public string SCORE { get; set; }
        public string RANK { get; set; }
        public string ISO { get; set; } = "0";
        public string NBA { get; set; } = "0";
        public string INITIATIVEID { get; set; }
        public string INSTITUTIONNAME { get; set; }
        public string PARTNERINSTITUTIONNAME { get; set; }
    }
}
