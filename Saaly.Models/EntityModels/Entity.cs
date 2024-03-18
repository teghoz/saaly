using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using SaalyShared.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class Entity : SaalyBase, IHistoricalAuditable
    {
        public eEntityTypes Type { get; set; }
        public string? Name { get; set; }
        public Guid? OwnerGuid { get; set; }
        [ForeignKey("OwnerGuid")]
        public virtual User Owner { get; set; }
        public virtual ICollection<EntityUser> Users { get; set; }
    }
}