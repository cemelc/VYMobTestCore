using System;


namespace ParseJson.Login.LoginClasses
{
    public class Token
    {
        public string AccessToken { get; set; }
        public string Refresh_Token { get; set; }
        public DateTime ExpiryTime { get; set; }
        public DateTime DateTimeIssued { get; set; }
        public string MembershipNumber { get; set; }
        public string RequestApplication { get; set; }
        public string RequestedPartnerId { get; set; }
        public string ProgrammeIdentifier { get; set; }
        public object Exception { get; set; }
        public object TraceId { get; set; }
    }
}
