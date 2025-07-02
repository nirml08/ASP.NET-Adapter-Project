using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class MentorVisitDetailsDTO
    {
        public string MENTORS_VISIT_ID {  get; set; }
        public string STUDENT_ID {  get; set; }
        public string CLASS_ID {  get; set; }
        public string MENTOR_ID {  get; set; }
        public string NATURE_OF_VISIT {  get; set; }
        public string INITIAL_CONTACT_VISIT {  get; set; }
        public string VISIT_DATE {  get; set; }
        public string VISIT_TIME {  get; set; }
        public string VISIT_DURATION {  get; set; }
        public string MATTER_DISCUSSED {  get; set; }
        public string CONCULATION_ARRIVED_AT {  get; set; }
        public string ACTION_TAKEN {  get; set; }
        public string GENERAL_IMPRESSION {  get; set; }
        public string DATE_OF_NEXT_VISIT {  get; set; }
        public string CAMPUS_ID {  get; set; }
        public string ACADEMIC_YEAR {  get; set; }
        public string IS_ACTIVE {  get; set; }
        //
        public string STUDENT_INTERVENTION_ID {  get; set; }
        public string AREA_DESCRIPTION {  get; set; }
    }
}
