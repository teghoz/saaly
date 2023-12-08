using Saaly.Models.Bases;
using SaalyModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.Audits
{
    public class AuditEntityClientBillingInfo : EntityBase
    {
        public Guid? ContactGuid { get; set; }
        [ForeignKey("ContactGuid")]
        public Contact? Contact { get; set; }
        public Guid EntityClientGuid { get; set; }
    }
}