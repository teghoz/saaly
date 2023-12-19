using Saaly.Models.Bases;
using System.ComponentModel;

namespace Saaly.Models.Audits
{
    public class AuditEntityUserDepartment : AuditEntityBase
    {
        public Guid EntityUserDepartmentGuid { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string? Description { get; set; }
        [DisplayName("Code")]
        public string Code { get; set; }
    }
}