using Saaly.Models.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaalyModels
{
    public class EntityWorkAssignment : EntityBase
    {
        public Guid JobGuid { get; set; }
        public string JobName { get; set; }
        public Guid EntityUserGuid { get; set; }
        public decimal AssignedHours { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? AssigmentDate { get; set; }
        public bool IsAssigned { get; set; }
        [ForeignKey("EntityUserGuid")]
        public EntityUser? EntityUser { get; set; }
        [ForeignKey("JobGuid")]
        public virtual EntityJob? EntityJob { get; set; }
    }
}