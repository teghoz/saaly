using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.Audits
{
    public class AuditEntityClientGroupClient
    {
        public Guid GroupGuid { get; set; }
        public Guid ClientGuid { get; set; }
    }
}