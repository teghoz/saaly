using Saaly.Models.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models
{
    public class Admin : SaalyBase
    {
        public string? Username { get; set; }
        public string? ReferralCode { get; set; }
        public string? DefaultPassword { get; set; }
        public Guid? ContactGuid { get; set; }
        [ForeignKey("ContactGuid")]
        public virtual Contact? Contact { get; set; }
        public bool DefaultUser { get; set; }
    }
}
