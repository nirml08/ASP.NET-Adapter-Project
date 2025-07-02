using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class SelectionProcessDTO
    {
        public string SELECTION_ID { get; set; }
        public string APPLICATION_NO { get; set; }
        public string APPLICATION_TYPE_ID { get; set; }
        public string PROGRAMME_ID { get; set; }
        public string SELECTION_DATE { get; set; }
        public string SELECTION_TYPE { get; set; }
        public string SELECTION_CYCLE { get; set; }
        public string ENTRANCE_MARK { get; set; }
        public string TOTAL_CUT_OFF_MARK { get; set; }
        public string TOTAL_SECURED { get; set; }
        public string MAX_TOTAL { get; set; }
        public string SELECTED_BY { get; set; }
        public string VERIFIED_BY { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_FEE_PAID { get; set; }
        public string RECEIVE_ID { get; set; }
        public string IS_VERIFIED { get; set; }
        public string IS_TRANSFERED { get; set; }
        public string IS_CANCELED { get; set; }
        public string IS_SPORTS_QUOTA { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string INTERVIEW_DATE_TIME { get; set; }
    }
}
