using Saaly.Models.Bases;

namespace Saaly.Models.Audits
{
    public class AuditEntityExpense : AuditEntityBase
    {
        public Guid EntityExpenseGuid { get; set; }
        public Guid? WorkGuid { get; set; }
        public Guid ClientGuid { get; set; }
        public Guid UserGuid { get; set; }
        public DateTime Date { get; set; }
        public string Day { get; set; }
        public string Type { get; set; }
        public string Comments { get; set; }
        public int Amount { get; set; }
    }
}