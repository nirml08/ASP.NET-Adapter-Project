using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{

    public static class CountryIds
    {
        public const int INDIA = 85;
        public const int NEPAL = 121;
        public const int MYANMAR = 118;
        public const int BANGLADESH = 14;
        public const int BHUTAN = 20;

        public static int? GetIdByCountryName(string? country)
        {
            return country?.Trim().ToUpper() switch
            {
                "INDIA" => INDIA,
                "NEPAL" => NEPAL,
                "MYANMAR" or "BURMA" => MYANMAR,
                "BANGLADESH" => BANGLADESH,
                "BHUTAN" => BHUTAN,
                _ => null
            };
        }
    }
}