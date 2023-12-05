using Saaly.Models.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.Audits
{
    public class AuditEntityTaskCurrencyRate : EntityBase
    {
        public Guid CurrencyGuid { get; set; }
        public Guid TaskGuid { get; set; }
        //public string BillCodeID { get; set; }
        public decimal TaskCostRate { get; set; }
        public decimal TaskRate { get; set; }
    }
}