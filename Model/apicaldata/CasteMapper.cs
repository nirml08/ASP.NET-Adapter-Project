namespace adapter.Model.apicaldata
{
    public static class CasteMapper
    {
        public static int GetCasteId(string caste)
        {
            return caste?.Trim().ToUpper() switch
            {
                "OBC" => 1,
                "OBC-A" => 2,
                "OBC-B" => 3,
                "SC" => 4,
                "ST" => 5,
                "GEN" => 6,
                "GENERAL" => 6,
                "OTHERS" => 7,
                "NILL" => 8,
                _ => 0 // Default if no match found
            };
        }
    }

}
