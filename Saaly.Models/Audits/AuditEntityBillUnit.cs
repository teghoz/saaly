using Saaly.Models.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Saaly.Models.Audits
{
    public class AuditEntityBillUnit : EntityBase
    {
        [Required]
        public string Name { get; set; }
        [DisplayName("Bill-Unit Description")]
        [Required]
        public string? Description { get; set; }
    }
}