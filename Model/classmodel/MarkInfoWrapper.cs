using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.classmodel
{
    public class MarkInfoWrapper
    {
        public List<AdmStudentMarks> Marks12 { get; set; }
        public List<AdmStudentMarks> Marks11 { get; set; }
        public List<AdmStudentMarks> MarksUG { get; set; }
    }
}
