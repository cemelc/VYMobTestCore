
namespace ParseJson.Login.LoginClasses
{
    public class MemberData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsVip { get; set; }
        public string MigrationType { get; set; }
        public PersonExtraData PersonExtraData { get; set; }
        public string CustomerNumber { get; set; }
        public string MiddleName { get; set; }
        public bool MustChangePassword { get; set; }
    }
}
