using Microsoft.AspNetCore.Identity;

namespace Music2.Models.Auth
{
    public class User: IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
