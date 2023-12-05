using Saaly.Models.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.Audits
{
    public class AuditEntityUserDepartmentClaim : EntityBase
    {
        public Guid EntityUserDepartmentGuid { get; set; }
        public string? Name { get; set; }
    }
}