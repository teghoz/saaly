using Saaly.Models.Bases;

namespace Saaly.Models.Audits
{
    public class AuditEntityBillCodeCurrencyRate : AuditEntityBase
    {
        public Guid EntityBillCodeCurrencyRateGuid { get; set; }
        public Guid EntityCurrencyGuid { get; set; }
        public decimal BillCostRate { get; set; }
        public decimal BillRate { get; set; }
        public Guid EntityBillCodeGuid { get; set; }
    }
}