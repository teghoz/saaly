using Saaly.Models.Bases;
using System.ComponentModel;

namespace Saaly.Models.Audits
{
    public class AuditEntityUserGroup : AuditEntityBase
    {
        public Guid EntityUserGroupGuid { get; set; }
        [DisplayName("Group")]
        public string Name { get; set; }
        [DisplayName("Groups Description")]
        public string? Description { get; set; }
        public bool HasMaximumCapacity { get; set; }
        [DisplayName("Groups Maximum Capacity")]
        public int MaximumCapacity { get; set; }
        [DisplayName("Groups Code")]
        public string Code { get; set; }
    }
}