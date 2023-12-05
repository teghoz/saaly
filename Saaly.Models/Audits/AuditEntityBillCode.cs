using Saaly.Models.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.Audits
{
    public class AuditEntityBillCode : EntityBase
    {
        [Required]
        [DisplayName("Code Name")]
        public string Name { get; set; }
        [DisplayName("Descripton")]
        public string? Description { get; set; }
        [Required]
        [DisplayName("BillUnit")]
        public Guid BillUnitGuid { get; set; }
    }
}