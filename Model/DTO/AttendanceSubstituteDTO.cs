using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AttendanceSubstituteDTO
    {
        public string SUBSTITUTE_ID {  get; set; }
        public string SEMESTER_TYPE_ID {  get; set; }
        public string DAY_ORDER_DATE {  get; set; }
        public string DAY_ORDER_ID {  get; set; }
        public string HOUR_ID {  get; set; }
        public string CLASS_ID {  get; set; }
        public string COURSE_ID {  get; set; }
        public string ASSIGNED_STAFF_ID {  get; set; }
        public string SUBSTITUTE_STAFF_ID {  get; set; }
        public string ENTRY_DATE {  get; set; }
        public string ENTRY_ID {  get; set; }
        public string ACADEMIC_YEAR {  get; set; }
        public string IS_APPROVED {  get; set; }
        public string APPROVED_BY {  get; set; }
        public string CAMPUS_ID {  get; set; }
        public string IS_ACTIVE {  get; set; }
    }
}
