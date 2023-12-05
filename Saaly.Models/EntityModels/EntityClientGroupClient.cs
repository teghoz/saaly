using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityClientGroupClient
    {
        public Guid GroupGuid { get; set; }
        public Guid ClientGuid { get; set; }
        [ForeignKey("ClientGuid")]
        public EntityClient? Client { get; set; }
        [ForeignKey("GroupGuid")]
        public EntityClientGroup? Group { get; set; }
    }
}