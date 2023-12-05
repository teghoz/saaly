using Saaly.Models.Bases;
using System.ComponentModel.DataAnnotations;

namespace Saaly.Models.Audits
{
    public class AuditEntityTask : SaalyBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string? Description { get; set; }
        public decimal? BudgetHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid BillUnitGuid { get; set; }
        public string Code { get; set; }
        public decimal? AuditFees { get; set; }
        public bool IsChargable { get; set; }
        public Guid? ProjectGuid { get; set; }
        public Guid? Parent { get; set; }
    }
}