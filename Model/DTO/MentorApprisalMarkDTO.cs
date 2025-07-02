using adapter.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class MentorApprisalMarkDTO
    {
        public string STUDENT_APPRAISAL_MARK_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string QUESTION_ID { get; set; }
        public string STU_MARK { get; set; }
        // public string STAFF_MARK { get; set; }
        public string SETTING_ID { get; set; }
        public string CAMPUS_ID { get; set; }
        public string ACADAMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }

    public class SaveApprisalFormForStudentDTO
    {
        public List<MentorApprisalMarkDTO> MentorApprisalMarks { get; set; }
        public List<MentorApprisalMainHeadRemarksDTO> MentorApprisalMainHeadRemarks { get; set; }
        public MentorApprisalSpecialApptitudeDTO MentorApprisalSpecialApptitude { get; set; }
        public MentorApprisalConcludingRemarksDTO MentorApprisalConcludingRemarks { get; set; }
    }

    public class MentorPeerApprisalMarkDTO
    {
        public string PEER_APPRAISAL_MARK_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string QUESTION_ID { get; set; }
        public string SETTING_ID { get; set; }
        public string PEER_ID { get; set; }
        public string PEER_MARK { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }

    public class SaveApprisalFormForPeerDTO
    {
        public List<MentorPeerApprisalMarkDTO> MentorPeerApprisalMarks { get; set; }
        public List<MentorApprisalMainHeadRemarksDTO> MentorApprisalMainHeadRemarks { get; set; }
        public MentorApprisalSpecialApptitudeDTO MentorApprisalSpecialApptitude { get; set; }
        public MentorApprisalConcludingRemarksDTO MentorApprisalConcludingRemarks { get; set; }
    }

    public class MentorStaffApprisalMarkDTO
    {
        public string STAFF_APPRAISAL_MARK_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string QUESTION_ID { get; set; }
        public string SETTING_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string STAFF_MARK { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CAMPUS_ID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }

    public class SaveApprisalFormForStaffDTO
    {
        public List<MentorStaffApprisalMarkDTO> MentorSatffApprisalMarks { get; set; }
        public List<MentorApprisalMainHeadRemarksDTO> MentorApprisalMainHeadRemarks { get; set; }
        public MentorApprisalSpecialApptitudeDTO MentorApprisalSpecialApptitude { get; set; }
        public MentorApprisalConcludingRemarksDTO MentorApprisalConcludingRemarks { get; set; }
    }
}
