using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class StaffAttendanceDetails
    {
        public string ATTENDANCE_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string ATTENDENCE_DATE { get; set; }
        public string TIME_FROM { get; set; }
        public string TIME_TO { get; set; }
        public string ATT_STATUS_ID { get; set; }
        public string STATUS_NAME { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string DATE_FROM { get; set; }
        public string DATE_TO { get; set; }
        public string USER_CODE { get; set; }
        public string BIOMETRIC_NUMBER { get; set; }
        public string STAFF_NAME { get; set; }
        public string DEPARTMENT { get; set; }
        public string USER_TYPE { get; set; }
        public string STUDENT_WORKING_COUNT { get; set; }
        public string STAFF_WORKING_COUNT { get; set; }
        public string FACULTY_WORKING_COUNT { get; set; }
        public string SUPPORTING_STAFF_WORKING_COUNT { get; set; }
        public string PRESENT_DAYS { get; set; }
        public string FIRST_ATTENDANCE_DATE { get; set; }
        public string LAST_ATTENDANCE_DATE { get; set; }
    }

    public class StaffAttendanceSummary
    {
        public string STAFF_ID { get; set; }
        public string USER_CODE { get; set; }
        public string BIOMETRIC_NUMBER { get; set; }
        public string USER_TYPE { get; set; }
        public string STAFF_NAME { get; set; }
        public string NO_OF_WORKING_DAYS { get; set; }
        public string NO_OF_PRESENT { get; set; }
        public string NO_OF_ABSENT { get; set; }
        public string FIRST_ATTENDANCE_DATE { get; set; }
        public string LAST_ATTENDANCE_DATE { get; set; }
    }
}
