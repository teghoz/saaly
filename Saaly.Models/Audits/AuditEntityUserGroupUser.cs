using Saaly.Models.Bases;

namespace Saaly.Models.Audits
{
    public class AuditEntityUserGroupUser : AuditEntityBase
    {
        public Guid EntityUserGroupUserGuid { get; set; }
        public Guid EntityUserGroupGuid { get; set; }
    }
}