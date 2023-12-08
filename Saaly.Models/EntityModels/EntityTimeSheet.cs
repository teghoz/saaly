using Saaly.Models.Bases;
using Saaly.Models.Enums;
using Saaly.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityTimeSheet : EntityBase, IHistoricalAuditable
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
        [ForeignKey("ClientGuid")]
        public EntityClient? Client { get; set; }
        [ForeignKey("UserId")]
        public EntityUser? User { get; set; }
        [ForeignKey("WorkGuid")]
        public EntityWorkAssignment? WorkAssignment { get; set; }

    }
}