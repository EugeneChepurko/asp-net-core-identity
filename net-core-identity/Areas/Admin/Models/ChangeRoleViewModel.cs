using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace net_core_identity.Areas.Admin.Models
{
    public class ChangeRoleViewModel
    {
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public IList<string> UserRoles { get; set; }
        public IEnumerable<IdentityRole> AllRoles { get; set; }
    }
}