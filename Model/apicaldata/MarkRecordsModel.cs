using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{
    public class MarkRecordsModel
    {
        public int? MARK_ID { get; set; }
        public int? RECEIVE_STUID { get; set; }
        public int? SUBJECT_ID { get; set; }
        public string? SUBJECT { get; set; }
        public int? MAX_MARK { get; set; }
        public int? MARK { get; set; }
        public string? M_PASS { get; set; }
        public int? IS_DELETED { get; set; }
        public int? ACADEMIC_YEAR { get; set; }
        public int? SEMESTER_ID { get; set; }
        public double? SGPA_OR_PERCENTAGE { get; set; }
        public int? NO_OF_ATTEMPTS { get; set; }
        public int? EDUCATION_BOARD_ID { get; set; }
        public string? EDUCATION_BOARD { get; set; }
        public int? CAMPUS_ID { get; set; }
    }

}
