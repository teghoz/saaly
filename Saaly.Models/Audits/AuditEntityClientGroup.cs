using Saaly.Models.Bases;
using System.ComponentModel;

namespace Saaly.Models.Audits
{
    public class AuditEntityClientGroup : AuditEntityBase
    {
        public Guid EntityClientGroupGuid { get; set; }
        public string Name { get; set; }
        [DisplayName("Description")]
        public string? Description { get; set; }
        [DisplayName("Groups Has Capacity")]
        public bool HasMaximumCapacity { get; set; }
        public int MaximumCapacity { get; set; }
        [DisplayName("Code")]
        public string Code { get; set; }
    }
}