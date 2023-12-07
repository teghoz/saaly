using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityBillCodeCurrencyRate : EntityBase, IHistoricalAuditable
    {
        public Guid EntityCurrencyGuid { get; set; }
        public decimal BillCostRate { get; set; }
        public decimal BillRate { get; set; }
        public Guid EntityBillCodeGuid { get; set; }
        [ForeignKey("EntityCurrencyGuid")]
        public EntityCurrency? Currency { get; set; }
        [ForeignKey("EntityBillCodeGuid")]
        public EntityBillCode? EntityBillCode { get; set; }
    }
}