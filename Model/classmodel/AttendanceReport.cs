using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class AttendanceReport
    {
        public string ACADEMIC_NAME { get; set; }
        public string STUDENT_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string TOTAL_HRS { get; set; }
        public string ABSENT { get; set; }
        public string OD { get; set; }
        public string FREE_ATTENDANCE { get; set; }
        public string DATE { get; set; }
        public string MONTH_NAME { get; set; }
        public string DAYS { get; set; }
        public string DAY_ID { get; set; }
        public string MOBILE { get; set; }
        public string CLASS_NAME { get; set; }
        public string ROLL_NO { get; set; }
        public string REGISTER_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string HOUR_FROM { get; set; }
        public string CLASS_ID { get; set; }
        public string ATTENDANCE_TYPE_ID { get; set; }
        public string ATTENDANCE_TYPE { get; set; }
        public string HOUR_ID { get; set; }
        public string DOB { get; set; }
        public string ATTENDANCE_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string DATE_FROM { get; set; }
        public string DATE_TO { get; set; }
        public string HOUR { get; set; }
        public string DAY_ORDER { get; set; }
        public string STAFF_CODE { get; set; }
        public string GENDER { get; set; }
        public string ATTENDENCE_DATE { get; set; }
        public string SHIFT { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string DEPARTMENT { get; set; }
        public string DAY_ORDER_DATE { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string PROGRAMME_ID { get; set; }
        public string DAYNAME { get; set; }
        public string IS_HOLIDAY { get; set; }
        public string TODAYDATE { get; set; }
        public string CLASS_YEAR { get; set; }
        public string NAME { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string ATTENDANCE_MARK { get; set; }
        public string ATTENDANCE_REMARK_ID { get; set; }
        public string TEACHING_MODE_ID { get; set; }
        public string TEACHING_MODE_NAME { get; set; }
        public string CLASS_DESCRIPTION { get; set; }
        public string CLASS_REMARK { get; set; }
        public string NO_OF_ABSENT { get; set; }
        public string STUDENT_COUNT { get; set; }
        public string ABSENT_PERCENTAGE { get; set; }
        public string ATTENED_PERCENTAGE { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string NO_OF_WORKING_DAYS { get; set; }
        public string NO_OF_ATTENED_DAYS { get; set; }
        public string BATCH_ID { get; set; }
        public int NO_OF_ATTENDED_DAYS { get; set; }
        public int TOTAL_HOURS { get; set; }
        public double PRESENT_PERCENTAGE { get; set; }
        public string DAY_ORDER_ID { get; set; }
        public string SEMESTER_ID { get; set; }
        public string COURSE_INFO_ID { get; set; }
        public string SEMESTER { get; set; }
        public string FACULTY_NAME { get; set; }
        public string TIME_TABLE_ID { get; set; }
        public string DAY { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string HOUR_TYPE_ID { get; set; }
        public string HOUR_TYPE { get; set; }
        public string CAMPUS_ID { get; set; }
        public string CAMPUS_NAME { get; set; }
        public double PRESENTPERCENTAGE { get; set; }
        public string USER_TYPE_ID { get; set; }
        public string NO_OF_HOURS { get; set; }
        public string TOTAL_USERS { get; set; }
        public string NO_OF_PRESENTS { get; set; }
        public string NO_OF_ABSENTEES { get; set; }
        public string ATTENDANCE_PERCENTAGE { get; set; }
        public string TEACHING_SYLLABUS_HOURS { get; set; }
        public string TAKEN_HOURS { get; set; }
        public string BALANCE_HOURS { get; set; }
        public string CREDITS { get; set; }
        public string IS_SUBSTITUTE { get; set; }
        public string ENTRY_TIME { get; set; }
        public string ACTUAL_CLASSES { get; set; }
        public string SEMESTER_TYPE { get; set; }
        public string SUBSTITUTE_STAFF_ID { get; set; }
        public string SUBSTITUTE_FACULTY { get; set; }

    }
    public class CourseDetail
    {
        public string COURSE_TITLE { get; set; }
        public int NO_OF_ATTENDED_DAYS { get; set; }
        public double PRESENT_PERCENTAGE { get; set; }
    }
}
