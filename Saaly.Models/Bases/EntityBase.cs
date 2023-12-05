using System.ComponentModel.DataAnnotations.Schema;
using Saaly.Models.EntityModels;

namespace Saaly.Models.Bases
{
    public class EntityBase : SaalyBase
    {
        public Guid EntityGuid { get; set; }
        [ForeignKey("EntityGuid")]
        public Entity? Entity { get; set; }
    }
}
