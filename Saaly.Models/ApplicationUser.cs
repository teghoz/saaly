using Microsoft.AspNetCore.Identity;
using SaalyModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public Guid? EntityUserGuid { get; set; }
        public Guid? AdminGuid { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName => $@"{FirstName} {LastName}";
        public bool HasLoggedIn { get; set; }

        [ForeignKey("EntityUserGuid")]
        public virtual EntityUser? User { get; set; }
        [ForeignKey("AdminGuid")]
        public virtual Admin? Admin { get; set; }

        public bool JustInitialized { get; set; }
    }
}
