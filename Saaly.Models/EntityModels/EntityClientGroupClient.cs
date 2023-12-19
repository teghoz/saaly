using Saaly.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityClientGroupClient : IHistoricalAuditable
    {
        public Guid GroupGuid { get; set; }
        public Guid ClientGuid { get; set; }
        [ForeignKey("ClientGuid")]
        public EntityClient? Client { get; set; }
        [ForeignKey("GroupGuid")]
        public EntityClientGroup? Group { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid? CreatedByUser { get; set; }
        public Guid? ModifiedByUser { get; set; }
        public DateTime? Deleted { get; set; }
        public Guid? DeletedByUser { get; set; }
    }
}