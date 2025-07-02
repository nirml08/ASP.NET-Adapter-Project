using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{
    public static class BloodGroupIds
    {
        public const int A = 2;
        public const int AB_Positive = 3;
        public const int AB_Negative = 4;
        public const int B_Positive = 5;
        public const int B_Negative = 6;
        public const int O_Positive = 7;
        public const int O_Negative =8;
        public const int A_Positive = 9;
        public const int A1_Negative = 10;

        public static int? GetIdByGroup(string? group)
        {
            return group switch
            {
                "A-" => A,
                "AB+" => AB_Positive,
                "AB-" => AB_Negative,
                "B+" => B_Positive,
                "B-" => B_Negative,
                "O+" => O_Positive,
                "O-" => O_Negative,
                "A+" => A_Positive,
                "A1-" => A1_Negative,
                _ => null
            };

        }
    }
}