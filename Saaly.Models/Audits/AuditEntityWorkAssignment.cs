using Saaly.Models.Bases;

namespace Saaly.Models.Audits
{
    public class AuditEntityWorkAssignment : AuditEntityBase
    {
        public Guid EntityWorkAssignmentGuid { get; set; }
        public Guid JobGuid { get; set; }
        public string JobName { get; set; }
        public Guid EntityUserGuid { get; set; }
        public decimal AssignedHours { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? AssigmentDate { get; set; }
        public bool IsAssigned { get; set; }
    }
}