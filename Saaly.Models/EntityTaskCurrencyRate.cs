using Saaly.Models.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaalyModels
{
    public class EntityTaskCurrencyRate : EntityBase
    {
        public Guid CurrencyGuid { get; set; }
        public Guid TaskGuid { get; set; }
        //public string BillCodeID { get; set; }
        public decimal TaskCostRate { get; set; }
        public decimal TaskRate { get; set; }

        [ForeignKey("TaskGuid")]
        public EntityTask? Task { get; set; }
        [ForeignKey("CurrencyGuid")]
        public EntityCurrency? Currency { get; set; }
    }
}