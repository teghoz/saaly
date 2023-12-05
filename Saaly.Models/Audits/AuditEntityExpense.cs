using Saaly.Models.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.Audits
{
    public class AuditEntityExpense : EntityBase
    {
        public int ID { get; set; }
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