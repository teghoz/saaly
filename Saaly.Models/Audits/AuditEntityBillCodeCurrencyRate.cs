using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.Audits
{
    public class AuditEntityBillCodeCurrencyRate : AuditEntityBillCode
    {
        public Guid EntityCurrencyGuid { get; set; }
        public decimal BillCostRate { get; set; }
        public decimal BillRate { get; set; }
        public Guid EntityBillCodeGuid { get; set; }
    }
}