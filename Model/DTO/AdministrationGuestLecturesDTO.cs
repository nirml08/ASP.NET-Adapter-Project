using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class AdministrationGuestLecturesDTO
    {
        public string ADMINISTRATION_LECTURE_ID {  get; set; }
        public string LECTURE_TITLE {  get; set; }
        public string SPEAKER_NAME {  get; set; }
        public string IS_OFFLINE {  get; set; }
        public string LECTURE_DATE {  get; set; }
        public string START_TIME {  get; set; }
        public string END_TIME {  get; set; }
        public string DURATION {  get; set; }
        public string ORGANIZER {  get; set; }
        public string PLATFORM {  get; set; }
        public string LOCATION {  get; set; }
        public string DESCRIPTION {  get; set; }
        public string ACADEMIC_YEAR {  get; set; }
        public string CAMPUS_ID {  get; set; }
    }
}
