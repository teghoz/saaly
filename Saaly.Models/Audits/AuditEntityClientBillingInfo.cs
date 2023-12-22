using Saaly.Models.Bases;

namespace Saaly.Models.Audits
{
    public class AuditEntityClientBillingInfo : AuditEntityBase
    {
        public Guid EntityClientBillingInfoGuid { get; set; }
        public Guid? ContactGuid { get; set; }
        public Contact? Contact { get; set; }
        public Guid EntityClientGuid { get; set; }
    }
}