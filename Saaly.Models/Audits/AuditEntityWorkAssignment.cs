using Saaly.Models.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaalyModels
{
    public class AuditEntityWorkAssignment : EntityBase
    {
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