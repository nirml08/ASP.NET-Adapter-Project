using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.DTO
{
    public class DevelopmentProgrammeDTO
    {
        public string DEVELOPMENT_PROGRAMME_ID {  get; set; }
        public string STAFF_ID {  get; set; }
        public string DEVELOPMENT_PROGRAMME_TYPE_ID {  get; set; }
        public string DATE_FROM {  get; set; }
        public string DATE_TO {  get; set; }
        public string NATURE_OF_PROGRAMME {  get; set; }
        public string DURATION {  get; set; }
        public string MODE {  get; set; }
        public string CAMPUS_ID {  get; set; }
        public string ACADEMIC_YEAR {  get; set; }
        public string IS_ACTIVE {  get; set; }
        public string IS_DELETED {  get; set; }
    }
}
