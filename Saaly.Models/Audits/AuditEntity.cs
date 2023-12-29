using Saaly.Models.Bases;
using Saaly.Models.Enums;
using SaalyShared.Enums;

namespace Saaly.Models.Audits
{
    public class AuditEntity : SaalyBase
    {
        public Guid EntityGuid { get; set; }
        public eEntityTypes Types { get; set; }
        public eAuditChangeType ChangeType { get; set; }
    }
}