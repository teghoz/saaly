using Saaly.Models.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class AuditEntityUserGroupUser : EntityBase
    {
        public Guid EntityUserGroupGuid { get; set; }
        public Guid EntityUserGroupUserGuid { get; set; }
    }
}