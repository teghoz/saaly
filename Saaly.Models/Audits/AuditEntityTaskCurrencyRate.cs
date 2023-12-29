using Saaly.Models.Bases;

namespace Saaly.Models.Audits
{
    public class AuditEntityTaskCurrencyRate : AuditEntityBase
    {
        public Guid EntityTaskCurrencyRateGuid { get; set; }
        public Guid CurrencyGuid { get; set; }
        public Guid TaskGuid { get; set; }
        //public string BillCodeID { get; set; }
        public decimal TaskCostRate { get; set; }
        public decimal TaskRate { get; set; }
    }
}