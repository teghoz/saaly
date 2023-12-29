using Saaly.Models.Enums;

namespace Saaly.Models.Bases
{
    public class AuditEntityBase : EntityBase
    {
        public eAuditChangeType ChangeType { get; set; }
        public Guid EntityGuid { get; set; }
    }
}
