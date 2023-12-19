using Saaly.Models.Bases;

namespace Saaly.Models.Audits
{
    public class AuditEntityGender : AuditEntityBase
    {
        public Guid EntityGenderGuid { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}