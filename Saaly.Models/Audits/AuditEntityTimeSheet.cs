using Saaly.Models.Bases;
using Saaly.Models.Enums;

namespace Saaly.Models.Audits
{
    public class AuditEntityTimeSheet : EntityBase
    {
        public DateTime Date { get; set; }
        public string Day { get; set; }
        public Guid ClientGuid { get; set; }
        public double WorkedHours { get; set; }
        public string? Comments { get; set; }
        public Guid UserId { get; set; }
        public Guid WorkGuid { get; set; }
        public DateTime? AssigmentDate { get; set; }
        public eTimeSheetApprovalStatus Status { get; set; }
    }
}