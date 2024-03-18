using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityUserGroupUser : EntityBase, IHistoricalAuditable
    {
        public Guid EntityUserGroupGuid { get; set; }
        public Guid EntityUserGroupUserGuid { get; set; }
        [ForeignKey("EntityUserGroupGuid")]
        public virtual EntityUserGroup? EntityUserGroup { get; set; }
        [ForeignKey("EntityUserGroupUserGuid")]
        public virtual User? EntityUser { get; set; }
    }
}