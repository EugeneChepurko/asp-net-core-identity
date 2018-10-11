using Microsoft.AspNetCore.Identity;

namespace net_core_identity.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public override string Id { get; set; }
        public int Year { get; set; }
        public override string Email { get; set; }
        public string Password { get; set; }
    }
}