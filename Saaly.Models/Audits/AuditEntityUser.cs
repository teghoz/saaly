using Saaly.Models.Bases;
using System.ComponentModel;

namespace Saaly.Models.Audits
{
    public class AuditEntityUser : AuditEntityBase
    {
        public Guid EntityUserGuid { get; set; }
        public Guid? ContactGuid { get; set; }

        [DisplayName("Employee Code")]
        public string Code { get; set; }

        [DisplayName("BillCode")]
        public Guid? BillCodeGuid { get; set; }

        [DisplayName("Department")]
        public Guid? DepartmentGuid { get; set; }
        [DisplayName("Manager")]
        public Guid? ManagerGuid { get; set; }
    }
}