using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet.Protocol.Core.Types;

namespace adapter.Model.apicaldata
{
    public static class shiftmap
    {
        /*public static int IsMorningShift(String dept)
        {
            if (dept == null || dept.ToLower() == "mcom")
            {
                return 1;
            }
            else {
                return !string.IsNullOrEmpty(dept) && dept.Contains("7:00am") ? 1 : 2;
            }
        }*/
        public static int IsMorningShift1(String dept,int campus_id)
        {
            /*if(campus_id==1 && dept.ToLower() == "bca")
            {
                return 2;
            }
            else if(campus_id == 1 && dept.ToLower() != "bca")
            {
                return 1;
            }
            else if (dept != null || dept.ToLower() == "mcom")
            {
                return 1;
            }
            else
            {
                return !string.IsNullOrEmpty(dept) && dept.Contains("7:00am") ? 1 : 2;
            }*/
            if (string.IsNullOrEmpty(dept))
                return 2;
            if (campus_id == 1)
            {
                if (dept.ToLower() == "bca")
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            else if (campus_id == 2)
            {
                if (dept.Contains("7:00am") || dept.ToLower() == "mcom")
                {
                    return 1;
                }
                else { return 2; }

            }
            else
                return 2;
        }
    }

}