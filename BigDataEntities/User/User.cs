using BigDataEntities.GeneralEntities;

namespace BigDataEntities.User
{
    public class User : Base
    {
        public long UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
    }
}
