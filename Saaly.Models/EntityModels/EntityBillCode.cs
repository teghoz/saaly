using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityBillCode : EntityBase, IHistoricalAuditable
    {
        [Required]
        [DisplayName("Code Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string? Description { get; set; }
        [Required]
        [DisplayName("BillUnit")]
        public Guid BillUnitGuid { get; set; }
        [ForeignKey("BillUnitGuid")]
        public virtual EntityBillUnit? BillUnit { get; set; }
        public ICollection<EntityBillCodeCurrencyRate>? CurrencyRates { get; set; }
    }
}