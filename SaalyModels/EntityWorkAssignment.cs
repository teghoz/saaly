using Saaly.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaalyModels
{
    public class EntityWorkAssignment : EntityBase
    {
        public Guid JobGuid { get; set; }
        public string JobName { get; set; }
        public Guid EntityUserGuid { get; set; }
        public string AssignedHours { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? AssigmentDate { get; set; }
        [DefaultValue(1)]
        public int isAssigned { get; set; }
        [ForeignKey("EntityUserGuid")]
        public EntityUser EntityUser { get; set; }
        [ForeignKey("JobGuid")]
        public virtual EntityJob EntityJob { get; set; }
    }
}