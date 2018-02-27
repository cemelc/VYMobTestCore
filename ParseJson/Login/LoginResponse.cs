using ParseJson.Login.LoginClasses;

namespace ParseJson.Login
{
    public class LoginResponse
    {
        public TotalBalance TotalBalance { get; set; }
        public Token Token { get; set; }
        public MemberData MemberData { get; set; }
        public string Signature { get; set; }
        public object Error { get; set; }
        public object Warning { get; set; }
        public object Warnings { get; set; }
    }
}
