using Saaly.Models.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaalyModels
{
    public class EntityTask : EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Description")]
        public string? Description { get; set; }
        [DisplayName("Task Budget-Hours")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "Budget Hours must be a natural number")]
        [DefaultValue(0)]
        public decimal? BudgetHours { get; set; }
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
        [DisplayName("Bill Unit")]
        public Guid BillUnitGuid { get; set; }
        [DisplayName("Task Code")]
        public string Code { get; set; }
        [DisplayName("Audit Fees")]
        public decimal? AuditFees { get; set; }
        [Required]
        [DisplayName("Chargeable")]
        public bool IsChargable { get; set; }
        public Guid? ProjectGuid { get; set; }
        public Guid? Parent { get; set; }
        [ForeignKey("ProjectGuid")]
        public virtual EntityProject? Project { get; set; }
        public virtual ICollection<EntityTaskCurrencyRate> BillRates { get; set; }
        //public virtual TaskCurrencyRates TaskCurrencyRates { get; set; }
        [ForeignKey("BillUnitGuid")]
        public virtual EntityBillUnit? BillUnit { get; set; }
    }
}