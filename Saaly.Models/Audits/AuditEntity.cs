using Saaly.Models.Bases;
using Saaly.Models.Enums;
using SaalyShared.Enums;

namespace Saaly.Models.Audits
{
    public class AuditEntity : SaalyBase
    {
        public Guid EntityGuid { get; set; }
        public eEntityTypes Type { get; set; }
        public eAuditChangeType ChangeType { get; set; }
    }
}