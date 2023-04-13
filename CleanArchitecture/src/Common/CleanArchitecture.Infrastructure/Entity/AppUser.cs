using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Infrastructure.Entity
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyCode { get; set; }
    }

    public class UserLogin : IdentityUserLogin<int> { }
    public class UserRole : IdentityUserRole<int>
    {

    }
    public class UserClaim : IdentityUserClaim<int> { }
    public class Role : IdentityRole<int>
    {
    }
    public class RoleClaim : IdentityRoleClaim<int> { }
    public class UserToken : IdentityUserToken<int> { }
}
