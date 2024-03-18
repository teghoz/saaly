using Saaly.Models.EntityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.Bases
{
    public class EntityBase : SaalyBase
    {
        public Guid EntityGuid { get; set; }
        [ForeignKey("EntityGuid")]
        public Entity? Entity { get; set; }

    }
}
