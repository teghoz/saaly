using Saaly.Models.Bases;

namespace Saaly.Models.Audits
{
    public class AuditEntityUserDepartmentClaim : AuditEntityBase
    {
        public Guid EntityUserDepartmentClaimGuid { get; set; }
        public Guid EntityUserDepartmentGuid { get; set; }
        public string? Name { get; set; }
    }
}