using SaalyModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models
{
    public class EntityBase : SaalyBase
    {
        public Guid EntityGuid { get; set; }
        [ForeignKey("EntityGuid")]
        public Entity? Entity { get; set; }
    }
}
