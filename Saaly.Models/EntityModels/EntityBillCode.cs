using Saaly.Models.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityBillCode : EntityBase
    {
        [Required]
        [DisplayName("Code Name")]
        public string Name { get; set; }
        [DisplayName("Descripton")]
        public string? Description { get; set; }
        [Required]
        [DisplayName("BillUnit")]
        public Guid BillUnitGuid { get; set; }
        [ForeignKey("BillUnitGuid")]
        public virtual EntityBillUnit? BillUnit { get; set; }
        public List<EntityBillCodeCurrencyRate>? CurrencyRates { get; set; }
    }
}