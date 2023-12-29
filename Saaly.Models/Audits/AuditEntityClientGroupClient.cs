using Saaly.Models.Bases;
using Saaly.Models.Enums;

namespace Saaly.Models.Audits
{
    public class AuditEntityClientGroupClient : SaalyBase
    {
        public Guid EntityClientGroupClientGuid { get; set; }
        public Guid GroupGuid { get; set; }
        public Guid ClientGuid { get; set; }
        public eAuditChangeType ChangeType { get; set; }
    }
}