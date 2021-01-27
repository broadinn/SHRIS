using Microsoft.AspNetCore.Identity;

namespace SHRIS.EF.Models
{
    class ApplicationUser : IdentityUser<int>
    {
        public Employee Employee { get; set; }

    }
}
