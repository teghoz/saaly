using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public Guid? UserGuid { get; set; }
        public Guid? AdminGuid { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName => $@"{FirstName} {LastName}";
        public bool HasLoggedIn { get; set; }

        [ForeignKey("UserGuid")]
        public virtual User? User { get; set; }
        [ForeignKey("AdminGuid")]
        public virtual Admin? Admin { get; set; }

        public bool JustInitialized { get; set; }
    }
}
