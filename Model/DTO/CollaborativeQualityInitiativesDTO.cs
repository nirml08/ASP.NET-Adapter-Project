using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class CollaborativeQualityInitiativesDTO
    {
        public string INITIATIVEID { get; set; }
        public string INSTITUTIONNAME { get; set; }
        public string PARTNERINSTITUTIONNAME { get; set; }
        public string COLLABORATIVE_NAME { get; set; }
        public string COLLABORATIVE_DESCRIPTION { get; set; }
        public string ACTIVITY { get; set; }
        public string STARTDATE { get; set; }
        public string ENDDATE { get; set; }
        public string DESCRIPTION { get; set; }
        public string OUTCOME { get; set; }
        public string CAMPUS_ID { get; set; }
        public string EVENT_ID { get; set; }
        public string ACADEMICYEAR { get; set; }
        public string FILEPATH { get; set; }
        public string CREATEDAT { get; set; }
        public string UPDATEDAT { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
    }
}
