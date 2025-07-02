using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class ExamSeatings
    {
        public string SEATING_ID { get; set; }
        public string ROOM_ID { get; set; }
        public string COLUMN_NO { get; set; }
        public string ROW_NO { get; set; }
        public string SEAT_CODE { get; set; }
        public string SEAT_POSITION { get; set; }
        public string EXAM_TYPE { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
        public string CAMPUS_ID { get; set; }

    }
}
