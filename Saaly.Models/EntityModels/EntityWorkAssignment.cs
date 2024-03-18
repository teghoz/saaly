using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityWorkAssignment : EntityBase, IHistoricalAuditable
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
        public User? EntityUser { get; set; }
        [ForeignKey("JobGuid")]
        public virtual EntityJob? EntityJob { get; set; }
    }
}