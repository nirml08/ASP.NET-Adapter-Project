using System;
using System.Collections.Generic;

namespace adapter.Model.apicaldata
{
    public static class FileTypeIds
    {
        public const int COMMUNITY_CERTIFICATE = 1;
        public const int DEGREE_MARK_SHEET = 2;
        public const int DEGREE_PASS_CERTIFICATE = 3;
        public const int MIGRATION_CERTIFICATE = 4;
        public const int CLASS_10_MARK_SHEET = 5;
        public const int CLASS_12_MARK_SHEET = 6;
        public const int CLASS_10_PASS_CERTIFICATE = 7;
        public const int CLASS_12_PASS_CERTIFICATE = 8;
        public const int AADHAR_CARD = 9;
        public const int PASSPORT = 10;
        public const int BAPTISM_DOCUMENTS = 11;

        // Forward Lookup: Get ID by file type name
        public static int? GetIdByFileType(int? fileType)
        {
            return fileType switch
            {
                //"COMMUNITY CERTIFICATE" => COMMUNITY_CERTIFICATE,
                //"MARK SHEET (OF DEGREE, ONLY FOR PG APPLICANTS)" => DEGREE_MARK_SHEET,
                //"PASS CERTIFICATE (OF DEGREE, ONLY FOR PG APPLICANTS)" => DEGREE_PASS_CERTIFICATE,
                //"MIGRATION CERTIFICATE" => MIGRATION_CERTIFICATE,
                //"MARK SHEET (CLASS 10)" => CLASS_10_MARK_SHEET,
                //"MARK SHEET (CLASS 12)" or "MARK SHEET (CLASS 12/PRE-BOARD)" => CLASS_12_MARK_SHEET,
                1 => CLASS_10_MARK_SHEET,  //"certificate_10"
                2 => CLASS_12_MARK_SHEET,  //"certificate_12"
                3 => AADHAR_CARD,                  //"adhaar"
                4 => DEGREE_MARK_SHEET,
                //"PASSPORT" or "PASSPORT(INTERNATIONAL STUDENTS OTHER THAN NEPAL AND BHUTAN)" => PASSPORT,
                //"BAPTISM DOCUMENTS" or "BAPTISM DOCUMENTS (ONLY FOR CHRISTIAN APPLICANTS)" => BAPTISM_DOCUMENTS,
                _ => null
            };
        }

    }
}
