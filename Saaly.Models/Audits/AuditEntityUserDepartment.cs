using Saaly.Models.Bases;
using System.ComponentModel;

namespace Saaly.Models.Audits
{
    public class AuditEntityUserDepartment : EntityBase
    {
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string? Description { get; set; }
        [DisplayName("Code")]
        public string Code { get; set; }
    }
}