using Saaly.Models.Bases;
using System.ComponentModel;

namespace Saaly.Models.Audits
{
    public class AuditEntityBillCode : AuditEntityBase
    {
        public Guid EntityBillCodeGuid { get; set; }
        [DisplayName("Code Name")]
        public string Name { get; set; }
        [DisplayName("Descripton")]
        public string? Description { get; set; }
        [DisplayName("BillUnit")]
        public Guid BillUnitGuid { get; set; }
    }
}