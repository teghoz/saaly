using Saaly.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaalyModels
{
    public class EntityUserGroupUser : EntityBase
    {
        public Guid EntityUserGroupGuid { get; set; }
        public Guid EntityUserGroupUserGuid { get; set; }
        [ForeignKey("EntityUserGroupGuid")]
        public virtual EntityUserGroup? EntityUserGroup { get; set; }
        [ForeignKey("EntityUserGroupUserGuid")]
        public virtual EntityUser? EntityUser { get; set; }
    }
}