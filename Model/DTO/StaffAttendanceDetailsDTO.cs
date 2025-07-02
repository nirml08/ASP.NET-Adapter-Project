using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class StaffAttendanceDetailsDTO
    {
        public string ATTENDANCE_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string ATTENDENCE_DATE { get; set; }
        public string TIME_FROM { get; set; }
        public string TIME_TO { get; set; }
        public string ATT_STATUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }

    public class StaffAttendanceFileDTO
    {
        public string USER_CODE { get; set; }
        public string STAFF_NAME { get; set; }
        public string DATE_TIME { get; set; }
        public string ATT_STATUS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
    }

    public class UpdateStaffBiometricNumberDTO
    {
        public string USER_ID { get; set; }
        public string BIOMETRIC_NUMBER { get; set; }
        public string CAMPUS_ID { get; set; }
    }
}
