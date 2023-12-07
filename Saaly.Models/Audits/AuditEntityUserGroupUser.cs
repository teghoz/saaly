using Saaly.Models.Bases;

namespace Saaly.Models.Audits
{
    public class AuditEntityUserGroupUser : EntityBase
    {
        public Guid EntityUserGroupGuid { get; set; }
        public Guid EntityUserGroupUserGuid { get; set; }
    }
}