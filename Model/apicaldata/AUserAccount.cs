namespace adapter.Model.apicaldata
{
    public class AUserAccount
    {
        public int UserAccountId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? LastLogin { get; set; }  // Consider using DateTime? if storing date-time in the future
        public int? UserId { get; set; }
        public string? Role { get; set; }
        public int? UserType { get; set; }
        public string? Photo { get; set; }
        public int? CampusId { get; set; }
        public int? IsDeleted { get; set; }
        public int? IsActive { get; set; }
        public string? USER_UNIQUE_ID { get; set; } // char(36) - likely a GUID
    }
}
