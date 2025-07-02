using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{
    public class SelectionProcess
    {
        public int SelectionId { get; set; }
        public string Application_No { get; set; }
        public int? Application_Type_Id { get; set; }
        public int? Programme_Id { get; set; }
        public DateTime? Selection_Date { get; set; }
        public int Selection_Type { get; set; }
        public int Selection_Cycle { get; set; }
        public int Entrance_Mark { get; set; }
        public int? Total_Cut_Off_Mark { get; set; }
        public int? Total_Secured { get; set; }
        public int? Max_Total { get; set; }
        public int Selected_By { get; set; }
        public int Verified_By { get; set; }
        public int Is_Deleted { get; set; }
        public int Is_Fee_Paid { get; set; }
        public int Receive_Id { get; set; }
        public int Is_Verified { get; set; }
        public int Is_Transfered { get; set; }
        public int Is_Canceled { get; set; }
        public int Is_Sports_Quota { get; set; }
        public int Campus_Id { get; set; }
        public string? Interview_Date_Time { get; set; } // stored as varchar(45)
    }

}
