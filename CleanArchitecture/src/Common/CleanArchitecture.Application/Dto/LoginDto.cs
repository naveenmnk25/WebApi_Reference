namespace CleanArchitecture.Application.Dto
{
    public class LoginDto
    {
        public Token Token { get; }
    }

    public sealed class Token
    {
        public string Id { get; }
        public string UserName { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string EmailId { get; }
        public string Role { get; }
        public string AuthToken { get; }
        public int ExpiresIn { get; }
        public string SocialSecurityNumber { get; }

        public Token(string id, string authToken, int expiresIn, string userName, string emailId, string role, string socialSecurityNumber, string firstName, string lastName)
        {
            Id = id;
            AuthToken = authToken;
            ExpiresIn = expiresIn;
            UserName = userName;
            EmailId = emailId;
            Role = role ?? "shareholder";
            SocialSecurityNumber = socialSecurityNumber;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}