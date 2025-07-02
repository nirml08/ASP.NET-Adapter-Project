using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.Model.apicaldata
{
    public static class ReligionIds
    {
        public const int BUDDHIST = 3;
        public const int CHRISTIAN_OTHER_DENOMINATIONS = 4;
        public const int HINDU = 5;
        public const int JAIN = 6;
        public const int ISLAM = 7;
        public const int CHRISTIAN_CATHOLIC = 10;
        public const int SIKH = 11;
        public const int OTHER = 14;

        // Forward Lookup: Get ID by religion name
        public static int? GetIdByReligion(string? religion)
        {
            return religion?.Trim().ToUpper() switch
            {
                "BUDDHISM" => BUDDHIST,
                "CHRISTIANITY-OTHER" => CHRISTIAN_OTHER_DENOMINATIONS,
                "HINDUISM" => HINDU,
                "Jainism" => JAIN,
                "ISLAM" => ISLAM,
                "CHRISTIANITY-CATHOLIC" => CHRISTIAN_CATHOLIC,
                "SIKHISM" => SIKH,
                "OTHER" => OTHER,
                _ => null
            };
        }

        // Optional: Reverse Lookup - Get religion name by ID

        public static string FormatString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }


        public static int GetTongueId(string language) => language?.Trim() switch
        {
            "Nepali" => 1,
            "Hindi" => 2,
            "Bengali" => 3,
            "Assamese" => 4,
            "Maithili" => 5,
            "Santali" => 6,
            "Kashmiri" => 7,
            "Marathi" => 8,
            "Telegu" => 9,
            "Tamil" => 10,
            "Gujarati" => 11,
            "Urdu" => 12,
            "Kannada" => 13,
            "Odia" => 14,
            "Malayalam" => 15,
            "Punjabi" => 16,
            "Bhili/Bhilodi" => 17,
            "Gondi" => 18,
            "Sindhi" => 19,
            "Dogri" => 20,
            "Konkani" => 21,
            "Kurukh" => 22,
            "Khandeshi" => 23,
            "Tulu" => 24,
            "Meitei" => 25,
            "Bodo" => 26,
            "Khasi" => 27,
            "Ho" => 28,
            "Garo" => 29,
            "Mundari" => 30,
            "Tripuri" => 31,
            "Kui" => 32,
            "Lushai/Mizo" => 33,
            "Halabi" => 34,
            "Korku" => 35,
            "Miri/Mishing" => 36,
            "Munda" => 37,
            "Karbi/Mikir" => 38,
            "Koya" => 39,
            "Ao" => 40,
            "Savara" => 41,
            "Konyak" => 42,
            "Kharia" => 43,
            "English" => 44,
            "Malto" => 45,
            "Nissi/Dafla" => 46,
            "Adi" => 47,
            "Thado" => 48,
            "Lotha" => 49,
            "Coorgi/Kodagu" => 50,
            "Rabha" => 51,
            "Tangkhul" => 52,
            "Kisan" => 53,
            "Angami" => 54,
            "Phom" => 55,
            "Kolami" => 56,
            "Khond" => 57,
            "Dimasa" => 58,
            "Ladakhi" => 59,
            "Sema" => 60,
            "Tibetan" => 61,
            "Dzongkha" => 62,
            "Magahi" => 63,
            "Bhojpuri" => 64,
            "Angika" => 65,
            "Rongmei" => 66,
            "nepali" => 67, // this one is lowercase and separate from "Nepali"
            _ => 0
        };

    }
}