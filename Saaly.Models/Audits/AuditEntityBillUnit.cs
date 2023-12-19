using Saaly.Models.Bases;
using System.ComponentModel;

namespace Saaly.Models.Audits
{
    public class AuditEntityBillUnit : AuditEntityBase
    {
        public Guid EntityBillUnitGuid { get; set; }
        public string Name { get; set; }
        [DisplayName("Bill-Unit Description")]
        public string? Description { get; set; }
    }
}