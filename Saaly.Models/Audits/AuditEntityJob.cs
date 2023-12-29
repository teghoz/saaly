using Saaly.Models.Bases;
using System.ComponentModel;

namespace Saaly.Models.Audits
{
    public class AuditEntityJob : AuditEntityBase
    {
        public Guid EntityJobGuid { get; set; }
        [DisplayName("Job Type")]
        public string Type { get; set; }
        [DisplayName("Job Description")]
        public string? Description { get; set; }
    }
}